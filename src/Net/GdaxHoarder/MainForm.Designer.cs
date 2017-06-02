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
            this.label1 = new System.Windows.Forms.Label();
            this.numDeposit = new System.Windows.Forms.NumericUpDown();
            this.numBtcUsd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numLtc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnBuyBtc = new System.Windows.Forms.Button();
            this.btnBuyEth = new System.Windows.Forms.Button();
            this.btnBuyLtc = new System.Windows.Forms.Button();
            this.btnBankDeposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBtcUsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLtc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekly Bank Deposit";
            // 
            // numDeposit
            // 
            this.numDeposit.Location = new System.Drawing.Point(218, 7);
            this.numDeposit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDeposit.Name = "numDeposit";
            this.numDeposit.Size = new System.Drawing.Size(170, 20);
            this.numDeposit.TabIndex = 1;
            this.numDeposit.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // numBtcUsd
            // 
            this.numBtcUsd.Location = new System.Drawing.Point(218, 33);
            this.numBtcUsd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBtcUsd.Name = "numBtcUsd";
            this.numBtcUsd.Size = new System.Drawing.Size(170, 20);
            this.numBtcUsd.TabIndex = 3;
            this.numBtcUsd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daily BTC buy";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(218, 59);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(170, 20);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Daily ETH buy";
            // 
            // numLtc
            // 
            this.numLtc.Location = new System.Drawing.Point(218, 85);
            this.numLtc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLtc.Name = "numLtc";
            this.numLtc.Size = new System.Drawing.Size(170, 20);
            this.numLtc.TabIndex = 7;
            this.numLtc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Daily LTC buy";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(231, 165);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(108, 23);
            this.btnMain.TabIndex = 8;
            this.btnMain.Text = "Does something";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnBuyBtc
            // 
            this.btnBuyBtc.Location = new System.Drawing.Point(394, 30);
            this.btnBuyBtc.Name = "btnBuyBtc";
            this.btnBuyBtc.Size = new System.Drawing.Size(108, 23);
            this.btnBuyBtc.TabIndex = 9;
            this.btnBuyBtc.Text = "Buy BTC";
            this.btnBuyBtc.UseVisualStyleBackColor = true;
            this.btnBuyBtc.Click += new System.EventHandler(this.btnBuyBtc_Click);
            // 
            // btnBuyEth
            // 
            this.btnBuyEth.Location = new System.Drawing.Point(394, 56);
            this.btnBuyEth.Name = "btnBuyEth";
            this.btnBuyEth.Size = new System.Drawing.Size(108, 23);
            this.btnBuyEth.TabIndex = 10;
            this.btnBuyEth.Text = "Buy ETH";
            this.btnBuyEth.UseVisualStyleBackColor = true;
            // 
            // btnBuyLtc
            // 
            this.btnBuyLtc.Location = new System.Drawing.Point(394, 82);
            this.btnBuyLtc.Name = "btnBuyLtc";
            this.btnBuyLtc.Size = new System.Drawing.Size(108, 23);
            this.btnBuyLtc.TabIndex = 11;
            this.btnBuyLtc.Text = "Buy LTC";
            this.btnBuyLtc.UseVisualStyleBackColor = true;
            this.btnBuyLtc.Click += new System.EventHandler(this.btnBuyLtc_Click);
            // 
            // btnBankDeposit
            // 
            this.btnBankDeposit.Location = new System.Drawing.Point(394, 4);
            this.btnBankDeposit.Name = "btnBankDeposit";
            this.btnBankDeposit.Size = new System.Drawing.Size(108, 23);
            this.btnBankDeposit.TabIndex = 12;
            this.btnBankDeposit.Text = "ACH Deposit";
            this.btnBankDeposit.UseVisualStyleBackColor = true;
            this.btnBankDeposit.Click += new System.EventHandler(this.btnBankDeposit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 200);
            this.Controls.Add(this.btnBankDeposit);
            this.Controls.Add(this.btnBuyLtc);
            this.Controls.Add(this.btnBuyEth);
            this.Controls.Add(this.btnBuyBtc);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.numLtc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numBtcUsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDeposit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "GDax Hoarder by http://howtoaddict.com";
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBtcUsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDeposit;
        private System.Windows.Forms.NumericUpDown numBtcUsd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLtc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnBuyBtc;
        private System.Windows.Forms.Button btnBuyEth;
        private System.Windows.Forms.Button btnBuyLtc;
        private System.Windows.Forms.Button btnBankDeposit;
    }
}