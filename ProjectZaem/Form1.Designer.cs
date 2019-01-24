namespace ProjectZaem
{
    partial class Form1
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
            this.CreditAmountLbl = new System.Windows.Forms.Label();
            this.CreditDeadlineLbl = new System.Windows.Forms.Label();
            this.YearInterestLbl = new System.Windows.Forms.Label();
            this.CreditAmountTxt = new System.Windows.Forms.TextBox();
            this.CreditDeadlineTxt = new System.Windows.Forms.TextBox();
            this.YearInterestTxt = new System.Windows.Forms.TextBox();
            this.MonthlyResult = new System.Windows.Forms.TextBox();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.TotalResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreditAmountLbl
            // 
            this.CreditAmountLbl.AutoSize = true;
            this.CreditAmountLbl.Location = new System.Drawing.Point(32, 23);
            this.CreditAmountLbl.Name = "CreditAmountLbl";
            this.CreditAmountLbl.Size = new System.Drawing.Size(135, 17);
            this.CreditAmountLbl.TabIndex = 0;
            this.CreditAmountLbl.Text = "Размер на кредита";
            // 
            // CreditDeadlineLbl
            // 
            this.CreditDeadlineLbl.AutoSize = true;
            this.CreditDeadlineLbl.Location = new System.Drawing.Point(32, 65);
            this.CreditDeadlineLbl.Name = "CreditDeadlineLbl";
            this.CreditDeadlineLbl.Size = new System.Drawing.Size(181, 17);
            this.CreditDeadlineLbl.TabIndex = 1;
            this.CreditDeadlineLbl.Text = "Срок на кредита в месеци";
            this.CreditDeadlineLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // YearInterestLbl
            // 
            this.YearInterestLbl.AutoSize = true;
            this.YearInterestLbl.Location = new System.Drawing.Point(32, 105);
            this.YearInterestLbl.Name = "YearInterestLbl";
            this.YearInterestLbl.Size = new System.Drawing.Size(175, 17);
            this.YearInterestLbl.TabIndex = 2;
            this.YearInterestLbl.Text = "Годишен лихвен процент";
            // 
            // CreditAmountTxt
            // 
            this.CreditAmountTxt.Location = new System.Drawing.Point(257, 23);
            this.CreditAmountTxt.Name = "CreditAmountTxt";
            this.CreditAmountTxt.Size = new System.Drawing.Size(100, 22);
            this.CreditAmountTxt.TabIndex = 3;
            // 
            // CreditDeadlineTxt
            // 
            this.CreditDeadlineTxt.Location = new System.Drawing.Point(257, 62);
            this.CreditDeadlineTxt.Name = "CreditDeadlineTxt";
            this.CreditDeadlineTxt.Size = new System.Drawing.Size(100, 22);
            this.CreditDeadlineTxt.TabIndex = 4;
            // 
            // YearInterestTxt
            // 
            this.YearInterestTxt.Location = new System.Drawing.Point(257, 105);
            this.YearInterestTxt.Name = "YearInterestTxt";
            this.YearInterestTxt.Size = new System.Drawing.Size(100, 22);
            this.YearInterestTxt.TabIndex = 5;
            this.YearInterestTxt.TextChanged += new System.EventHandler(this.YearInterestTxt_TextChanged);
            // 
            // MonthlyResult
            // 
            this.MonthlyResult.Enabled = false;
            this.MonthlyResult.Location = new System.Drawing.Point(35, 199);
            this.MonthlyResult.Name = "MonthlyResult";
            this.MonthlyResult.Size = new System.Drawing.Size(132, 22);
            this.MonthlyResult.TabIndex = 6;
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(35, 143);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(75, 23);
            this.ResultBtn.TabIndex = 7;
            this.ResultBtn.Text = "Изчисли";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // TotalResult
            // 
            this.TotalResult.Enabled = false;
            this.TotalResult.Location = new System.Drawing.Point(35, 253);
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(132, 22);
            this.TotalResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Месечна вноска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Общо изплатено по кредита";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.MonthlyResult);
            this.Controls.Add(this.YearInterestTxt);
            this.Controls.Add(this.CreditDeadlineTxt);
            this.Controls.Add(this.CreditAmountTxt);
            this.Controls.Add(this.YearInterestLbl);
            this.Controls.Add(this.CreditDeadlineLbl);
            this.Controls.Add(this.CreditAmountLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditAmountLbl;
        private System.Windows.Forms.Label CreditDeadlineLbl;
        private System.Windows.Forms.Label YearInterestLbl;
        private System.Windows.Forms.TextBox CreditAmountTxt;
        private System.Windows.Forms.TextBox CreditDeadlineTxt;
        private System.Windows.Forms.TextBox YearInterestTxt;
        private System.Windows.Forms.TextBox MonthlyResult;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.TextBox TotalResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

