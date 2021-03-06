﻿namespace HomeAppliance.View.Invoice
{
    partial class frmAddPart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numQTY = new System.Windows.Forms.NumericUpDown();
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.tableAdapterManager = new HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager();
            this.partTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.PartTableAdapter();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(67, 143);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(209, 20);
            this.txtSearchName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(201, 170);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 5;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity:";
            // 
            // numQTY
            // 
            this.numQTY.Location = new System.Drawing.Point(67, 173);
            this.numQTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQTY.Name = "numQTY";
            this.numQTY.Size = new System.Drawing.Size(128, 20);
            this.numQTY.TabIndex = 8;
            this.numQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FinacialTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.PartsListTableAdapter = null;
            this.tableAdapterManager.PartTableAdapter = this.partTableAdapter;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.TaxesTableAdapter = null;
            this.tableAdapterManager.TechnicianTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.homeAppDBDataSet;
            // 
            // dataGridParts
            // 
            this.dataGridParts.AllowUserToAddRows = false;
            this.dataGridParts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridParts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridParts.AutoGenerateColumns = false;
            this.dataGridParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridParts.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.partBindingSource, "partId", true));
            this.dataGridParts.DataSource = this.partBindingSource;
            this.dataGridParts.Location = new System.Drawing.Point(13, 13);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridParts.RowHeadersVisible = false;
            this.dataGridParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParts.Size = new System.Drawing.Size(344, 124);
            this.dataGridParts.TabIndex = 9;
            this.dataGridParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridParts_CellContentClick);
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "partId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "partId";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partIdDataGridViewTextBoxColumn.Visible = false;
            this.partIdDataGridViewTextBoxColumn.Width = 59;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "categoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "categoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            this.categoryIdDataGridViewTextBoxColumn.Width = 82;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 58;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 55;
            // 
            // frmAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 213);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.numQTY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPart";
            this.Text = "frmAddPart";
            this.Load += new System.EventHandler(this.frmAddPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQTY;
        private HomeAppDBDataSet homeAppDBDataSet;
        private HomeAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HomeAppDBDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}