using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdaxHoarder
{
    public partial class SetupKeys : Form
    {
        public SetupKeys()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var controls = new TextBox[] { txtPassPhrase, txtApiKey, txtSecretKey };
            foreach (var ctrl in controls)
            {
                if (String.IsNullOrEmpty(ctrl.Text))
                {
                    MessageBox.Show(this, "Please populate all Textboxes", "Data error");
                    return;
                }
            }

            var sb = new StringBuilder();
            foreach (var ctrl in controls)
                sb.AppendLine(ctrl.Text);

            sb.AppendLine("PRODUCTION");
            File.WriteAllText(AppConsts.KEYS_PATH, sb.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/howtoaddict/GdaxHoarder");
        }
    }
}
