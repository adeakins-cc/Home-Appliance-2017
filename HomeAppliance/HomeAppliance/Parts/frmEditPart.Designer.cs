namespace HomeAppliance.Parts
{
    partial class frmEditPart
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
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.btnEditPartExit = new System.Windows.Forms.Button();
            this.btnEditPartSave = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Category:";
            // 
            // cobCategory
            // 
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Location = new System.Drawing.Point(76, 33);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(100, 21);
            this.cobCategory.TabIndex = 32;
            // 
            // btnEditPartExit
            // 
            this.btnEditPartExit.Location = new System.Drawing.Point(182, 57);
            this.btnEditPartExit.Name = "btnEditPartExit";
            this.btnEditPartExit.Size = new System.Drawing.Size(75, 23);
            this.btnEditPartExit.TabIndex = 31;
            this.btnEditPartExit.Text = "Exit";
            this.btnEditPartExit.UseVisualStyleBackColor = true;
            // 
            // btnEditPartSave
            // 
            this.btnEditPartSave.Location = new System.Drawing.Point(182, 28);
            this.btnEditPartSave.Name = "btnEditPartSave";
            this.btnEditPartSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditPartSave.TabIndex = 30;
            this.btnEditPartSave.Text = "Save";
            this.btnEditPartSave.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Part name:";
            // 
            // frmEditPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 87);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobCategory);
            this.Controls.Add(this.btnEditPartExit);
            this.Controls.Add(this.btnEditPartSave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmEditPart";
            this.Text = "Edit Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.Button btnEditPartExit;
        private System.Windows.Forms.Button btnEditPartSave;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}