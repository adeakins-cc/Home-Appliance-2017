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
            this.components = new System.ComponentModel.Container();
            this.btnNewPart = new System.Windows.Forms.Button();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnManagePartsExit = new System.Windows.Forms.Button();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.txtCancel = new System.Windows.Forms.Button();
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.homeAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPart
            // 
            this.btnNewPart.Location = new System.Drawing.Point(328, 62);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(75, 23);
            this.btnNewPart.TabIndex = 1;
            this.btnNewPart.Text = "Add part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            this.btnNewPart.Click += new System.EventHandler(this.btnNewPart_Click);
            // 
            // btnEditPart
            // 
            this.btnEditPart.Location = new System.Drawing.Point(328, 96);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(75, 23);
            this.btnEditPart.TabIndex = 2;
            this.btnEditPart.Text = "Edit part";
            this.btnEditPart.UseVisualStyleBackColor = true;
            this.btnEditPart.Click += new System.EventHandler(this.btnEditPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(328, 130);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePart.TabIndex = 3;
            this.btnDeletePart.Text = "Delete part";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnManagePartsExit
            // 
            this.btnManagePartsExit.Location = new System.Drawing.Point(328, 305);
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
            this.lstParts.Location = new System.Drawing.Point(11, 62);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(311, 147);
            this.lstParts.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(247, 10);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPart.TabIndex = 7;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            // 
            // cbbCategory
            // 
            this.cbbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "categoryId", true));
            this.cbbCategory.DataSource = this.categoryBindingSource;
            this.cbbCategory.DisplayMember = "name";
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(11, 228);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(213, 21);
            this.cbbCategory.TabIndex = 8;
            this.cbbCategory.ValueMember = "categoryId";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(11, 212);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(12, 257);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(57, 13);
            this.lblPartName.TabIndex = 10;
            this.lblPartName.Text = "Part Name";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(11, 273);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(213, 20);
            this.txtPartName.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(243, 273);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(105, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(244, 257);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(11, 305);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(75, 23);
            this.btnSavePart.TabIndex = 14;
            this.btnSavePart.Text = "Save";
            this.btnSavePart.UseVisualStyleBackColor = true;
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(123, 305);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 15;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeAppDBDataSetBindingSource
            // 
            this.homeAppDBDataSetBindingSource.DataSource = this.homeAppDBDataSet;
            this.homeAppDBDataSetBindingSource.Position = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.homeAppDBDataSetBindingSource;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 335);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.btnSavePart);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.btnManagePartsExit);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnEditPart);
            this.Controls.Add(this.btnNewPart);
            this.Name = "frmManageParts";
            this.Text = "Manage Parts";
            this.Load += new System.EventHandler(this.frmManageParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnManagePartsExit;
        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.BindingSource homeAppDBDataSetBindingSource;
        private HomeAppDBDataSet homeAppDBDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private HomeAppDBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}