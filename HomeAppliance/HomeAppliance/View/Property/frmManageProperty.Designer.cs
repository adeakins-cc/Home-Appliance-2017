namespace HomeAppliance.View.Property
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtAddress02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblBuildingList = new System.Windows.Forms.Label();
            this.txtSuperPhone = new System.Windows.Forms.TextBox();
            this.txtSuperintendent = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtBuildingStreet = new System.Windows.Forms.TextBox();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.lblDateActive = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnSaveNewProperty = new System.Windows.Forms.Button();
            this.dgvBuildings = new System.Windows.Forms.DataGridView();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnCancelP = new System.Windows.Forms.Button();
            this.tvStreetList = new System.Windows.Forms.TreeView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSet11 = new HomeAppliance.HomeAppDBDataSet1();
            this.txtSearchProperty = new System.Windows.Forms.TextBox();
            this.btnManagePropertySearch = new System.Windows.Forms.Button();
            this.btnManagePropertyExit = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnNewProperty = new System.Windows.Forms.Button();
            this.homeAppDBDataSet1 = new HomeAppliance.HomeAppDBDataSet();
            this.cityTableAdapter1 = new HomeAppliance.HomeAppDBDataSetTableAdapters.CityTableAdapter();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new HomeAppliance.HomeAppDBDataSet1TableAdapters.CityTableAdapter();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildings)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtCustID);
            this.GroupBox2.Controls.Add(this.txtCustomer);
            this.GroupBox2.Controls.Add(this.txtAddress02);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Controls.Add(this.txtAddress01);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Location = new System.Drawing.Point(486, 495);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(353, 207);
            this.GroupBox2.TabIndex = 35;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Owner Details";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(266, 17);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(74, 22);
            this.txtCustID.TabIndex = 39;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(9, 48);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(331, 22);
            this.txtCustomer.TabIndex = 38;
            // 
            // txtAddress02
            // 
            this.txtAddress02.Location = new System.Drawing.Point(9, 151);
            this.txtAddress02.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress02.Name = "txtAddress02";
            this.txtAddress02.ReadOnly = true;
            this.txtAddress02.Size = new System.Drawing.Size(331, 22);
            this.txtAddress02.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Address2:";
            // 
            // txtAddress01
            // 
            this.txtAddress01.Location = new System.Drawing.Point(9, 98);
            this.txtAddress01.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress01.Name = "txtAddress01";
            this.txtAddress01.ReadOnly = true;
            this.txtAddress01.Size = new System.Drawing.Size(331, 22);
            this.txtAddress01.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Address1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Customer:";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(13, 41);
            this.lblStreetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(112, 20);
            this.lblStreetName.TabIndex = 33;
            this.lblStreetName.Text = "Street Names";
            // 
            // lblBuildingList
            // 
            this.lblBuildingList.AutoSize = true;
            this.lblBuildingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingList.Location = new System.Drawing.Point(400, 41);
            this.lblBuildingList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildingList.Name = "lblBuildingList";
            this.lblBuildingList.Size = new System.Drawing.Size(128, 20);
            this.lblBuildingList.TabIndex = 34;
            this.lblBuildingList.Text = "Street Buildings";
            // 
            // txtSuperPhone
            // 
            this.txtSuperPhone.Location = new System.Drawing.Point(245, 151);
            this.txtSuperPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuperPhone.Name = "txtSuperPhone";
            this.txtSuperPhone.Size = new System.Drawing.Size(171, 22);
            this.txtSuperPhone.TabIndex = 35;
            // 
            // txtSuperintendent
            // 
            this.txtSuperintendent.Location = new System.Drawing.Point(12, 151);
            this.txtSuperintendent.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuperintendent.Name = "txtSuperintendent";
            this.txtSuperintendent.Size = new System.Drawing.Size(212, 22);
            this.txtSuperintendent.TabIndex = 34;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(245, 103);
            this.txtUnits.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(171, 22);
            this.txtUnits.TabIndex = 33;
            // 
            // txtBuildingStreet
            // 
            this.txtBuildingStreet.Location = new System.Drawing.Point(129, 49);
            this.txtBuildingStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuildingStreet.Name = "txtBuildingStreet";
            this.txtBuildingStreet.Size = new System.Drawing.Size(287, 22);
            this.txtBuildingStreet.TabIndex = 32;
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(12, 49);
            this.txtBuildingNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(91, 22);
            this.txtBuildingNumber.TabIndex = 31;
            // 
            // lblLastModified
            // 
            this.lblLastModified.Location = new System.Drawing.Point(214, 180);
            this.lblLastModified.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(203, 20);
            this.lblLastModified.TabIndex = 29;
            this.lblLastModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateActive
            // 
            this.lblDateActive.Location = new System.Drawing.Point(8, 180);
            this.lblDateActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateActive.Name = "lblDateActive";
            this.lblDateActive.Size = new System.Drawing.Size(192, 20);
            this.lblDateActive.TabIndex = 28;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(241, 128);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(96, 20);
            this.Label9.TabIndex = 26;
            this.Label9.Text = "Super Phone";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(11, 128);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(139, 20);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Superintendent";
            // 
            // btnSaveNewProperty
            // 
            this.btnSaveNewProperty.Location = new System.Drawing.Point(777, 405);
            this.btnSaveNewProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveNewProperty.Name = "btnSaveNewProperty";
            this.btnSaveNewProperty.Size = new System.Drawing.Size(125, 28);
            this.btnSaveNewProperty.TabIndex = 36;
            this.btnSaveNewProperty.Text = "Save";
            this.btnSaveNewProperty.UseVisualStyleBackColor = true;
            this.btnSaveNewProperty.Click += new System.EventHandler(this.btnSaveNewProperty_Click);
            // 
            // dgvBuildings
            // 
            this.dgvBuildings.AllowUserToAddRows = false;
            this.dgvBuildings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuildings.Location = new System.Drawing.Point(292, 68);
            this.dgvBuildings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBuildings.MultiSelect = false;
            this.dgvBuildings.Name = "dgvBuildings";
            this.dgvBuildings.ReadOnly = true;
            this.dgvBuildings.RowTemplate.Height = 24;
            this.dgvBuildings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuildings.Size = new System.Drawing.Size(477, 418);
            this.dgvBuildings.TabIndex = 38;
            this.dgvBuildings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBuildings_MouseClick);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(241, 78);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 20);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Units";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(11, 80);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(96, 20);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "City";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(125, 30);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(203, 20);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Street Name";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(8, 30);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(96, 20);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Number";
            // 
            // btnCancelP
            // 
            this.btnCancelP.Location = new System.Drawing.Point(777, 451);
            this.btnCancelP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelP.Name = "btnCancelP";
            this.btnCancelP.Size = new System.Drawing.Size(125, 28);
            this.btnCancelP.TabIndex = 37;
            this.btnCancelP.Text = "Cancel";
            this.btnCancelP.UseVisualStyleBackColor = true;
            // 
            // tvStreetList
            // 
            this.tvStreetList.Location = new System.Drawing.Point(13, 68);
            this.tvStreetList.Margin = new System.Windows.Forms.Padding(4);
            this.tvStreetList.Name = "tvStreetList";
            this.tvStreetList.Size = new System.Drawing.Size(269, 419);
            this.tvStreetList.TabIndex = 32;
            this.tvStreetList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStreetList_AfterSelect);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cbbCity);
            this.GroupBox1.Controls.Add(this.txtSuperPhone);
            this.GroupBox1.Controls.Add(this.txtSuperintendent);
            this.GroupBox1.Controls.Add(this.txtUnits);
            this.GroupBox1.Controls.Add(this.txtBuildingStreet);
            this.GroupBox1.Controls.Add(this.txtBuildingNumber);
            this.GroupBox1.Controls.Add(this.lblLastModified);
            this.GroupBox1.Controls.Add(this.lblDateActive);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Enabled = false;
            this.GroupBox1.Location = new System.Drawing.Point(14, 495);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(425, 207);
            this.GroupBox1.TabIndex = 31;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Property Details";
            // 
            // cbbCity
            // 
            this.cbbCity.DataSource = this.cityBindingSource1;
            this.cbbCity.DisplayMember = "name";
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.Location = new System.Drawing.Point(12, 103);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(213, 24);
            this.cbbCity.TabIndex = 39;
            this.cbbCity.ValueMember = "cityId";
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.homeAppDBDataSet11;
            // 
            // homeAppDBDataSet11
            // 
            this.homeAppDBDataSet11.DataSetName = "HomeAppDBDataSet1";
            this.homeAppDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearchProperty
            // 
            this.txtSearchProperty.Location = new System.Drawing.Point(13, 13);
            this.txtSearchProperty.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProperty.Name = "txtSearchProperty";
            this.txtSearchProperty.Size = new System.Drawing.Size(269, 22);
            this.txtSearchProperty.TabIndex = 30;
            // 
            // btnManagePropertySearch
            // 
            this.btnManagePropertySearch.Location = new System.Drawing.Point(292, 13);
            this.btnManagePropertySearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagePropertySearch.Name = "btnManagePropertySearch";
            this.btnManagePropertySearch.Size = new System.Drawing.Size(100, 28);
            this.btnManagePropertySearch.TabIndex = 29;
            this.btnManagePropertySearch.Text = "Search";
            this.btnManagePropertySearch.UseVisualStyleBackColor = true;
            // 
            // btnManagePropertyExit
            // 
            this.btnManagePropertyExit.Location = new System.Drawing.Point(777, 709);
            this.btnManagePropertyExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagePropertyExit.Name = "btnManagePropertyExit";
            this.btnManagePropertyExit.Size = new System.Drawing.Size(125, 28);
            this.btnManagePropertyExit.TabIndex = 28;
            this.btnManagePropertyExit.Text = "Exit";
            this.btnManagePropertyExit.UseVisualStyleBackColor = true;
            this.btnManagePropertyExit.Click += new System.EventHandler(this.btnManagePropertyExit_Click_1);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(777, 151);
            this.btnDeleteProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(125, 28);
            this.btnDeleteProperty.TabIndex = 27;
            this.btnDeleteProperty.Text = "Delete property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(777, 110);
            this.btnUpdateProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(125, 28);
            this.btnUpdateProperty.TabIndex = 26;
            this.btnUpdateProperty.Text = "Update property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // btnNewProperty
            // 
            this.btnNewProperty.Location = new System.Drawing.Point(777, 68);
            this.btnNewProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProperty.Name = "btnNewProperty";
            this.btnNewProperty.Size = new System.Drawing.Size(125, 28);
            this.btnNewProperty.TabIndex = 25;
            this.btnNewProperty.Text = "Add property";
            this.btnNewProperty.UseVisualStyleBackColor = true;
            this.btnNewProperty.Click += new System.EventHandler(this.btnNewProperty_Click);
            // 
            // homeAppDBDataSet1
            // 
            this.homeAppDBDataSet1.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.homeAppDBDataSet1;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 750);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.lblBuildingList);
            this.Controls.Add(this.btnSaveNewProperty);
            this.Controls.Add(this.dgvBuildings);
            this.Controls.Add(this.btnCancelP);
            this.Controls.Add(this.tvStreetList);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtSearchProperty);
            this.Controls.Add(this.btnManagePropertySearch);
            this.Controls.Add(this.btnManagePropertyExit);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.btnNewProperty);
            this.Name = "frmManageProperty";
            this.Text = "frmManageProperty";
            this.Load += new System.EventHandler(this.frmManageProperty_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildings)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtAddress02;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress01;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblBuildingList;
        private System.Windows.Forms.TextBox txtSuperPhone;
        private System.Windows.Forms.TextBox txtSuperintendent;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtBuildingStreet;
        private System.Windows.Forms.TextBox txtBuildingNumber;
        internal System.Windows.Forms.Label lblLastModified;
        internal System.Windows.Forms.Label lblDateActive;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button btnSaveNewProperty;
        private System.Windows.Forms.DataGridView dgvBuildings;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button btnCancelP;
        private System.Windows.Forms.TreeView tvStreetList;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtSearchProperty;
        private System.Windows.Forms.Button btnManagePropertySearch;
        private System.Windows.Forms.Button btnManagePropertyExit;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnNewProperty;
        private System.Windows.Forms.ComboBox cbbCity;
        private System.Windows.Forms.TextBox txtCustID;
        private HomeAppDBDataSet homeAppDBDataSet1;
        private HomeAppDBDataSetTableAdapters.CityTableAdapter cityTableAdapter1;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private HomeAppDBDataSet1 homeAppDBDataSet11;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private HomeAppDBDataSet1TableAdapters.CityTableAdapter cityTableAdapter;
    }
}