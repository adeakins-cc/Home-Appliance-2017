namespace HomeAppliance
{
    partial class frmEditCategory
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
            this.btnEditCategoryExit = new System.Windows.Forms.Button();
            this.btnEditCategorySave = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditCategoryExit
            // 
            this.btnEditCategoryExit.Location = new System.Drawing.Point(126, 32);
            this.btnEditCategoryExit.Name = "btnEditCategoryExit";
            this.btnEditCategoryExit.Size = new System.Drawing.Size(75, 23);
            this.btnEditCategoryExit.TabIndex = 43;
            this.btnEditCategoryExit.Text = "Exit";
            this.btnEditCategoryExit.UseVisualStyleBackColor = true;
            // 
            // btnEditCategorySave
            // 
            this.btnEditCategorySave.Location = new System.Drawing.Point(45, 32);
            this.btnEditCategorySave.Name = "btnEditCategorySave";
            this.btnEditCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnEditCategorySave.TabIndex = 42;
            this.btnEditCategorySave.Text = "Save";
            this.btnEditCategorySave.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(101, 6);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Category Name:";
            // 
            // frmEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 65);
            this.Controls.Add(this.btnEditCategoryExit);
            this.Controls.Add(this.btnEditCategorySave);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label2);
            this.Name = "frmEditCategory";
            this.Text = "Edit Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCategoryExit;
        private System.Windows.Forms.Button btnEditCategorySave;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
    }
}