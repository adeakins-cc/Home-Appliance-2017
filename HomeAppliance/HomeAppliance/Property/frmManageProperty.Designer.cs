namespace HomeAppliance
{
    partial class frmManageProperty
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
            this.btnManagePropertyExit = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnNewProperty = new System.Windows.Forms.Button();
            this.lstProperty = new System.Windows.Forms.ListBox();
            this.btnManagePropertySearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnManagePropertyExit
            // 
            this.btnManagePropertyExit.Location = new System.Drawing.Point(222, 143);
            this.btnManagePropertyExit.Name = "btnManagePropertyExit";
            this.btnManagePropertyExit.Size = new System.Drawing.Size(75, 23);
            this.btnManagePropertyExit.TabIndex = 12;
            this.btnManagePropertyExit.Text = "Exit";
            this.btnManagePropertyExit.UseVisualStyleBackColor = true;
            this.btnManagePropertyExit.Click += new System.EventHandler(this.btnManagePropertyExit_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(204, 114);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteProperty.TabIndex = 11;
            this.btnDeleteProperty.Text = "Delete property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(102, 114);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(96, 23);
            this.btnUpdateProperty.TabIndex = 10;
            this.btnUpdateProperty.Text = "Update property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            // 
            // btnNewProperty
            // 
            this.btnNewProperty.Location = new System.Drawing.Point(13, 114);
            this.btnNewProperty.Name = "btnNewProperty";
            this.btnNewProperty.Size = new System.Drawing.Size(83, 23);
            this.btnNewProperty.TabIndex = 9;
            this.btnNewProperty.Text = "New property";
            this.btnNewProperty.UseVisualStyleBackColor = true;
            this.btnNewProperty.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstProperty
            // 
            this.lstProperty.FormattingEnabled = true;
            this.lstProperty.Items.AddRange(new object[] {
            "Street Name\tCity\tBuilding(number-street)"});
            this.lstProperty.Location = new System.Drawing.Point(13, 13);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(284, 95);
            this.lstProperty.TabIndex = 13;
            // 
            // btnManagePropertySearch
            // 
            this.btnManagePropertySearch.Location = new System.Drawing.Point(141, 143);
            this.btnManagePropertySearch.Name = "btnManagePropertySearch";
            this.btnManagePropertySearch.Size = new System.Drawing.Size(75, 23);
            this.btnManagePropertySearch.TabIndex = 14;
            this.btnManagePropertySearch.Text = "Search";
            this.btnManagePropertySearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(13, 143);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(122, 20);
            this.txtSearchBox.TabIndex = 15;
            // 
            // frmManageProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 176);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnManagePropertySearch);
            this.Controls.Add(this.lstProperty);
            this.Controls.Add(this.btnManagePropertyExit);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.btnNewProperty);
            this.Name = "frmManageProperty";
            this.Text = "Manage Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManagePropertyExit;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnNewProperty;
        private System.Windows.Forms.ListBox lstProperty;
        private System.Windows.Forms.Button btnManagePropertySearch;
        private System.Windows.Forms.TextBox txtSearchBox;
    }
}