namespace HomeAppliance.View.Invoice
{
    partial class frmPropertySearch
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
            this.dgvBuildings = new System.Windows.Forms.DataGridView();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBuildingList = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.tvStreetList = new System.Windows.Forms.TreeView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSuperPhone = new System.Windows.Forms.TextBox();
            this.txtSuperintendent = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtBuildingStreet = new System.Windows.Forms.TextBox();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtSearchProperty = new System.Windows.Forms.TextBox();
            this.btnManagePropertySearch = new System.Windows.Forms.Button();
            this.btnManagePropertyExit = new System.Windows.Forms.Button();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildings)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuildings
            // 
            this.dgvBuildings.AllowUserToAddRows = false;
            this.dgvBuildings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuildings.Location = new System.Drawing.Point(274, 59);
            this.dgvBuildings.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBuildings.MultiSelect = false;
            this.dgvBuildings.Name = "dgvBuildings";
            this.dgvBuildings.ReadOnly = true;
            this.dgvBuildings.RowTemplate.Height = 24;
            this.dgvBuildings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuildings.Size = new System.Drawing.Size(358, 340);
            this.dgvBuildings.TabIndex = 38;
            this.dgvBuildings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuildings_CellContentClick_1);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.textBox2);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Controls.Add(this.textBox1);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.cboCustomer);
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Location = new System.Drawing.Point(367, 404);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(265, 160);
            this.GroupBox2.TabIndex = 35;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Owner Details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(249, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Address2:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Address1:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(6, 38);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(249, 21);
            this.cboCustomer.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Customer:";
            // 
            // lblBuildingList
            // 
            this.lblBuildingList.AutoSize = true;
            this.lblBuildingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingList.Location = new System.Drawing.Point(271, 38);
            this.lblBuildingList.Name = "lblBuildingList";
            this.lblBuildingList.Size = new System.Drawing.Size(107, 17);
            this.lblBuildingList.TabIndex = 34;
            this.lblBuildingList.Text = "Street Buildings";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(12, 39);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(94, 17);
            this.lblStreetName.TabIndex = 33;
            this.lblStreetName.Text = "Street Names";
            // 
            // tvStreetList
            // 
            this.tvStreetList.Location = new System.Drawing.Point(12, 59);
            this.tvStreetList.Name = "tvStreetList";
            this.tvStreetList.Size = new System.Drawing.Size(257, 339);
            this.tvStreetList.TabIndex = 32;
            this.tvStreetList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStreetList_AfterSelect);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cboCity);
            this.GroupBox1.Controls.Add(this.txtSuperPhone);
            this.GroupBox1.Controls.Add(this.txtSuperintendent);
            this.GroupBox1.Controls.Add(this.txtUnits);
            this.GroupBox1.Controls.Add(this.txtBuildingStreet);
            this.GroupBox1.Controls.Add(this.txtBuildingNumber);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Location = new System.Drawing.Point(13, 404);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(348, 160);
            this.GroupBox1.TabIndex = 31;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Property Details";
            // 
            // txtSuperPhone
            // 
            this.txtSuperPhone.Location = new System.Drawing.Point(204, 123);
            this.txtSuperPhone.Name = "txtSuperPhone";
            this.txtSuperPhone.ReadOnly = true;
            this.txtSuperPhone.Size = new System.Drawing.Size(109, 20);
            this.txtSuperPhone.TabIndex = 35;
            // 
            // txtSuperintendent
            // 
            this.txtSuperintendent.Location = new System.Drawing.Point(11, 123);
            this.txtSuperintendent.Name = "txtSuperintendent";
            this.txtSuperintendent.ReadOnly = true;
            this.txtSuperintendent.Size = new System.Drawing.Size(160, 20);
            this.txtSuperintendent.TabIndex = 34;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(204, 81);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.ReadOnly = true;
            this.txtUnits.Size = new System.Drawing.Size(109, 20);
            this.txtUnits.TabIndex = 33;
            // 
            // txtBuildingStreet
            // 
            this.txtBuildingStreet.Location = new System.Drawing.Point(97, 38);
            this.txtBuildingStreet.Name = "txtBuildingStreet";
            this.txtBuildingStreet.ReadOnly = true;
            this.txtBuildingStreet.Size = new System.Drawing.Size(216, 20);
            this.txtBuildingStreet.TabIndex = 32;
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(9, 40);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.ReadOnly = true;
            this.txtBuildingNumber.Size = new System.Drawing.Size(69, 20);
            this.txtBuildingNumber.TabIndex = 31;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(201, 107);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(72, 16);
            this.Label9.TabIndex = 26;
            this.Label9.Text = "Super Phone";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(8, 104);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(104, 16);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Superintendent";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(201, 62);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Units";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(8, 62);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 16);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "City";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(94, 24);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(235, 16);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Street";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(6, 24);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 16);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Number";
            // 
            // txtSearchProperty
            // 
            this.txtSearchProperty.Location = new System.Drawing.Point(12, 12);
            this.txtSearchProperty.Name = "txtSearchProperty";
            this.txtSearchProperty.Size = new System.Drawing.Size(203, 20);
            this.txtSearchProperty.TabIndex = 30;
            // 
            // btnManagePropertySearch
            // 
            this.btnManagePropertySearch.Location = new System.Drawing.Point(221, 12);
            this.btnManagePropertySearch.Name = "btnManagePropertySearch";
            this.btnManagePropertySearch.Size = new System.Drawing.Size(75, 23);
            this.btnManagePropertySearch.TabIndex = 29;
            this.btnManagePropertySearch.Text = "Search";
            this.btnManagePropertySearch.UseVisualStyleBackColor = true;
            this.btnManagePropertySearch.Click += new System.EventHandler(this.btnManagePropertySearch_Click);
            // 
            // btnManagePropertyExit
            // 
            this.btnManagePropertyExit.Location = new System.Drawing.Point(538, 570);
            this.btnManagePropertyExit.Name = "btnManagePropertyExit";
            this.btnManagePropertyExit.Size = new System.Drawing.Size(94, 23);
            this.btnManagePropertyExit.TabIndex = 28;
            this.btnManagePropertyExit.Text = "Exit";
            this.btnManagePropertyExit.UseVisualStyleBackColor = true;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(11, 80);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(160, 21);
            this.cboCity.TabIndex = 36;
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.homeAppDBDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FinacialTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.PartsListTableAdapter = null;
            this.tableAdapterManager.PartTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.TaxesTableAdapter = null;
            this.tableAdapterManager.TechnicianTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPropertySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 601);
            this.Controls.Add(this.dgvBuildings);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lblBuildingList);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.tvStreetList);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtSearchProperty);
            this.Controls.Add(this.btnManagePropertySearch);
            this.Controls.Add(this.btnManagePropertyExit);
            this.Name = "frmPropertySearch";
            this.Text = "frmPropertySearch";
            this.Load += new System.EventHandler(this.frmPropertySearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildings)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuildings;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBuildingList;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.TreeView tvStreetList;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtSuperPhone;
        private System.Windows.Forms.TextBox txtSuperintendent;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtBuildingStreet;
        private System.Windows.Forms.TextBox txtBuildingNumber;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox txtSearchProperty;
        private System.Windows.Forms.Button btnManagePropertySearch;
        private System.Windows.Forms.Button btnManagePropertyExit;
        private System.Windows.Forms.ComboBox cboCity;
        private HomeAppDBDataSet homeAppDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private HomeAppDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private HomeAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}