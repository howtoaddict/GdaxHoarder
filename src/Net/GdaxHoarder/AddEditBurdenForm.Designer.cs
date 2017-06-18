namespace GdaxHoarder
{
    partial class AddEditBurdenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditBurdenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBurdenTypeId = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNextRunTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRepeatUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numRepeatValue = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.panelWallet = new System.Windows.Forms.Panel();
            this.txtWalletAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatValue)).BeginInit();
            this.panelAmount.SuspendLayout();
            this.panelWallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task";
            // 
            // cmbBurdenTypeId
            // 
            this.cmbBurdenTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBurdenTypeId.FormattingEnabled = true;
            this.cmbBurdenTypeId.Location = new System.Drawing.Point(96, 11);
            this.cmbBurdenTypeId.Name = "cmbBurdenTypeId";
            this.cmbBurdenTypeId.Size = new System.Drawing.Size(278, 21);
            this.cmbBurdenTypeId.TabIndex = 1;
            this.cmbBurdenTypeId.SelectedIndexChanged += new System.EventHandler(this.cmbBurden_SelectedIndexChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(12, 42);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "Bitcoin (BTC)",
            "Ethereum (ETH)",
            "Litecoin (LTC)"});
            this.cmbCurrency.Location = new System.Drawing.Point(96, 38);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(278, 21);
            this.cmbCurrency.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(8, 5);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(75, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount (USD)";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(92, 3);
            this.numAmount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(278, 20);
            this.numAmount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Next Run Time";
            // 
            // dtpNextRunTime
            // 
            this.dtpNextRunTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpNextRunTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextRunTime.Location = new System.Drawing.Point(96, 125);
            this.dtpNextRunTime.Name = "dtpNextRunTime";
            this.dtpNextRunTime.Size = new System.Drawing.Size(278, 20);
            this.dtpNextRunTime.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Repeat Unit";
            // 
            // cmbRepeatUnit
            // 
            this.cmbRepeatUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeatUnit.FormattingEnabled = true;
            this.cmbRepeatUnit.Location = new System.Drawing.Point(96, 151);
            this.cmbRepeatUnit.Name = "cmbRepeatUnit";
            this.cmbRepeatUnit.Size = new System.Drawing.Size(278, 21);
            this.cmbRepeatUnit.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Repeat Value";
            // 
            // numRepeatValue
            // 
            this.numRepeatValue.Location = new System.Drawing.Point(96, 178);
            this.numRepeatValue.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numRepeatValue.Name = "numRepeatValue";
            this.numRepeatValue.Size = new System.Drawing.Size(278, 20);
            this.numRepeatValue.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(278, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelAmount
            // 
            this.panelAmount.Controls.Add(this.numAmount);
            this.panelAmount.Controls.Add(this.lblAmount);
            this.panelAmount.Location = new System.Drawing.Point(4, 65);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(377, 26);
            this.panelAmount.TabIndex = 4;
            // 
            // panelWallet
            // 
            this.panelWallet.Controls.Add(this.txtWalletAddr);
            this.panelWallet.Controls.Add(this.label2);
            this.panelWallet.Location = new System.Drawing.Point(4, 93);
            this.panelWallet.Name = "panelWallet";
            this.panelWallet.Size = new System.Drawing.Size(377, 26);
            this.panelWallet.TabIndex = 5;
            // 
            // txtWalletAddr
            // 
            this.txtWalletAddr.Location = new System.Drawing.Point(92, 2);
            this.txtWalletAddr.Name = "txtWalletAddr";
            this.txtWalletAddr.Size = new System.Drawing.Size(278, 20);
            this.txtWalletAddr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wallet";
            // 
            // AddEditBurdenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 249);
            this.Controls.Add(this.panelWallet);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numRepeatValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRepeatUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNextRunTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cmbBurdenTypeId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditBurdenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditBurdenForm";
            this.Load += new System.EventHandler(this.AddEditBurdenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatValue)).EndInit();
            this.panelAmount.ResumeLayout(false);
            this.panelAmount.PerformLayout();
            this.panelWallet.ResumeLayout(false);
            this.panelWallet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBurdenTypeId;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNextRunTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRepeatUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numRepeatValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Panel panelWallet;
        private System.Windows.Forms.TextBox txtWalletAddr;
        private System.Windows.Forms.Label label2;
    }
}