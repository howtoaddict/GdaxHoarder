using GdaxHoarder.Data;
using GdaxHoarder.Data.Entities;
using GdaxHoarder.Data.EntityViews;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            reloadData();

            timer1.Start();
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
            {
                loadBurdens();
            }
        }

        private void loadBurdens()
        {
            var table = DbWrapper.Db.GetCollection<Burden>();
            var list = table.FindAll();

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
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
            {
                var item = bindingSource1[e.RowIndex] as BurdenView;

                var table = DbWrapper.Db.GetCollection<Burden>();
                table.Delete(new BsonValue(item.BurdenId));

                loadBurdens();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
                e.Value = "Delete";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var refreshAfter = false;

            var table = DbWrapper.Db.GetCollection<Burden>();
            var list = table.FindAll();

            foreach (var task in list)
            {
                if (task.NextRunTime < DateTime.Now)
                {
                    TaskExecutor.Execute(task);

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

            if (refreshAfter)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delayedRefresh));
            }
        }

        private void delayedRefresh(object state)
        {
            Thread.Sleep(3000);

            this.BeginInvoke(new MethodInvoker(reloadData));
        }

        private void btnLogRefresh_Click(object sender, EventArgs e)
        {
            loadLog();
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
    }
}
