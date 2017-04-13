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
            this.txtSearchPart = new System.Windows.Forms.TextBox();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.btnCancelPart = new System.Windows.Forms.Button();
            this.dgvPartDetails = new System.Windows.Forms.DataGridView();
            this.categoryTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CategoryTableAdapter();
            this.lblPartName = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPart
            // 
            this.btnNewPart.Location = new System.Drawing.Point(557, 101);
            this.btnNewPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(100, 28);
            this.btnNewPart.TabIndex = 1;
            this.btnNewPart.Text = "Add part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            this.btnNewPart.Click += new System.EventHandler(this.btnNewPart_Click);
            // 
            // btnEditPart
            // 
            this.btnEditPart.Location = new System.Drawing.Point(557, 135);
            this.btnEditPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(100, 28);
            this.btnEditPart.TabIndex = 2;
            this.btnEditPart.Text = "Edit part";
            this.btnEditPart.UseVisualStyleBackColor = true;
            this.btnEditPart.Click += new System.EventHandler(this.btnEditPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(557, 169);
            this.btnDeletePart.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(100, 28);
            this.btnDeletePart.TabIndex = 3;
            this.btnDeletePart.Text = "Delete part";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnManagePartsExit
            // 
            this.btnManagePartsExit.Location = new System.Drawing.Point(557, 420);
            this.btnManagePartsExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagePartsExit.Name = "btnManagePartsExit";
            this.btnManagePartsExit.Size = new System.Drawing.Size(100, 28);
            this.btnManagePartsExit.TabIndex = 4;
            this.btnManagePartsExit.Text = "Exit";
            this.btnManagePartsExit.UseVisualStyleBackColor = true;
            this.btnManagePartsExit.Click += new System.EventHandler(this.btnManagePartsExit_Click);
            // 
            // txtSearchPart
            // 
            this.txtSearchPart.Location = new System.Drawing.Point(15, 15);
            this.txtSearchPart.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPart.Name = "txtSearchPart";
            this.txtSearchPart.Size = new System.Drawing.Size(283, 22);
            this.txtSearchPart.TabIndex = 6;
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(329, 12);
            this.btnSearchPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(100, 28);
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
            this.cbbCategory.Location = new System.Drawing.Point(15, 67);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(283, 24);
            this.cbbCategory.TabIndex = 8;
            this.cbbCategory.ValueMember = "categoryId";
            this.cbbCategory.SelectionChangeCommitted += new System.EventHandler(this.cbbCategory_SelectionChangeCommitted);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.homeAppDBDataSetBindingSource;
            // 
            // homeAppDBDataSetBindingSource
            // 
            this.homeAppDBDataSetBindingSource.DataSource = this.homeAppDBDataSet;
            this.homeAppDBDataSetBindingSource.Position = 0;
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 47);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(15, 368);
            this.btnSavePart.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(100, 28);
            this.btnSavePart.TabIndex = 14;
            this.btnSavePart.Text = "Save";
            this.btnSavePart.UseVisualStyleBackColor = true;
            this.btnSavePart.Click += new System.EventHandler(this.btnSavePart_Click);
            // 
            // btnCancelPart
            // 
            this.btnCancelPart.Location = new System.Drawing.Point(164, 368);
            this.btnCancelPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelPart.Name = "btnCancelPart";
            this.btnCancelPart.Size = new System.Drawing.Size(100, 28);
            this.btnCancelPart.TabIndex = 15;
            this.btnCancelPart.Text = "Cancel";
            this.btnCancelPart.UseVisualStyleBackColor = true;
            // 
            // dgvPartDetails
            // 
            this.dgvPartDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvPartDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartDetails.Location = new System.Drawing.Point(15, 101);
            this.dgvPartDetails.MultiSelect = false;
            this.dgvPartDetails.Name = "dgvPartDetails";
            this.dgvPartDetails.ReadOnly = true;
            this.dgvPartDetails.RowTemplate.Height = 24;
            this.dgvPartDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartDetails.Size = new System.Drawing.Size(523, 193);
            this.dgvPartDetails.TabIndex = 16;
            this.dgvPartDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPartDetails_MouseClick);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(16, 309);
            this.lblPartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(75, 17);
            this.lblPartName.TabIndex = 10;
            this.lblPartName.Text = "Part Name";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(15, 329);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(249, 22);
            this.txtPartName.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(306, 309);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(309, 329);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // frmManageParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 461);
            this.Controls.Add(this.dgvPartDetails);
            this.Controls.Add(this.btnCancelPart);
            this.Controls.Add(this.btnSavePart);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.txtSearchPart);
            this.Controls.Add(this.btnManagePartsExit);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnEditPart);
            this.Controls.Add(this.btnNewPart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageParts";
            this.Text = "Manage Parts";
            this.Load += new System.EventHandler(this.frmManageParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnManagePartsExit;
        private System.Windows.Forms.TextBox txtSearchPart;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSavePart;

        private System.Windows.Forms.Button btnCancelPart;
        private System.Windows.Forms.DataGridView dgvPartDetails;
        private System.Windows.Forms.BindingSource homeAppDBDataSetBindingSource;
        private HomeAppDBDataSet homeAppDBDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private HomeAppDBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}