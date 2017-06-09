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

        private void AddEditBurdenForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(BurdenType)))
                cmbBurdenTypeId.Items.Add(item);
            cmbBurdenTypeId.SelectedIndex = 1;

            cmbCurrency.SelectedIndex = 0;

            foreach (var item in Enum.GetNames(typeof(RepeatUnits)))
                cmbRepeatUnit.Items.Add(item);
            cmbRepeatUnit.SelectedIndex = 3;
            numRepeatValue.Value = 1;
        }

        private void cmbBurden_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currencyVisible = cmbBurdenTypeId.SelectedIndex != 0;

            lblCurrency.Visible = currencyVisible;
            cmbCurrency.Visible = currencyVisible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var populatedObject = getFormData();

            var validator = new BurdenValidator(populatedObject);
            if (validator.ValidateAdd())
            {
                using (var db = new LiteDatabase(@"C:\MyData.db"))
                {
                    var table = db.GetCollection<Burden>("burdens");
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
            var obj = new Burden
            {
                BurdenTypeId = (BurdenType)(cmbBurdenTypeId.SelectedIndex + 1),
                BurdenTypeCurrency = (GdaxCurrency)(cmbCurrency.SelectedIndex + 1),
                BurdenTypeAmount = numAmount.Value,
                NextRunTime = dtpNextRunTime.Value,
                RepeatUnit = (RepeatUnits)(cmbRepeatUnit.SelectedIndex + 1),
                RepeatValue = (int)numRepeatValue.Value
            };

            return obj;
        }

        /* form error handling */
        private List<ErrorProvider> errorProviders = new List<ErrorProvider>();
        private void ClearErrors()
        {
            foreach (var prov in errorProviders)
                prov.Clear();
            errorProviders.Clear();
        }

        private void DisplayErrors(Dictionary<string,string> errors)
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
