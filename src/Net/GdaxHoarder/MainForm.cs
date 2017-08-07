using GdaxHoarder.Data;
using GdaxHoarder.Data.Entities;
using GdaxHoarder.Data.EntityTypes;
using GdaxHoarder.Data.EntityViews;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdaxHoarder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gridBurdens.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            gridBurdenLog.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            checkForKeys();

            reloadData();

            timer1.Start();
        }

        private void checkForKeys()
        {
            if (!File.Exists(AppConsts.KEYS_PATH))
            {
                var frm = new SetupKeys();
                if (frm.ShowDialog(this) != DialogResult.OK)
                {
                    var body = @"Application can't work until API Keys are setup. Launch application again whenever you want to proceed with setup...
                        
If you need help with setup, please click Help button on Setup form";
                    MessageBox.Show(this, body, "API Keys required");
                    this.Close();
                }
            }
        }

        private void reloadData()
        {
            refreshBalances();
            loadBurdens();
            loadLog();
        }

        private async void refreshBalances()
        {
            var status = await TaskExecutor.AccountBalances();

            foreach (var balance in status.Accounts)
            {
                if (balance.Currency == "USD")
                    lblUsd.Text = String.Format("USD: {0:N2}", balance.Balance);
                else if (balance.Currency == "BTC")
                    lblBtc.Text = String.Format("BTC: {0:N8}", balance.Balance);
                else if (balance.Currency == "ETH")
                    lblEth.Text = String.Format("ETH: {0:N8}", balance.Balance);
                else if (balance.Currency == "LTC")
                    lblLtc.Text = String.Format("LTC: {0:N8}", balance.Balance);
            }
        }

        private void loadLog()
        {
            var table = DbWrapper.Db.GetCollection<BurdenLog>();
            var list = table.Find(Query.All(Query.Descending), limit: 100);

            bindingLog.Clear();
            foreach (var o in list)
                bindingLog.Add(o);
        }

        private void btnAddNewBurden_Click(object sender, EventArgs e)
        {
            var form = new AddEditBurdenForm();
            if (form.ShowDialog(this) == DialogResult.OK)
                loadBurdens();
        }

        private void loadBurdens()
        {
            var table = DbWrapper.Db.GetCollection<Burden>();
            var list = table.Find(Query.All("NextRunTime", Query.Ascending));

            bindingSource1.Clear();
            foreach (var o in list)
                bindingSource1.Add(new BurdenView(o));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadBurdens();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == gridBurdens.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
            {
                var item = bindingSource1[e.RowIndex] as BurdenView;
                var form = new AddEditBurdenForm(item.BurdenId);
                if (form.ShowDialog(this) == DialogResult.OK)
                    loadBurdens();
            }
            else if (e.ColumnIndex == 3)
            {
                var item = bindingSource1[e.RowIndex] as BurdenView;

                var table = DbWrapper.Db.GetCollection<Burden>();
                table.Delete(new BsonValue(item.BurdenId));

                loadBurdens();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == gridBurdens.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
                e.Value = "Edit";
            if (e.ColumnIndex == 3)
                e.Value = "Delete";
        }

        private DateTime _lastRefresh = DateTime.Now;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            var refreshAfter = false;

            var table = DbWrapper.Db.GetCollection<Burden>();
            var list = table.FindAll();

            foreach (var task in list)
            {
                if (task.NextRunTime < DateTime.Now)
                {
                    // TODO: Check if task correctly executed and only update NextRunTime in that case
                    var apiReached = true;
                    try
                    {
                        var success = await Execute(task);
                    }
                    catch (HttpRequestException ex)
                    {
                        apiReached = false;
                    }

                    if (apiReached)
                    {
                        task.NextRunTime = Burden.CalcNextRuntime(
                            task.NextRunTime, task.RepeatUnit, task.RepeatValue);
                        if (task.NextRunTime < DateTime.Now)
                        {
                            task.NextRunTime = Burden.CalcNextRuntime(
                            DateTime.Now, task.RepeatUnit, task.RepeatValue);
                        }

                        table.Update(task);
                        refreshAfter = true;
                    }
                }
            }

            if (refreshAfter) // || DateTime.Now.Subtract(_lastRefresh).TotalMinutes >= 5)
            {
                _lastRefresh = DateTime.Now;
                ThreadPool.QueueUserWorkItem(new WaitCallback(delayedRefresh));
            }
        }


        public static Task<bool> Execute(Burden burden)
        {
            if (burden.BurdenTypeId == BurdenType.DepositAch)
                return TaskExecutor.DepositAch(burden);
            else if (burden.BurdenTypeId == BurdenType.BuyCurrency)
                return TaskExecutor.BuyCurrency(burden);
            else if (burden.BurdenTypeId == BurdenType.WithdrawToWallet)
                return TaskExecutor.WithdrawToWallet(burden);
            else
                throw new Exception("Invalid BurdenTypeId");
        }

        private void delayedRefresh(object state)
        {
            // After production testing, it seems we need quite a bit of time 
            // for API to return correct values
            Thread.Sleep(10000);

            this.BeginInvoke(new MethodInvoker(reloadData));
        }

        private void btnLogRefresh_Click(object sender, EventArgs e)
        {
            loadLog();
        }

        private void btnBalancesRefresh_Click(object sender, EventArgs e)
        {
            refreshBalances();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }
        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }
    }
}
