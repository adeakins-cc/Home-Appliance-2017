namespace HomeAppliance
{
    partial class frmManageParts
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
            this.btnNewPart = new System.Windows.Forms.Button();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnManagePartsExit = new System.Windows.Forms.Button();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewPart
            // 
            this.btnNewPart.Location = new System.Drawing.Point(12, 114);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(75, 23);
            this.btnNewPart.TabIndex = 1;
            this.btnNewPart.Text = "New part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            // 
            // btnEditPart
            // 
            this.btnEditPart.Location = new System.Drawing.Point(93, 114);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(75, 23);
            this.btnEditPart.TabIndex = 2;
            this.btnEditPart.Text = "Edit part";
            this.btnEditPart.UseVisualStyleBackColor = true;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(174, 113);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePart.TabIndex = 3;
            this.btnDeletePart.Text = "Delete part";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnManagePartsExit
            // 
            this.btnManagePartsExit.Location = new System.Drawing.Point(174, 142);
            this.btnManagePartsExit.Name = "btnManagePartsExit";
            this.btnManagePartsExit.Size = new System.Drawing.Size(75, 23);
            this.btnManagePartsExit.TabIndex = 4;
            this.btnManagePartsExit.Text = "Exit";
            this.btnManagePartsExit.UseVisualStyleBackColor = true;
            // 
            // lstParts
            // 
            this.lstParts.FormattingEnabled = true;
            this.lstParts.Items.AddRange(new object[] {
            "ID        Category\tName\tPrice"});
            this.lstParts.Location = new System.Drawing.Point(13, 13);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(237, 95);
            this.lstParts.TabIndex = 5;
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.Location = new System.Drawing.Point(59, 142);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Size = new System.Drawing.Size(109, 23);
            this.btnManageCategories.TabIndex = 6;
            this.btnManageCategories.Text = "Manage categories";
            this.btnManageCategories.UseVisualStyleBackColor = true;
            // 
            // frmManageParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 172);
            this.Controls.Add(this.btnManageCategories);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.btnManagePartsExit);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnEditPart);
            this.Controls.Add(this.btnNewPart);
            this.Name = "frmManageParts";
            this.Text = "Manage Parts";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnManagePartsExit;
        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.Button btnManageCategories;
    }
}