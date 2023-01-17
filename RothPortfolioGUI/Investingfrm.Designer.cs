namespace RothPortfolioGUI
{
    partial class Investingfrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpPay = new System.Windows.Forms.GroupBox();
            this.lblSymbolDollar = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFZROX = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResultsFZILX = new System.Windows.Forms.Label();
            this.lblResultsFZROX = new System.Windows.Forms.Label();
            this.lblFZILX = new System.Windows.Forms.Label();
            this.grpCheck = new System.Windows.Forms.GroupBox();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.rad15 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpPay.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(294, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 47);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(294, 179);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(154, 47);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpPay
            // 
            this.grpPay.Controls.Add(this.lblSymbolDollar);
            this.grpPay.Controls.Add(this.txtPay);
            this.grpPay.Controls.Add(this.label1);
            this.grpPay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPay.Location = new System.Drawing.Point(12, 12);
            this.grpPay.Name = "grpPay";
            this.grpPay.Size = new System.Drawing.Size(256, 135);
            this.grpPay.TabIndex = 99;
            this.grpPay.TabStop = false;
            this.grpPay.Text = "Enter full paycheck amount";
            // 
            // lblSymbolDollar
            // 
            this.lblSymbolDollar.AutoSize = true;
            this.lblSymbolDollar.Location = new System.Drawing.Point(50, 61);
            this.lblSymbolDollar.Name = "lblSymbolDollar";
            this.lblSymbolDollar.Size = new System.Drawing.Size(20, 23);
            this.lblSymbolDollar.TabIndex = 2;
            this.lblSymbolDollar.Text = "$";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(76, 58);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(144, 31);
            this.txtPay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // lblFZROX
            // 
            this.lblFZROX.AutoSize = true;
            this.lblFZROX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblFZROX.Location = new System.Drawing.Point(6, 42);
            this.lblFZROX.Name = "lblFZROX";
            this.lblFZROX.Size = new System.Drawing.Size(64, 23);
            this.lblFZROX.TabIndex = 3;
            this.lblFZROX.Text = "FZROX:";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblResultsFZILX);
            this.grpResults.Controls.Add(this.lblResultsFZROX);
            this.grpResults.Controls.Add(this.lblFZILX);
            this.grpResults.Controls.Add(this.lblFZROX);
            this.grpResults.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpResults.Location = new System.Drawing.Point(12, 168);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(256, 159);
            this.grpResults.TabIndex = 97;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Investment Totals";
            // 
            // lblResultsFZILX
            // 
            this.lblResultsFZILX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultsFZILX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultsFZILX.Location = new System.Drawing.Point(76, 104);
            this.lblResultsFZILX.Name = "lblResultsFZILX";
            this.lblResultsFZILX.Size = new System.Drawing.Size(144, 32);
            this.lblResultsFZILX.TabIndex = 4;
            this.lblResultsFZILX.Text = "0";
            this.lblResultsFZILX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResultsFZROX
            // 
            this.lblResultsFZROX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultsFZROX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultsFZROX.Location = new System.Drawing.Point(76, 37);
            this.lblResultsFZROX.Name = "lblResultsFZROX";
            this.lblResultsFZROX.Size = new System.Drawing.Size(144, 32);
            this.lblResultsFZROX.TabIndex = 3;
            this.lblResultsFZROX.Text = "0";
            this.lblResultsFZROX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFZILX
            // 
            this.lblFZILX.AutoSize = true;
            this.lblFZILX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblFZILX.Location = new System.Drawing.Point(14, 108);
            this.lblFZILX.Name = "lblFZILX";
            this.lblFZILX.Size = new System.Drawing.Size(56, 23);
            this.lblFZILX.TabIndex = 4;
            this.lblFZILX.Text = "FZILX:";
            // 
            // grpCheck
            // 
            this.grpCheck.Controls.Add(this.rad20);
            this.grpCheck.Controls.Add(this.rad15);
            this.grpCheck.Controls.Add(this.rad10);
            this.grpCheck.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCheck.Location = new System.Drawing.Point(294, 12);
            this.grpCheck.Name = "grpCheck";
            this.grpCheck.Size = new System.Drawing.Size(154, 145);
            this.grpCheck.TabIndex = 98;
            this.grpCheck.TabStop = false;
            this.grpCheck.Text = "Percent to invest";
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.Location = new System.Drawing.Point(26, 100);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(62, 27);
            this.rad20.TabIndex = 3;
            this.rad20.Text = "20%";
            this.rad20.UseVisualStyleBackColor = true;
            // 
            // rad15
            // 
            this.rad15.AutoSize = true;
            this.rad15.Checked = true;
            this.rad15.Location = new System.Drawing.Point(26, 65);
            this.rad15.Name = "rad15";
            this.rad15.Size = new System.Drawing.Size(62, 27);
            this.rad15.TabIndex = 2;
            this.rad15.TabStop = true;
            this.rad15.Text = "15%";
            this.rad15.UseVisualStyleBackColor = true;
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Location = new System.Drawing.Point(26, 32);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(62, 27);
            this.rad10.TabIndex = 1;
            this.rad10.Text = "10%";
            this.rad10.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(294, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 47);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Investingfrm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(461, 339);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpPay);
            this.Controls.Add(this.btnCalc);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Investingfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RothIRA Investor";
            this.Load += new System.EventHandler(this.Investingfrm_Load);
            this.grpPay.ResumeLayout(false);
            this.grpPay.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.grpCheck.ResumeLayout(false);
            this.grpCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private Button btnCalc;
        private GroupBox grpPay;
        private TextBox txtPay;
        private Label label1;
        private Label lblFZROX;
        private GroupBox grpResults;
        private Label lblResultsFZILX;
        private Label lblResultsFZROX;
        private Label lblFZILX;
        private GroupBox grpCheck;
        private Label lblSymbolDollar;
        private RadioButton rad20;
        private RadioButton rad15;
        private RadioButton rad10;
        private Button btnReset;
    }
}