using GdaxHoarder.Data;
using GdaxHoarder.Data.Entities;
using GdaxHoarder.Data.EntityTypes;
using GdaxHoarder.Data.Validators;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdaxHoarder
{
    public partial class AddEditBurdenForm : Form
    {
        public AddEditBurdenForm()
        {
            InitializeComponent();
        }

        public AddEditBurdenForm(int burdenId) : this()
        {
            _burdenId = burdenId;
        }

        private int? _burdenId;

        private void AddEditBurdenForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(BurdenType)))
                cmbBurdenTypeId.Items.Add(item);
            cmbBurdenTypeId.SelectedIndex = 1;

            cmbCurrency.SelectedIndex = 0;

            dtpNextRunTime.Value = DateTime.Now.AddMinutes(61);

            foreach (var item in Enum.GetNames(typeof(RepeatUnits)))
                cmbRepeatUnit.Items.Add(item);
            cmbRepeatUnit.SelectedIndex = 3;
            numRepeatValue.Value = 1;

            if (_burdenId.HasValue)
            {
                var table = DbWrapper.Db.GetCollection<Burden>();
                var item = table.FindById(_burdenId.Value);

                setFormData(item);
            }
        }

        private void cmbBurden_SelectedIndexChanged(object sender, EventArgs e)
        {
            var burdenType = (BurdenType)cmbBurdenTypeId.SelectedIndex + 1;

            if (burdenType == BurdenType.DepositAch)
            {
                lblCurrency.Visible = false;
                cmbCurrency.Visible = false;
                panelAmount.Visible = true;
                lblAmount.Text = "Amount (USD)";
                panelWallet.Visible = false;
            }
            else if (burdenType == BurdenType.BuyCurrency)
            {
                lblCurrency.Visible = true;
                cmbCurrency.Visible = true;
                panelAmount.Visible = true;
                lblAmount.Text = "Amount (USD)";
                panelWallet.Visible = false;
            }
            else if (burdenType == BurdenType.WithdrawToWallet)
            {
                lblCurrency.Visible = true;
                cmbCurrency.Visible = true;
                panelAmount.Visible = true;
                lblAmount.Text = "Amount";
                panelWallet.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var populatedObject = getFormData();

            var validator = new BurdenValidator(populatedObject);
            if (validator.ValidateAdd())
            {
                var table = DbWrapper.Db.GetCollection<Burden>();
                if (_burdenId.HasValue)
                {
                    populatedObject.BurdenId = _burdenId.Value;
                    table.Update(populatedObject);
                }
                else
                {
                    table.Insert(populatedObject);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                DisplayErrors(validator.Errors);
        }

        private Burden getFormData()
        {
            var walletAddr = String.IsNullOrWhiteSpace(txtWalletAddr.Text) ? null : txtWalletAddr.Text;
            var obj = new Burden
            {
                BurdenTypeId = (BurdenType)(cmbBurdenTypeId.SelectedIndex + 1),
                BurdenTypeCurrency = (GdaxCurrency)(cmbCurrency.SelectedIndex + 1),
                BurdenTypeAmount = numAmount.Value,
                WalletAddr = walletAddr,
                NextRunTime = dtpNextRunTime.Value,
                RepeatUnit = (RepeatUnits)(cmbRepeatUnit.SelectedIndex + 1),
                RepeatValue = (int)numRepeatValue.Value
            };

            return obj;
        }

        private void setFormData(Burden item)
        {
            cmbBurdenTypeId.SelectedIndex = (int)item.BurdenTypeId - 1;
            cmbCurrency.SelectedIndex = (int)item.BurdenTypeCurrency - 1;
            numAmount.Value = item.BurdenTypeAmount;
            txtWalletAddr.Text = item.WalletAddr;
            dtpNextRunTime.Value = item.NextRunTime;
            cmbRepeatUnit.SelectedIndex = (int)item.RepeatUnit - 1;
            numRepeatValue.Value = item.RepeatValue;
        }

        /* form error handling */
        private List<ErrorProvider> errorProviders = new List<ErrorProvider>();
        private void ClearErrors()
        {
            foreach (var prov in errorProviders)
                prov.Clear();
            errorProviders.Clear();
        }

        private void DisplayErrors(Dictionary<string, string> errors)
        {
            foreach (var error in errors)
            {
                var control = Controls.Find(error.Key, true).First();

                var ep = new ErrorProvider(this);
                ep.SetIconAlignment(control, ErrorIconAlignment.MiddleLeft);
                ep.SetError(control, error.Value);
                errorProviders.Add(ep);
            }
        }
    }
}
