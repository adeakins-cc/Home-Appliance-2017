namespace HomeAppliance.Category
{
    partial class frmNewCategory
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
            this.btnNewCategoryExit = new System.Windows.Forms.Button();
            this.btnNewCategorySave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewCategoryExit
            // 
            this.btnNewCategoryExit.Location = new System.Drawing.Point(126, 32);
            this.btnNewCategoryExit.Name = "btnNewCategoryExit";
            this.btnNewCategoryExit.Size = new System.Drawing.Size(75, 23);
            this.btnNewCategoryExit.TabIndex = 39;
            this.btnNewCategoryExit.Text = "Exit";
            this.btnNewCategoryExit.UseVisualStyleBackColor = true;
            // 
            // btnNewCategorySave
            // 
            this.btnNewCategorySave.Location = new System.Drawing.Point(45, 32);
            this.btnNewCategorySave.Name = "btnNewCategorySave";
            this.btnNewCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnNewCategorySave.TabIndex = 38;
            this.btnNewCategorySave.Text = "Save";
            this.btnNewCategorySave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Category Name:";
            // 
            // frmNewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 60);
            this.Controls.Add(this.btnNewCategoryExit);
            this.Controls.Add(this.btnNewCategorySave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmNewCategory";
            this.Text = "New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewCategoryExit;
        private System.Windows.Forms.Button btnNewCategorySave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}