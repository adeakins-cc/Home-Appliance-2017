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
            this.tvCustomerList = new System.Windows.Forms.TreeView();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnSaveCust = new System.Windows.Forms.Button();
            this.btnCancelCust = new System.Windows.Forms.Button();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.CustomerTableAdapter();
            this.grpCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(682, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(566, 413);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(682, 379);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "Update customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(566, 378);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(100, 23);
            this.btnNewCustomer.TabIndex = 5;
            this.btnNewCustomer.Text = "Add customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(258, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(12, 12);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(216, 20);
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
            this.grpCustomer.Location = new System.Drawing.Point(339, 38);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(416, 232);
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
            this.groupBox1.Location = new System.Drawing.Point(209, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 153);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Street Number:";
            // 
            // txtStreetNum02
            // 
            this.txtStreetNum02.Location = new System.Drawing.Point(88, 45);
            this.txtStreetNum02.Name = "txtStreetNum02";
            this.txtStreetNum02.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNum02.TabIndex = 41;
            // 
            // cobCityId02
            // 
            this.cobCityId02.DataSource = this.cityBindingSource1;
            this.cobCityId02.DisplayMember = "name";
            this.cobCityId02.FormattingEnabled = true;
            this.cobCityId02.Location = new System.Drawing.Point(88, 96);
            this.cobCityId02.Name = "cobCityId02";
            this.cobCityId02.Size = new System.Drawing.Size(100, 21);
            this.cobCityId02.TabIndex = 39;
            this.cobCityId02.ValueMember = "cityId";
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Unit Number:";
            // 
            // txtPostalCode02
            // 
            this.txtPostalCode02.Location = new System.Drawing.Point(88, 123);
            this.txtPostalCode02.Name = "txtPostalCode02";
            this.txtPostalCode02.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode02.TabIndex = 38;
            // 
            // txtUnitNum02
            // 
            this.txtUnitNum02.Location = new System.Drawing.Point(88, 19);
            this.txtUnitNum02.Name = "txtUnitNum02";
            this.txtUnitNum02.Size = new System.Drawing.Size(100, 20);
            this.txtUnitNum02.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Postal Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Street Name:";
            // 
            // txtStreetName02
            // 
            this.txtStreetName02.Location = new System.Drawing.Point(88, 71);
            this.txtStreetName02.Name = "txtStreetName02";
            this.txtStreetName02.Size = new System.Drawing.Size(100, 20);
            this.txtStreetName02.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(94, 45);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(303, 20);
            this.txtCompanyName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 153);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Street Number:";
            // 
            // txtStreetNum01
            // 
            this.txtStreetNum01.Location = new System.Drawing.Point(88, 45);
            this.txtStreetNum01.Name = "txtStreetNum01";
            this.txtStreetNum01.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNum01.TabIndex = 41;
            // 
            // cobCityId01
            // 
            this.cobCityId01.DataSource = this.cityBindingSource;
            this.cobCityId01.DisplayMember = "name";
            this.cobCityId01.FormattingEnabled = true;
            this.cobCityId01.Location = new System.Drawing.Point(88, 96);
            this.cobCityId01.Name = "cobCityId01";
            this.cobCityId01.Size = new System.Drawing.Size(100, 21);
            this.cobCityId01.TabIndex = 39;
            this.cobCityId01.ValueMember = "cityId";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Unit Number:";
            // 
            // txtPostalCode01
            // 
            this.txtPostalCode01.Location = new System.Drawing.Point(88, 123);
            this.txtPostalCode01.Name = "txtPostalCode01";
            this.txtPostalCode01.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode01.TabIndex = 38;
            // 
            // txtUnitNum01
            // 
            this.txtUnitNum01.Location = new System.Drawing.Point(88, 19);
            this.txtUnitNum01.Name = "txtUnitNum01";
            this.txtUnitNum01.Size = new System.Drawing.Size(100, 20);
            this.txtUnitNum01.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Postal Code:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Street Name:";
            // 
            // txtStreetName01
            // 
            this.txtStreetName01.Location = new System.Drawing.Point(88, 71);
            this.txtStreetName01.Name = "txtStreetName01";
            this.txtStreetName01.Size = new System.Drawing.Size(100, 20);
            this.txtStreetName01.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "City:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(94, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(297, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
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
            this.grpContact.Location = new System.Drawing.Point(339, 276);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(219, 207);
            this.grpContact.TabIndex = 39;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact Info";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(69, 150);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(134, 20);
            this.txtFax.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Fax:";
            // 
            // txtOtherNumber
            // 
            this.txtOtherNumber.Location = new System.Drawing.Point(69, 124);
            this.txtOtherNumber.Name = "txtOtherNumber";
            this.txtOtherNumber.Size = new System.Drawing.Size(134, 20);
            this.txtOtherNumber.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Other:";
            // 
            // txtBussinessNumber
            // 
            this.txtBussinessNumber.Location = new System.Drawing.Point(69, 98);
            this.txtBussinessNumber.Name = "txtBussinessNumber";
            this.txtBussinessNumber.Size = new System.Drawing.Size(134, 20);
            this.txtBussinessNumber.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Bussiness:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(69, 72);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(134, 20);
            this.txtMobile.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mobile:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(69, 46);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(69, 20);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(134, 20);
            this.txtContactName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name:";
            // 
            // tvCustomerList
            // 
            this.tvCustomerList.Location = new System.Drawing.Point(12, 38);
            this.tvCustomerList.Name = "tvCustomerList";
            this.tvCustomerList.Size = new System.Drawing.Size(322, 440);
            this.tvCustomerList.TabIndex = 43;
            this.tvCustomerList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(695, 21);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 17);
            this.lblCustomerID.TabIndex = 43;
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.Location = new System.Drawing.Point(572, 290);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Size = new System.Drawing.Size(88, 23);
            this.btnSaveCust.TabIndex = 44;
            this.btnSaveCust.Text = "Save";
            this.btnSaveCust.UseVisualStyleBackColor = true;
            this.btnSaveCust.Click += new System.EventHandler(this.btnSaveCust_Click);
            // 
            // btnCancelCust
            // 
            this.btnCancelCust.Location = new System.Drawing.Point(681, 290);
            this.btnCancelCust.Name = "btnCancelCust";
            this.btnCancelCust.Size = new System.Drawing.Size(88, 23);
            this.btnCancelCust.TabIndex = 45;
            this.btnCancelCust.Text = "Cancel";
            this.btnCancelCust.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.FinacialTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.PartsListTableAdapter = null;
            this.tableAdapterManager.PartTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.TaxesTableAdapter = null;
            this.tableAdapterManager.TechnicianTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.homeAppDBDataSet;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.homeAppDBDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 503);
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
            this.Name = "frmManageCustomer";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.frmManageCustomer_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
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
        private System.Windows.Forms.TreeView tvCustomerList;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnSaveCust;
        private System.Windows.Forms.Button btnCancelCust;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private HomeAppDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private HomeAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private HomeAppDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}