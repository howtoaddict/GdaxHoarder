namespace GdaxHoarder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddNewBurden = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridBurdenLog = new System.Windows.Forms.DataGridView();
            this.bindingLog = new System.Windows.Forms.BindingSource(this.components);
            this.nextRunTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.burdenLogIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burdenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.successDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.burdenLogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBurdenLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewBurden
            // 
            this.btnAddNewBurden.Location = new System.Drawing.Point(495, 167);
            this.btnAddNewBurden.Name = "btnAddNewBurden";
            this.btnAddNewBurden.Size = new System.Drawing.Size(119, 23);
            this.btnAddNewBurden.TabIndex = 1;
            this.btnAddNewBurden.Text = "Add New Task";
            this.btnAddNewBurden.UseVisualStyleBackColor = true;
            this.btnAddNewBurden.Click += new System.EventHandler(this.btnAddNewBurden_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.nextRunTimeDataGridViewTextBoxColumn,
            this.DeleteColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(611, 142);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.DataPropertyName = "Task";
            this.Task.FillWeight = 200F;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnAddNewBurden);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(370, 167);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridBurdenLog);
            this.groupBox2.Controls.Add(this.btnLogRefresh);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 213);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // btnLogRefresh
            // 
            this.btnLogRefresh.Location = new System.Drawing.Point(498, 185);
            this.btnLogRefresh.Name = "btnLogRefresh";
            this.btnLogRefresh.Size = new System.Drawing.Size(119, 23);
            this.btnLogRefresh.TabIndex = 4;
            this.btnLogRefresh.Text = "Refresh";
            this.btnLogRefresh.UseVisualStyleBackColor = true;
            this.btnLogRefresh.Click += new System.EventHandler(this.btnLogRefresh_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BurdenTypeId";
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Task";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gridBurdenLog
            // 
            this.gridBurdenLog.AllowUserToAddRows = false;
            this.gridBurdenLog.AllowUserToDeleteRows = false;
            this.gridBurdenLog.AutoGenerateColumns = false;
            this.gridBurdenLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBurdenLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.burdenLogIdDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.burdenNameDataGridViewTextBoxColumn,
            this.successDataGridViewCheckBoxColumn,
            this.burdenLogNameDataGridViewTextBoxColumn});
            this.gridBurdenLog.DataSource = this.bindingLog;
            this.gridBurdenLog.Location = new System.Drawing.Point(6, 19);
            this.gridBurdenLog.Name = "gridBurdenLog";
            this.gridBurdenLog.ReadOnly = true;
            this.gridBurdenLog.Size = new System.Drawing.Size(608, 160);
            this.gridBurdenLog.TabIndex = 5;
            // 
            // bindingLog
            // 
            this.bindingLog.DataSource = typeof(GdaxHoarder.Data.Entities.BurdenLog);
            // 
            // nextRunTimeDataGridViewTextBoxColumn
            // 
            this.nextRunTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nextRunTimeDataGridViewTextBoxColumn.DataPropertyName = "NextRunTime";
            this.nextRunTimeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nextRunTimeDataGridViewTextBoxColumn.HeaderText = "NextRunTime";
            this.nextRunTimeDataGridViewTextBoxColumn.Name = "nextRunTimeDataGridViewTextBoxColumn";
            this.nextRunTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextRunTimeDataGridViewTextBoxColumn.Width = 97;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GdaxHoarder.Data.EntityViews.BurdenView);
            // 
            // burdenLogIdDataGridViewTextBoxColumn
            // 
            this.burdenLogIdDataGridViewTextBoxColumn.DataPropertyName = "BurdenLogId";
            this.burdenLogIdDataGridViewTextBoxColumn.HeaderText = "BurdenLogId";
            this.burdenLogIdDataGridViewTextBoxColumn.Name = "burdenLogIdDataGridViewTextBoxColumn";
            this.burdenLogIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.burdenLogIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 110;
            // 
            // burdenNameDataGridViewTextBoxColumn
            // 
            this.burdenNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.burdenNameDataGridViewTextBoxColumn.DataPropertyName = "BurdenName";
            this.burdenNameDataGridViewTextBoxColumn.HeaderText = "BurdenName";
            this.burdenNameDataGridViewTextBoxColumn.Name = "burdenNameDataGridViewTextBoxColumn";
            this.burdenNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // successDataGridViewCheckBoxColumn
            // 
            this.successDataGridViewCheckBoxColumn.DataPropertyName = "Success";
            this.successDataGridViewCheckBoxColumn.HeaderText = "Success";
            this.successDataGridViewCheckBoxColumn.Name = "successDataGridViewCheckBoxColumn";
            this.successDataGridViewCheckBoxColumn.ReadOnly = true;
            this.successDataGridViewCheckBoxColumn.Width = 60;
            // 
            // burdenLogNameDataGridViewTextBoxColumn
            // 
            this.burdenLogNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.burdenLogNameDataGridViewTextBoxColumn.DataPropertyName = "BurdenLogName";
            this.burdenLogNameDataGridViewTextBoxColumn.HeaderText = "BurdenLogName";
            this.burdenLogNameDataGridViewTextBoxColumn.Name = "burdenLogNameDataGridViewTextBoxColumn";
            this.burdenLogNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDax Hoarder by http://howtoaddict.com";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBurdenLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewBurden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextRunTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogRefresh;
        private System.Windows.Forms.DataGridView gridBurdenLog;
        private System.Windows.Forms.BindingSource bindingLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn burdenLogIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn burdenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn successDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn burdenLogNameDataGridViewTextBoxColumn;
    }
}