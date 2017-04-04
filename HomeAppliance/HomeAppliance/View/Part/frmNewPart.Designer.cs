namespace HomeAppliance
{
    partial class frmNewPart
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
            this.btnNewPartExit = new System.Windows.Forms.Button();
            this.btnNewPartSave = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewPartExit
            // 
            this.btnNewPartExit.Location = new System.Drawing.Point(182, 57);
            this.btnNewPartExit.Name = "btnNewPartExit";
            this.btnNewPartExit.Size = new System.Drawing.Size(75, 23);
            this.btnNewPartExit.TabIndex = 23;
            this.btnNewPartExit.Text = "Exit";
            this.btnNewPartExit.UseVisualStyleBackColor = true;
            this.btnNewPartExit.Click += new System.EventHandler(this.btnNewPartExit_Click);
            // 
            // btnNewPartSave
            // 
            this.btnNewPartSave.Location = new System.Drawing.Point(182, 28);
            this.btnNewPartSave.Name = "btnNewPartSave";
            this.btnNewPartSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewPartSave.TabIndex = 22;
            this.btnNewPartSave.Text = "Save";
            this.btnNewPartSave.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Price:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Part name:";
            // 
            // cobCategory
            // 
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Location = new System.Drawing.Point(76, 33);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(100, 21);
            this.cobCategory.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Category:";
            // 
            // frmNewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobCategory);
            this.Controls.Add(this.btnNewPartExit);
            this.Controls.Add(this.btnNewPartSave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmNewPart";
            this.Text = "New Part";
            this.Load += new System.EventHandler(this.frmNewPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPartExit;
        private System.Windows.Forms.Button btnNewPartSave;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.Label label1;
    }
}