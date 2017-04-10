namespace HomeAppliance
{
    partial class frmNewInvoice
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
            this.dateInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.lstOwner = new System.Windows.Forms.ListView();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lstProperty = new System.Windows.Forms.ListView();
            this.lblSerDate = new System.Windows.Forms.Label();
            this.dateServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.drpTechnician = new System.Windows.Forms.ComboBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerComplain = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.RichTextBox();
            this.lblServiceNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.dataListParts = new System.Windows.Forms.DataGridView();
            this.partListIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.grpCharge = new System.Windows.Forms.GroupBox();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.chkRSTExempt = new System.Windows.Forms.CheckBox();
            this.btnNewInvoiceExit = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceCalls = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaterials = new System.Windows.Forms.TextBox();
            this.lblmaterials = new System.Windows.Forms.Label();
            this.btnSearchCustomerProperty = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.PartTableAdapter();
            this.partsListTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.PartsListTableAdapter();
            this.invoiceTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager();
            this.technicianTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.TechnicianTableAdapter();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblPropertyId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).BeginInit();
            this.grpCharge.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateInvoiceDate
            // 
            this.dateInvoiceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "invoiceDate", true));
            this.dateInvoiceDate.Location = new System.Drawing.Point(11, 28);
            this.dateInvoiceDate.Name = "dateInvoiceDate";
            this.dateInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateInvoiceDate.TabIndex = 0;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.homeAppDBDataSet;
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblInvDate
            // 
            this.lblInvDate.AutoSize = true;
            this.lblInvDate.Location = new System.Drawing.Point(12, 9);
            this.lblInvDate.Name = "lblInvDate";
            this.lblInvDate.Size = new System.Drawing.Size(71, 13);
            this.lblInvDate.TabIndex = 1;
            this.lblInvDate.Text = "Invoice Date:";
            // 
            // lstOwner
            // 
            this.lstOwner.Location = new System.Drawing.Point(12, 77);
            this.lstOwner.Name = "lstOwner";
            this.lstOwner.Size = new System.Drawing.Size(200, 97);
            this.lstOwner.TabIndex = 2;
            this.lstOwner.UseCompatibleStateImageBehavior = false;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(13, 55);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(72, 13);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "Customer Info";
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(215, 55);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(67, 13);
            this.lblProperty.TabIndex = 5;
            this.lblProperty.Text = "Property Info";
            // 
            // lstProperty
            // 
            this.lstProperty.Location = new System.Drawing.Point(218, 77);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(200, 97);
            this.lstProperty.TabIndex = 4;
            this.lstProperty.UseCompatibleStateImageBehavior = false;
            // 
            // lblSerDate
            // 
            this.lblSerDate.AutoSize = true;
            this.lblSerDate.Location = new System.Drawing.Point(8, 177);
            this.lblSerDate.Name = "lblSerDate";
            this.lblSerDate.Size = new System.Drawing.Size(72, 13);
            this.lblSerDate.TabIndex = 7;
            this.lblSerDate.Text = "Service Date:";
            // 
            // dateServiceDate
            // 
            this.dateServiceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "serviceDate", true));
            this.dateServiceDate.Location = new System.Drawing.Point(11, 197);
            this.dateServiceDate.Name = "dateServiceDate";
            this.dateServiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateServiceDate.TabIndex = 6;
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Location = new System.Drawing.Point(215, 177);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(63, 13);
            this.lblTechnician.TabIndex = 8;
            this.lblTechnician.Text = "Technician:";
            // 
            // drpTechnician
            // 
            this.drpTechnician.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "technicianId", true));
            this.drpTechnician.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "technicianId", true));
            this.drpTechnician.DataSource = this.technicianBindingSource;
            this.drpTechnician.DisplayMember = "name";
            this.drpTechnician.FormattingEnabled = true;
            this.drpTechnician.Location = new System.Drawing.Point(218, 197);
            this.drpTechnician.Name = "drpTechnician";
            this.drpTechnician.Size = new System.Drawing.Size(200, 21);
            this.drpTechnician.TabIndex = 9;
            this.drpTechnician.ValueMember = "technicianId";
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataMember = "Technician";
            this.technicianBindingSource.DataSource = this.homeAppDBDataSet;
            // 
            // lblCustomerComplain
            // 
            this.lblCustomerComplain.AutoSize = true;
            this.lblCustomerComplain.Location = new System.Drawing.Point(11, 224);
            this.lblCustomerComplain.Name = "lblCustomerComplain";
            this.lblCustomerComplain.Size = new System.Drawing.Size(103, 13);
            this.lblCustomerComplain.TabIndex = 13;
            this.lblCustomerComplain.Text = "Customer Complaint:";
            // 
            // txtComplaint
            // 
            this.txtComplaint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "complaints", true));
            this.txtComplaint.Location = new System.Drawing.Point(11, 240);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(198, 96);
            this.txtComplaint.TabIndex = 12;
            this.txtComplaint.Text = "";
            // 
            // lblServiceNotes
            // 
            this.lblServiceNotes.AutoSize = true;
            this.lblServiceNotes.Location = new System.Drawing.Point(215, 224);
            this.lblServiceNotes.Name = "lblServiceNotes";
            this.lblServiceNotes.Size = new System.Drawing.Size(77, 13);
            this.lblServiceNotes.TabIndex = 15;
            this.lblServiceNotes.Text = "Service Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "notes", true));
            this.txtNotes.Location = new System.Drawing.Point(218, 240);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 96);
            this.txtNotes.TabIndex = 14;
            this.txtNotes.Text = "";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(8, 343);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(48, 13);
            this.lblParts.TabIndex = 17;
            this.lblParts.Text = "Part List:";
            // 
            // dataListParts
            // 
            this.dataListParts.AutoGenerateColumns = false;
            this.dataListParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partListIdDataGridViewTextBoxColumn,
            this.invoiceIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.partIdDataGridViewTextBoxColumn,
            this.editPriceDataGridViewTextBoxColumn});
            this.dataListParts.DataSource = this.partsListBindingSource1;
            this.dataListParts.Location = new System.Drawing.Point(12, 359);
            this.dataListParts.Name = "dataListParts";
            this.dataListParts.Size = new System.Drawing.Size(406, 109);
            this.dataListParts.TabIndex = 18;
            // 
            // partListIdDataGridViewTextBoxColumn
            // 
            this.partListIdDataGridViewTextBoxColumn.DataPropertyName = "partListId";
            this.partListIdDataGridViewTextBoxColumn.HeaderText = "partListId";
            this.partListIdDataGridViewTextBoxColumn.Name = "partListIdDataGridViewTextBoxColumn";
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "invoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "invoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "partId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "partId";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            // 
            // editPriceDataGridViewTextBoxColumn
            // 
            this.editPriceDataGridViewTextBoxColumn.DataPropertyName = "editPrice";
            this.editPriceDataGridViewTextBoxColumn.HeaderText = "editPrice";
            this.editPriceDataGridViewTextBoxColumn.Name = "editPriceDataGridViewTextBoxColumn";
            // 
            // partsListBindingSource1
            // 
            this.partsListBindingSource1.DataMember = "FK_PartList_Invoice";
            this.partsListBindingSource1.DataSource = this.invoiceBindingSource;
            // 
            // partsListBindingSource
            // 
            this.partsListBindingSource.DataMember = "PartsList";
            this.partsListBindingSource.DataSource = this.homeAppDBDataSetBindingSource;
            // 
            // homeAppDBDataSetBindingSource
            // 
            this.homeAppDBDataSetBindingSource.DataSource = this.homeAppDBDataSet;
            this.homeAppDBDataSetBindingSource.Position = 0;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(11, 474);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 19;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(93, 474);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(78, 23);
            this.btnRemovePart.TabIndex = 20;
            this.btnRemovePart.Text = "Remove Part";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            // 
            // grpCharge
            // 
            this.grpCharge.Controls.Add(this.txtGST);
            this.grpCharge.Controls.Add(this.label5);
            this.grpCharge.Controls.Add(this.btnPost);
            this.grpCharge.Controls.Add(this.chkRSTExempt);
            this.grpCharge.Controls.Add(this.btnNewInvoiceExit);
            this.grpCharge.Controls.Add(this.txtTotal);
            this.grpCharge.Controls.Add(this.label6);
            this.grpCharge.Controls.Add(this.txtRST);
            this.grpCharge.Controls.Add(this.label4);
            this.grpCharge.Controls.Add(this.txtSubtotal);
            this.grpCharge.Controls.Add(this.label3);
            this.grpCharge.Controls.Add(this.txtServiceCalls);
            this.grpCharge.Controls.Add(this.label2);
            this.grpCharge.Controls.Add(this.txtLabour);
            this.grpCharge.Controls.Add(this.label1);
            this.grpCharge.Controls.Add(this.txtMaterials);
            this.grpCharge.Controls.Add(this.lblmaterials);
            this.grpCharge.Location = new System.Drawing.Point(424, 181);
            this.grpCharge.Name = "grpCharge";
            this.grpCharge.Size = new System.Drawing.Size(193, 287);
            this.grpCharge.TabIndex = 21;
            this.grpCharge.TabStop = false;
            this.grpCharge.Text = "Charge";
            // 
            // txtGST
            // 
            this.txtGST.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "GST", true));
            this.txtGST.Location = new System.Drawing.Point(87, 152);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(100, 20);
            this.txtGST.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "GST:";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(6, 258);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 16;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // chkRSTExempt
            // 
            this.chkRSTExempt.AutoSize = true;
            this.chkRSTExempt.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "PSTExempt", true));
            this.chkRSTExempt.Location = new System.Drawing.Point(87, 204);
            this.chkRSTExempt.Name = "chkRSTExempt";
            this.chkRSTExempt.Size = new System.Drawing.Size(86, 17);
            this.chkRSTExempt.TabIndex = 14;
            this.chkRSTExempt.Text = "RST Exempt";
            this.chkRSTExempt.UseVisualStyleBackColor = true;
            // 
            // btnNewInvoiceExit
            // 
            this.btnNewInvoiceExit.Location = new System.Drawing.Point(112, 258);
            this.btnNewInvoiceExit.Name = "btnNewInvoiceExit";
            this.btnNewInvoiceExit.Size = new System.Drawing.Size(75, 23);
            this.btnNewInvoiceExit.TabIndex = 22;
            this.btnNewInvoiceExit.Text = "Exit";
            this.btnNewInvoiceExit.UseVisualStyleBackColor = true;
            this.btnNewInvoiceExit.Click += new System.EventHandler(this.btnNewInvoiceExit_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "grossTotal", true));
            this.txtTotal.Location = new System.Drawing.Point(87, 178);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // txtRST
            // 
            this.txtRST.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PST", true));
            this.txtRST.Location = new System.Drawing.Point(87, 126);
            this.txtRST.Name = "txtRST";
            this.txtRST.Size = new System.Drawing.Size(100, 20);
            this.txtRST.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "RST:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "subTotal", true));
            this.txtSubtotal.Location = new System.Drawing.Point(87, 100);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal:";
            // 
            // txtServiceCalls
            // 
            this.txtServiceCalls.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "serviceCharge", true));
            this.txtServiceCalls.Location = new System.Drawing.Point(87, 74);
            this.txtServiceCalls.Name = "txtServiceCalls";
            this.txtServiceCalls.Size = new System.Drawing.Size(100, 20);
            this.txtServiceCalls.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Service Call:";
            // 
            // txtLabour
            // 
            this.txtLabour.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "labour", true));
            this.txtLabour.Location = new System.Drawing.Point(87, 48);
            this.txtLabour.Name = "txtLabour";
            this.txtLabour.Size = new System.Drawing.Size(100, 20);
            this.txtLabour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Labour:";
            // 
            // txtMaterials
            // 
            this.txtMaterials.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "partTotal", true));
            this.txtMaterials.Location = new System.Drawing.Point(87, 19);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.Size = new System.Drawing.Size(100, 20);
            this.txtMaterials.TabIndex = 1;
            // 
            // lblmaterials
            // 
            this.lblmaterials.AutoSize = true;
            this.lblmaterials.Location = new System.Drawing.Point(29, 22);
            this.lblmaterials.Name = "lblmaterials";
            this.lblmaterials.Size = new System.Drawing.Size(52, 13);
            this.lblmaterials.TabIndex = 0;
            this.lblmaterials.Text = "Materials:";
            // 
            // btnSearchCustomerProperty
            // 
            this.btnSearchCustomerProperty.Location = new System.Drawing.Point(343, 48);
            this.btnSearchCustomerProperty.Name = "btnSearchCustomerProperty";
            this.btnSearchCustomerProperty.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomerProperty.TabIndex = 23;
            this.btnSearchCustomerProperty.Text = "Search";
            this.btnSearchCustomerProperty.UseVisualStyleBackColor = true;
            this.btnSearchCustomerProperty.Click += new System.EventHandler(this.btnSearchCustomerProperty_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSerialNumber);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.txtPONumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(424, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 127);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "serialNumber", true));
            this.txtSerialNumber.Location = new System.Drawing.Point(90, 91);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSerialNumber.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "model", true));
            this.txtModel.Location = new System.Drawing.Point(90, 65);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            // 
            // txtMake
            // 
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "make", true));
            this.txtMake.Location = new System.Drawing.Point(90, 39);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 5;
            // 
            // txtPONumber
            // 
            this.txtPONumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "poNumber", true));
            this.txtPONumber.Location = new System.Drawing.Point(90, 13);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(100, 20);
            this.txtPONumber.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Model:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Serial Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Make:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "P.O. Number:";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.homeAppDBDataSetBindingSource;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // partsListTableAdapter
            // 
            this.partsListTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FinacialTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.PartsListTableAdapter = this.partsListTableAdapter;
            this.tableAdapterManager.PartTableAdapter = this.partTableAdapter;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.TaxesTableAdapter = null;
            this.tableAdapterManager.TechnicianTableAdapter = this.technicianTableAdapter;
            this.tableAdapterManager.UpdateOrder = HomeAppliance.HomeAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // technicianTableAdapter
            // 
            this.technicianTableAdapter.ClearBeforeFill = true;
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.AutoSize = true;
            this.lblInvoiceId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoiceId", true));
            this.lblInvoiceId.Location = new System.Drawing.Point(89, 12);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(51, 13);
            this.lblInvoiceId.TabIndex = 25;
            this.lblInvoiceId.Text = "InvoiceId";
            this.lblInvoiceId.Visible = false;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "customerId", true));
            this.lblCustomerId.Location = new System.Drawing.Point(146, 12);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(60, 13);
            this.lblCustomerId.TabIndex = 26;
            this.lblCustomerId.Text = "CustomerId";
            this.lblCustomerId.Visible = false;
            // 
            // lblPropertyId
            // 
            this.lblPropertyId.AutoSize = true;
            this.lblPropertyId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "propertyId", true));
            this.lblPropertyId.Location = new System.Drawing.Point(211, 12);
            this.lblPropertyId.Name = "lblPropertyId";
            this.lblPropertyId.Size = new System.Drawing.Size(52, 13);
            this.lblPropertyId.TabIndex = 27;
            this.lblPropertyId.Text = "Propertyd";
            this.lblPropertyId.Visible = false;
            // 
            // frmNewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 503);
            this.Controls.Add(this.lblPropertyId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblInvoiceId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchCustomerProperty);
            this.Controls.Add(this.grpCharge);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dataListParts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblServiceNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblCustomerComplain);
            this.Controls.Add(this.txtComplaint);
            this.Controls.Add(this.drpTechnician);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.lblSerDate);
            this.Controls.Add(this.dateServiceDate);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.lstProperty);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lstOwner);
            this.Controls.Add(this.lblInvDate);
            this.Controls.Add(this.dateInvoiceDate);
            this.Name = "frmNewInvoice";
            this.Text = "New Invoices";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).EndInit();
            this.grpCharge.ResumeLayout(false);
            this.grpCharge.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateInvoiceDate;
        private System.Windows.Forms.Label lblInvDate;
        private System.Windows.Forms.ListView lstOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.ListView lstProperty;
        private System.Windows.Forms.Label lblSerDate;
        private System.Windows.Forms.DateTimePicker dateServiceDate;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.ComboBox drpTechnician;
        private System.Windows.Forms.Label lblCustomerComplain;
        private System.Windows.Forms.RichTextBox txtComplaint;
        private System.Windows.Forms.Label lblServiceNotes;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.DataGridView dataListParts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.GroupBox grpCharge;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceCalls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaterials;
        private System.Windows.Forms.Label lblmaterials;
        private System.Windows.Forms.CheckBox chkRSTExempt;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnNewInvoiceExit;
        private System.Windows.Forms.Button btnSearchCustomerProperty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource homeAppDBDataSetBindingSource;
        private HomeAppDBDataSet homeAppDBDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private HomeAppDBDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.BindingSource partsListBindingSource;
        private HomeAppDBDataSetTableAdapters.PartsListTableAdapter partsListTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private HomeAppDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private HomeAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource partsListBindingSource1;
        private HomeAppDBDataSetTableAdapters.TechnicianTableAdapter technicianTableAdapter;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn partListIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblPropertyId;
    }
}