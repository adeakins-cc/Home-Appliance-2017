namespace HomeAppliance
{
    partial class frmManageCategories
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
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnManageCategoriesExit = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Items.AddRange(new object[] {
            "Name"});
            this.lstCategories.Location = new System.Drawing.Point(12, 12);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(191, 147);
            this.lstCategories.TabIndex = 11;
            // 
            // btnManageCategoriesExit
            // 
            this.btnManageCategoriesExit.Location = new System.Drawing.Point(114, 220);
            this.btnManageCategoriesExit.Name = "btnManageCategoriesExit";
            this.btnManageCategoriesExit.Size = new System.Drawing.Size(89, 23);
            this.btnManageCategoriesExit.TabIndex = 10;
            this.btnManageCategoriesExit.Text = "Exit";
            this.btnManageCategoriesExit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(12, 220);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteCategory.TabIndex = 9;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(114, 191);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(89, 23);
            this.btnEditCategory.TabIndex = 8;
            this.btnEditCategory.Text = "Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(12, 191);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(96, 23);
            this.btnNewCategory.TabIndex = 7;
            this.btnNewCategory.Text = "Add Category";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Category Name:";
            // 
            // frmManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 263);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.btnManageCategoriesExit);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnNewCategory);
            this.Name = "frmManageCategories";
            this.Text = "Manage Categories";
            this.Load += new System.EventHandler(this.frmManageCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnManageCategoriesExit;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}