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
            using (var db = new LiteDatabase(@"C:\MyData.db"))
            {
                var table = db.GetCollection<Burden>("burdens");
                var list = table.FindAll();

                bindingSource1.Clear();
                foreach (var o in list)
                    bindingSource1.Add(new BurdenView(o));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadBurdens();
        }
    }
}
