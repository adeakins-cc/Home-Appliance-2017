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
            this.dateInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.lstOwner = new System.Windows.Forms.ListView();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lstProperty = new System.Windows.Forms.ListView();
            this.lblSerDate = new System.Windows.Forms.Label();
            this.dateServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.drpTechnician = new System.Windows.Forms.ComboBox();
            this.lblCustomerComplain = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.RichTextBox();
            this.lblServiceNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.dataListParts = new System.Windows.Forms.DataGridView();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.grpCharge = new System.Windows.Forms.GroupBox();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.chkHSTExempt = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceCalls = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaterials = new System.Windows.Forms.TextBox();
            this.lblmaterials = new System.Windows.Forms.Label();
            this.btnNewInvoiceExit = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataListParts)).BeginInit();
            this.grpCharge.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateInvoiceDate
            // 
            this.dateInvoiceDate.Location = new System.Drawing.Point(11, 28);
            this.dateInvoiceDate.Name = "dateInvoiceDate";
            this.dateInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateInvoiceDate.TabIndex = 0;
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
            this.lblOwner.Click += new System.EventHandler(this.label1_Click);
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
            this.dateServiceDate.Location = new System.Drawing.Point(11, 197);
            this.dateServiceDate.Name = "dateServiceDate";
            this.dateServiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateServiceDate.TabIndex = 6;
            this.dateServiceDate.ValueChanged += new System.EventHandler(this.dtServiceDate_ValueChanged);
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
            this.drpTechnician.FormattingEnabled = true;
            this.drpTechnician.Location = new System.Drawing.Point(218, 197);
            this.drpTechnician.Name = "drpTechnician";
            this.drpTechnician.Size = new System.Drawing.Size(121, 21);
            this.drpTechnician.TabIndex = 9;
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
            this.dataListParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partName,
            this.Price,
            this.quality});
            this.dataListParts.Location = new System.Drawing.Point(12, 359);
            this.dataListParts.Name = "dataListParts";
            this.dataListParts.Size = new System.Drawing.Size(406, 56);
            this.dataListParts.TabIndex = 18;
            this.dataListParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // partName
            // 
            this.partName.HeaderText = "Part Name";
            this.partName.Name = "partName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // quality
            // 
            this.quality.HeaderText = "Quality";
            this.quality.Name = "quality";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(16, 422);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 19;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(98, 422);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(78, 23);
            this.btnRemovePart.TabIndex = 20;
            this.btnRemovePart.Text = "Remove Part";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            // 
            // grpCharge
            // 
            this.grpCharge.Controls.Add(this.btnSession);
            this.grpCharge.Controls.Add(this.btnPost);
            this.grpCharge.Controls.Add(this.chkHSTExempt);
            this.grpCharge.Controls.Add(this.txtTotal);
            this.grpCharge.Controls.Add(this.label6);
            this.grpCharge.Controls.Add(this.txtHST);
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
            this.grpCharge.Size = new System.Drawing.Size(193, 234);
            this.grpCharge.TabIndex = 21;
            this.grpCharge.TabStop = false;
            this.grpCharge.Text = "Charge";
            // 
            // btnSession
            // 
            this.btnSession.Location = new System.Drawing.Point(31, 201);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(75, 23);
            this.btnSession.TabIndex = 17;
            this.btnSession.Text = "Session";
            this.btnSession.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(112, 201);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 16;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // chkHSTExempt
            // 
            this.chkHSTExempt.AutoSize = true;
            this.chkHSTExempt.Location = new System.Drawing.Point(87, 178);
            this.chkHSTExempt.Name = "chkHSTExempt";
            this.chkHSTExempt.Size = new System.Drawing.Size(86, 17);
            this.chkHSTExempt.TabIndex = 14;
            this.chkHSTExempt.Text = "HST Exempt";
            this.chkHSTExempt.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(87, 152);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // txtHST
            // 
            this.txtHST.Location = new System.Drawing.Point(87, 126);
            this.txtHST.Name = "txtHST";
            this.txtHST.Size = new System.Drawing.Size(100, 20);
            this.txtHST.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HST:";
            // 
            // txtSubtotal
            // 
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtServiceCalls
            // 
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
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtMaterials
            // 
            this.txtMaterials.Location = new System.Drawing.Point(87, 19);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.Size = new System.Drawing.Size(100, 20);
            this.txtMaterials.TabIndex = 1;
            this.txtMaterials.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // btnNewInvoiceExit
            // 
            this.btnNewInvoiceExit.Location = new System.Drawing.Point(536, 422);
            this.btnNewInvoiceExit.Name = "btnNewInvoiceExit";
            this.btnNewInvoiceExit.Size = new System.Drawing.Size(75, 23);
            this.btnNewInvoiceExit.TabIndex = 22;
            this.btnNewInvoiceExit.Text = "Exit";
            this.btnNewInvoiceExit.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomerProperty
            // 
            this.btnSearchCustomerProperty.Location = new System.Drawing.Point(343, 48);
            this.btnSearchCustomerProperty.Name = "btnSearchCustomerProperty";
            this.btnSearchCustomerProperty.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomerProperty.TabIndex = 23;
            this.btnSearchCustomerProperty.Text = "Search";
            this.btnSearchCustomerProperty.UseVisualStyleBackColor = true;
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
            this.txtSerialNumber.Location = new System.Drawing.Point(90, 91);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSerialNumber.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(90, 65);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(90, 39);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 5;
            // 
            // txtPONumber
            // 
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
            // frmNewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchCustomerProperty);
            this.Controls.Add(this.btnNewInvoiceExit);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataListParts)).EndInit();
            this.grpCharge.ResumeLayout(false);
            this.grpCharge.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.GroupBox grpCharge;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceCalls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaterials;
        private System.Windows.Forms.Label lblmaterials;
        private System.Windows.Forms.CheckBox chkHSTExempt;
        private System.Windows.Forms.Button btnSession;
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
    }
}