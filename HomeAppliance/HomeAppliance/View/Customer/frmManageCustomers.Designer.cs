namespace HomeAppliance
{
    partial class frmManageCustomer
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStreetNum02 = new System.Windows.Forms.TextBox();
            this.cobCityId02 = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPostalCode02 = new System.Windows.Forms.TextBox();
            this.txtUnitNum02 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStreetName02 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStreetNum01 = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSet1 = new HomeAppliance.HomeAppDBDataSet();
            this.cobCityId01 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPostalCode01 = new System.Windows.Forms.TextBox();
            this.txtUnitNum01 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStreetName01 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOtherNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBussinessNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cityTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CityTableAdapter();
            this.customerTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CustomerTableAdapter();
            this.tvCustomerList = new System.Windows.Forms.TreeView();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnSaveCust = new System.Windows.Forms.Button();
            this.btnCancelCust = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet1)).BeginInit();
            this.grpContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(910, 508);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(754, 508);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(133, 28);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(910, 467);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(133, 28);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "Update customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(754, 465);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(133, 28);
            this.btnNewCustomer.TabIndex = 5;
            this.btnNewCustomer.Text = "Add customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(344, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(16, 15);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(286, 22);
            this.txtSearchCustomer.TabIndex = 11;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.groupBox1);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.txtCompanyName);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.groupBox2);
            this.grpCustomer.Controls.Add(this.txtFirstName);
            this.grpCustomer.Controls.Add(this.label4);
            this.grpCustomer.Controls.Add(this.txtLastName);
            this.grpCustomer.Location = new System.Drawing.Point(452, 47);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustomer.Size = new System.Drawing.Size(555, 286);
            this.grpCustomer.TabIndex = 42;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Info:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStreetNum02);
            this.groupBox1.Controls.Add(this.cobCityId02);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPostalCode02);
            this.groupBox1.Controls.Add(this.txtUnitNum02);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtStreetName02);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(279, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(263, 188);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Street Number:";
            // 
            // txtStreetNum02
            // 
            this.txtStreetNum02.Location = new System.Drawing.Point(117, 55);
            this.txtStreetNum02.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetNum02.Name = "txtStreetNum02";
            this.txtStreetNum02.Size = new System.Drawing.Size(132, 22);
            this.txtStreetNum02.TabIndex = 41;
            // 
            // cobCityId02
            // 
            this.cobCityId02.DataSource = this.cityBindingSource;
            this.cobCityId02.DisplayMember = "name";
            this.cobCityId02.FormattingEnabled = true;
            this.cobCityId02.Location = new System.Drawing.Point(117, 118);
            this.cobCityId02.Margin = new System.Windows.Forms.Padding(4);
            this.cobCityId02.Name = "cobCityId02";
            this.cobCityId02.Size = new System.Drawing.Size(132, 24);
            this.cobCityId02.TabIndex = 39;
            this.cobCityId02.ValueMember = "cityId";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.homeAppDBDataSet;
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Unit Number:";
            // 
            // txtPostalCode02
            // 
            this.txtPostalCode02.Location = new System.Drawing.Point(117, 151);
            this.txtPostalCode02.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalCode02.Name = "txtPostalCode02";
            this.txtPostalCode02.Size = new System.Drawing.Size(132, 22);
            this.txtPostalCode02.TabIndex = 38;
            // 
            // txtUnitNum02
            // 
            this.txtUnitNum02.Location = new System.Drawing.Point(117, 23);
            this.txtUnitNum02.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitNum02.Name = "txtUnitNum02";
            this.txtUnitNum02.Size = new System.Drawing.Size(132, 22);
            this.txtUnitNum02.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Postal Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Street Name:";
            // 
            // txtStreetName02
            // 
            this.txtStreetName02.Location = new System.Drawing.Point(117, 87);
            this.txtStreetName02.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetName02.Name = "txtStreetName02";
            this.txtStreetName02.Size = new System.Drawing.Size(132, 22);
            this.txtStreetName02.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(73, 123);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(125, 55);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(403, 22);
            this.txtCompanyName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtStreetNum01);
            this.groupBox2.Controls.Add(this.cobCityId01);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtPostalCode01);
            this.groupBox2.Controls.Add(this.txtUnitNum01);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtStreetName01);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(8, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(263, 188);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Street Number:";
            // 
            // txtStreetNum01
            // 
            this.txtStreetNum01.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "streetNumber01", true));
            this.txtStreetNum01.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "streetNumber01", true));
            this.txtStreetNum01.Location = new System.Drawing.Point(117, 55);
            this.txtStreetNum01.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetNum01.Name = "txtStreetNum01";
            this.txtStreetNum01.Size = new System.Drawing.Size(132, 22);
            this.txtStreetNum01.TabIndex = 41;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.homeAppDBDataSet1;
            // 
            // homeAppDBDataSet1
            // 
            this.homeAppDBDataSet1.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobCityId01
            // 
            this.cobCityId01.DataSource = this.cityBindingSource;
            this.cobCityId01.DisplayMember = "name";
            this.cobCityId01.FormattingEnabled = true;
            this.cobCityId01.Location = new System.Drawing.Point(117, 118);
            this.cobCityId01.Margin = new System.Windows.Forms.Padding(4);
            this.cobCityId01.Name = "cobCityId01";
            this.cobCityId01.Size = new System.Drawing.Size(132, 24);
            this.cobCityId01.TabIndex = 39;
            this.cobCityId01.ValueMember = "cityId";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Unit Number:";
            // 
            // txtPostalCode01
            // 
            this.txtPostalCode01.Location = new System.Drawing.Point(117, 151);
            this.txtPostalCode01.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalCode01.Name = "txtPostalCode01";
            this.txtPostalCode01.Size = new System.Drawing.Size(132, 22);
            this.txtPostalCode01.TabIndex = 38;
            // 
            // txtUnitNum01
            // 
            this.txtUnitNum01.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "unitNumber01", true));
            this.txtUnitNum01.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "unitNumber01", true));
            this.txtUnitNum01.Location = new System.Drawing.Point(117, 23);
            this.txtUnitNum01.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitNum01.Name = "txtUnitNum01";
            this.txtUnitNum01.Size = new System.Drawing.Size(132, 22);
            this.txtUnitNum01.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 155);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Postal Code:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 91);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "Street Name:";
            // 
            // txtStreetName01
            // 
            this.txtStreetName01.Location = new System.Drawing.Point(117, 87);
            this.txtStreetName01.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetName01.Name = "txtStreetName01";
            this.txtStreetName01.Size = new System.Drawing.Size(132, 22);
            this.txtStreetName01.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, 123);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "City:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 23);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(396, 23);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtFax);
            this.grpContact.Controls.Add(this.label15);
            this.grpContact.Controls.Add(this.txtOtherNumber);
            this.grpContact.Controls.Add(this.label14);
            this.grpContact.Controls.Add(this.txtBussinessNumber);
            this.grpContact.Controls.Add(this.label13);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.label9);
            this.grpContact.Controls.Add(this.txtMobile);
            this.grpContact.Controls.Add(this.label8);
            this.grpContact.Controls.Add(this.txtPhone);
            this.grpContact.Controls.Add(this.label7);
            this.grpContact.Controls.Add(this.txtContactName);
            this.grpContact.Controls.Add(this.label6);
            this.grpContact.Location = new System.Drawing.Point(452, 340);
            this.grpContact.Margin = new System.Windows.Forms.Padding(4);
            this.grpContact.Name = "grpContact";
            this.grpContact.Padding = new System.Windows.Forms.Padding(4);
            this.grpContact.Size = new System.Drawing.Size(292, 255);
            this.grpContact.TabIndex = 39;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact Info";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(92, 185);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(177, 22);
            this.txtFax.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 188);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Fax:";
            // 
            // txtOtherNumber
            // 
            this.txtOtherNumber.Location = new System.Drawing.Point(92, 153);
            this.txtOtherNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherNumber.Name = "txtOtherNumber";
            this.txtOtherNumber.Size = new System.Drawing.Size(177, 22);
            this.txtOtherNumber.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 156);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Other:";
            // 
            // txtBussinessNumber
            // 
            this.txtBussinessNumber.Location = new System.Drawing.Point(92, 121);
            this.txtBussinessNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBussinessNumber.Name = "txtBussinessNumber";
            this.txtBussinessNumber.Size = new System.Drawing.Size(177, 22);
            this.txtBussinessNumber.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 124);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Bussiness:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 217);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(92, 89);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(177, 22);
            this.txtMobile.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mobile:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(92, 57);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 22);
            this.txtPhone.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(92, 25);
            this.txtContactName.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(177, 22);
            this.txtContactName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name:";
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tvCustomerList
            // 
            this.tvCustomerList.Location = new System.Drawing.Point(16, 47);
            this.tvCustomerList.Margin = new System.Windows.Forms.Padding(4);
            this.tvCustomerList.Name = "tvCustomerList";
            this.tvCustomerList.Size = new System.Drawing.Size(428, 541);
            this.tvCustomerList.TabIndex = 43;
            this.tvCustomerList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(927, 26);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerID.TabIndex = 43;
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.Location = new System.Drawing.Point(763, 357);
            this.btnSaveCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Size = new System.Drawing.Size(118, 28);
            this.btnSaveCust.TabIndex = 44;
            this.btnSaveCust.Text = "Save";
            this.btnSaveCust.UseVisualStyleBackColor = true;
            this.btnSaveCust.Click += new System.EventHandler(this.btnSaveCust_Click);
            // 
            // btnCancelCust
            // 
            this.btnCancelCust.Location = new System.Drawing.Point(908, 357);
            this.btnCancelCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelCust.Name = "btnCancelCust";
            this.btnCancelCust.Size = new System.Drawing.Size(118, 28);
            this.btnCancelCust.TabIndex = 45;
            this.btnCancelCust.Text = "Cancel";
            this.btnCancelCust.UseVisualStyleBackColor = true;
            // 
            // frmManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 603);
            this.Controls.Add(this.btnCancelCust);
            this.Controls.Add(this.btnSaveCust);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.tvCustomerList);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageCustomer";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.frmManageCustomer_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet1)).EndInit();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOtherNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBussinessNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cobCityId01;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPostalCode01;
        private System.Windows.Forms.TextBox txtUnitNum01;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStreetName01;
        private System.Windows.Forms.Label label20;
        private HomeAppDBDataSet homeAppDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private HomeAppDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStreetNum01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStreetNum02;
        private System.Windows.Forms.ComboBox cobCityId02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostalCode02;
        private System.Windows.Forms.TextBox txtUnitNum02;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStreetName02;
        private System.Windows.Forms.Label label19;
        private HomeAppDBDataSet homeAppDBDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private HomeAppDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TreeView tvCustomerList;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnSaveCust;
        private System.Windows.Forms.Button btnCancelCust;
    }
}