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

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadBurdens();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
            {
                var item = bindingSource1[e.RowIndex] as BurdenView;

                using (var db = new LiteDatabase(@"C:\MyData.db"))
                {
                    var table = db.GetCollection<Burden>("burdens");
                    table.Delete(new BsonValue(item.BurdenId));
                }

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
    }
}
