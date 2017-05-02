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
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.txtSearchProperty = new System.Windows.Forms.TextBox();
            this.btnManagePropertySearch = new System.Windows.Forms.Button();
            this.btnManagePropertyExit = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnNewProperty = new System.Windows.Forms.Button();
            this.cityTableAdapter1 = new HomeAppliance.HomeAppDBDataSetTableAdapters.CityTableAdapter();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CityTableAdapter();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildings)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
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
            this.GroupBox2.Location = new System.Drawing.Point(364, 402);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(265, 168);
            this.GroupBox2.TabIndex = 35;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Owner Details";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(200, 14);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(56, 20);
            this.txtCustID.TabIndex = 39;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(7, 39);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(249, 20);
            this.txtCustomer.TabIndex = 38;
            // 
            // txtAddress02
            // 
            this.txtAddress02.Location = new System.Drawing.Point(7, 123);
            this.txtAddress02.Name = "txtAddress02";
            this.txtAddress02.ReadOnly = true;
            this.txtAddress02.Size = new System.Drawing.Size(249, 20);
            this.txtAddress02.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Address2:";
            // 
            // txtAddress01
            // 
            this.txtAddress01.Location = new System.Drawing.Point(7, 80);
            this.txtAddress01.Name = "txtAddress01";
            this.txtAddress01.ReadOnly = true;
            this.txtAddress01.Size = new System.Drawing.Size(249, 20);
            this.txtAddress01.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Address1:";
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
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(10, 33);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(94, 17);
            this.lblStreetName.TabIndex = 33;
            this.lblStreetName.Text = "Street Names";
            // 
            // lblBuildingList
            // 
            this.lblBuildingList.AutoSize = true;
            this.lblBuildingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingList.Location = new System.Drawing.Point(300, 33);
            this.lblBuildingList.Name = "lblBuildingList";
            this.lblBuildingList.Size = new System.Drawing.Size(107, 17);
            this.lblBuildingList.TabIndex = 34;
            this.lblBuildingList.Text = "Street Buildings";
            // 
            // txtSuperPhone
            // 
            this.txtSuperPhone.Location = new System.Drawing.Point(184, 123);
            this.txtSuperPhone.Name = "txtSuperPhone";
            this.txtSuperPhone.Size = new System.Drawing.Size(129, 20);
            this.txtSuperPhone.TabIndex = 35;
            // 
            // txtSuperintendent
            // 
            this.txtSuperintendent.Location = new System.Drawing.Point(9, 123);
            this.txtSuperintendent.Name = "txtSuperintendent";
            this.txtSuperintendent.Size = new System.Drawing.Size(160, 20);
            this.txtSuperintendent.TabIndex = 34;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(184, 84);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(129, 20);
            this.txtUnits.TabIndex = 33;
            // 
            // txtBuildingStreet
            // 
            this.txtBuildingStreet.Location = new System.Drawing.Point(97, 40);
            this.txtBuildingStreet.Name = "txtBuildingStreet";
            this.txtBuildingStreet.Size = new System.Drawing.Size(216, 20);
            this.txtBuildingStreet.TabIndex = 32;
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(9, 40);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(69, 20);
            this.txtBuildingNumber.TabIndex = 31;
            // 
            // lblLastModified
            // 
            this.lblLastModified.Location = new System.Drawing.Point(160, 146);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(152, 16);
            this.lblLastModified.TabIndex = 29;
            this.lblLastModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateActive
            // 
            this.lblDateActive.Location = new System.Drawing.Point(6, 146);
            this.lblDateActive.Name = "lblDateActive";
            this.lblDateActive.Size = new System.Drawing.Size(144, 16);
            this.lblDateActive.TabIndex = 28;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(181, 104);
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
            // btnSaveNewProperty
            // 
            this.btnSaveNewProperty.Location = new System.Drawing.Point(583, 329);
            this.btnSaveNewProperty.Name = "btnSaveNewProperty";
            this.btnSaveNewProperty.Size = new System.Drawing.Size(94, 23);
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
            this.dgvBuildings.Location = new System.Drawing.Point(219, 55);
            this.dgvBuildings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBuildings.MultiSelect = false;
            this.dgvBuildings.Name = "dgvBuildings";
            this.dgvBuildings.ReadOnly = true;
            this.dgvBuildings.RowTemplate.Height = 24;
            this.dgvBuildings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuildings.Size = new System.Drawing.Size(358, 340);
            this.dgvBuildings.TabIndex = 38;
            this.dgvBuildings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBuildings_MouseClick);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(181, 63);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Units";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(8, 65);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 16);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "City";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(94, 24);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(152, 16);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Street Name";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(6, 24);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 16);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Number";
            // 
            // btnCancelP
            // 
            this.btnCancelP.Location = new System.Drawing.Point(583, 366);
            this.btnCancelP.Name = "btnCancelP";
            this.btnCancelP.Size = new System.Drawing.Size(94, 23);
            this.btnCancelP.TabIndex = 37;
            this.btnCancelP.Text = "Cancel";
            this.btnCancelP.UseVisualStyleBackColor = true;
            // 
            // tvStreetList
            // 
            this.tvStreetList.Location = new System.Drawing.Point(10, 55);
            this.tvStreetList.Name = "tvStreetList";
            this.tvStreetList.Size = new System.Drawing.Size(203, 341);
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
            this.GroupBox1.Location = new System.Drawing.Point(10, 402);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(319, 168);
            this.GroupBox1.TabIndex = 31;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Property Details";
            // 
            // cbbCity
            // 
            this.cbbCity.DataSource = this.cityBindingSource1;
            this.cbbCity.DisplayMember = "name";
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.Location = new System.Drawing.Point(9, 84);
            this.cbbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(161, 21);
            this.cbbCity.TabIndex = 39;
            this.cbbCity.ValueMember = "cityId";
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.homeAppDBDataSet;
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "homeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearchProperty
            // 
            this.txtSearchProperty.Location = new System.Drawing.Point(10, 11);
            this.txtSearchProperty.Name = "txtSearchProperty";
            this.txtSearchProperty.Size = new System.Drawing.Size(203, 20);
            this.txtSearchProperty.TabIndex = 30;
            // 
            // btnManagePropertySearch
            // 
            this.btnManagePropertySearch.Location = new System.Drawing.Point(219, 11);
            this.btnManagePropertySearch.Name = "btnManagePropertySearch";
            this.btnManagePropertySearch.Size = new System.Drawing.Size(75, 23);
            this.btnManagePropertySearch.TabIndex = 29;
            this.btnManagePropertySearch.Text = "Search";
            this.btnManagePropertySearch.UseVisualStyleBackColor = true;
            // 
            // btnManagePropertyExit
            // 
            this.btnManagePropertyExit.Location = new System.Drawing.Point(583, 576);
            this.btnManagePropertyExit.Name = "btnManagePropertyExit";
            this.btnManagePropertyExit.Size = new System.Drawing.Size(94, 23);
            this.btnManagePropertyExit.TabIndex = 28;
            this.btnManagePropertyExit.Text = "Exit";
            this.btnManagePropertyExit.UseVisualStyleBackColor = true;
            this.btnManagePropertyExit.Click += new System.EventHandler(this.btnManagePropertyExit_Click_1);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(583, 123);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteProperty.TabIndex = 27;
            this.btnDeleteProperty.Text = "Delete property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(583, 89);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateProperty.TabIndex = 26;
            this.btnUpdateProperty.Text = "Update property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // btnNewProperty
            // 
            this.btnNewProperty.Location = new System.Drawing.Point(583, 55);
            this.btnNewProperty.Name = "btnNewProperty";
            this.btnNewProperty.Size = new System.Drawing.Size(94, 23);
            this.btnNewProperty.TabIndex = 25;
            this.btnNewProperty.Text = "Add property";
            this.btnNewProperty.UseVisualStyleBackColor = true;
            this.btnNewProperty.Click += new System.EventHandler(this.btnNewProperty_Click);
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 609);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManageProperty";
            this.Text = "frmManageProperty";
            this.Load += new System.EventHandler(this.frmManageProperty_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuildings)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
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
        private HomeAppDBDataSetTableAdapters.CityTableAdapter cityTableAdapter1;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private HomeAppDBDataSet homeAppDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private HomeAppDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
    }
}