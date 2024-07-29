namespace WinCalculator
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
            this.firstNumTb = new System.Windows.Forms.TextBox();
            this.secondNumTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnMinus = new System.Windows.Forms.RadioButton();
            this.rBtnDivide = new System.Windows.Forms.RadioButton();
            this.rBtnMultiply = new System.Windows.Forms.RadioButton();
            this.rBtnPlus = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // firstNumTb
            // 
            this.firstNumTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstNumTb.Location = new System.Drawing.Point(91, 105);
            this.firstNumTb.Name = "firstNumTb";
            this.firstNumTb.Size = new System.Drawing.Size(78, 26);
            this.firstNumTb.TabIndex = 0;
            // 
            // secondNumTb
            // 
            this.secondNumTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondNumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.secondNumTb.Location = new System.Drawing.Point(91, 183);
            this.secondNumTb.Name = "secondNumTb";
            this.secondNumTb.Size = new System.Drawing.Size(78, 26);
            this.secondNumTb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(91, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultLbl.Font = new System.Drawing.Font("MS Gothic", 24F);
            this.resultLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultLbl.Location = new System.Drawing.Point(110, 266);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 33);
            this.resultLbl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculator";
            // 
            // rBtnMinus
            // 
            this.rBtnMinus.AutoSize = true;
            this.rBtnMinus.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rBtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnMinus.Location = new System.Drawing.Point(111, 139);
            this.rBtnMinus.Name = "rBtnMinus";
            this.rBtnMinus.Size = new System.Drawing.Size(18, 36);
            this.rBtnMinus.TabIndex = 6;
            this.rBtnMinus.TabStop = true;
            this.rBtnMinus.Text = "-";
            this.rBtnMinus.UseVisualStyleBackColor = true;
            this.rBtnMinus.CheckedChanged += new System.EventHandler(this.rBtnMinus_CheckedChanged);
            // 
            // rBtnDivide
            // 
            this.rBtnDivide.AutoSize = true;
            this.rBtnDivide.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rBtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnDivide.Location = new System.Drawing.Point(153, 139);
            this.rBtnDivide.Name = "rBtnDivide";
            this.rBtnDivide.Size = new System.Drawing.Size(17, 36);
            this.rBtnDivide.TabIndex = 7;
            this.rBtnDivide.TabStop = true;
            this.rBtnDivide.Text = "/";
            this.rBtnDivide.UseVisualStyleBackColor = true;
            this.rBtnDivide.CheckedChanged += new System.EventHandler(this.rBtnDivide_CheckedChanged);
            // 
            // rBtnMultiply
            // 
            this.rBtnMultiply.AutoSize = true;
            this.rBtnMultiply.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rBtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnMultiply.Location = new System.Drawing.Point(131, 139);
            this.rBtnMultiply.Name = "rBtnMultiply";
            this.rBtnMultiply.Size = new System.Drawing.Size(20, 36);
            this.rBtnMultiply.TabIndex = 5;
            this.rBtnMultiply.TabStop = true;
            this.rBtnMultiply.Text = "x";
            this.rBtnMultiply.UseVisualStyleBackColor = true;
            this.rBtnMultiply.CheckedChanged += new System.EventHandler(this.rBtnMultiply_CheckedChanged);
            // 
            // rBtnPlus
            // 
            this.rBtnPlus.AutoSize = true;
            this.rBtnPlus.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rBtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnPlus.Location = new System.Drawing.Point(88, 139);
            this.rBtnPlus.Name = "rBtnPlus";
            this.rBtnPlus.Size = new System.Drawing.Size(22, 36);
            this.rBtnPlus.TabIndex = 4;
            this.rBtnPlus.TabStop = true;
            this.rBtnPlus.Text = "+";
            this.rBtnPlus.UseVisualStyleBackColor = true;
            this.rBtnPlus.CheckedChanged += new System.EventHandler(this.rBtnPlus_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(277, 311);
            this.Controls.Add(this.rBtnPlus);
            this.Controls.Add(this.rBtnMultiply);
            this.Controls.Add(this.rBtnDivide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtnMinus);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondNumTb);
            this.Controls.Add(this.firstNumTb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumTb;
        private System.Windows.Forms.TextBox secondNumTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnMinus;
        private System.Windows.Forms.RadioButton rBtnDivide;
        private System.Windows.Forms.RadioButton rBtnMultiply;
        private System.Windows.Forms.RadioButton rBtnPlus;
    }
}

