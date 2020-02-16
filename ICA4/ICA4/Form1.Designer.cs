namespace ICA4
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
            this.CodeBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LRLbl = new System.Windows.Forms.Label();
            this.OCLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KCLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.FormattingEnabled = true;
            this.CodeBox.Location = new System.Drawing.Point(172, 12);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(147, 173);
            this.CodeBox.TabIndex = 0;
            this.CodeBox.SelectedIndexChanged += new System.EventHandler(this.CodeBox_SelectedIndexChanged);
            this.CodeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longest Run:";
            // 
            // LRLbl
            // 
            this.LRLbl.AutoSize = true;
            this.LRLbl.Location = new System.Drawing.Point(100, 137);
            this.LRLbl.Name = "LRLbl";
            this.LRLbl.Size = new System.Drawing.Size(10, 13);
            this.LRLbl.TabIndex = 3;
            this.LRLbl.Text = "-";
            // 
            // OCLbl
            // 
            this.OCLbl.AutoSize = true;
            this.OCLbl.Location = new System.Drawing.Point(100, 108);
            this.OCLbl.Name = "OCLbl";
            this.OCLbl.Size = new System.Drawing.Size(10, 13);
            this.OCLbl.TabIndex = 4;
            this.OCLbl.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ones Count: ";
            // 
            // KCLbl
            // 
            this.KCLbl.AutoSize = true;
            this.KCLbl.Location = new System.Drawing.Point(100, 28);
            this.KCLbl.Name = "KCLbl";
            this.KCLbl.Size = new System.Drawing.Size(10, 13);
            this.KCLbl.TabIndex = 6;
            this.KCLbl.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 212);
            this.Controls.Add(this.KCLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OCLbl);
            this.Controls.Add(this.LRLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ICA04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LRLbl;
        private System.Windows.Forms.Label OCLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label KCLbl;
    }
}

