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
            this.SuspendLayout();
            // 
            // firstNumTb
            // 
            this.firstNumTb.Location = new System.Drawing.Point(170, 111);
            this.firstNumTb.Name = "firstNumTb";
            this.firstNumTb.Size = new System.Drawing.Size(105, 20);
            this.firstNumTb.TabIndex = 0;
            // 
            // secondNumTb
            // 
            this.secondNumTb.Location = new System.Drawing.Point(170, 159);
            this.secondNumTb.Name = "secondNumTb";
            this.secondNumTb.Size = new System.Drawing.Size(105, 20);
            this.secondNumTb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 224);
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
            this.resultLbl.Location = new System.Drawing.Point(202, 269);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(13, 13);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 347);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondNumTb);
            this.Controls.Add(this.firstNumTb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumTb;
        private System.Windows.Forms.TextBox secondNumTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLbl;
    }
}

