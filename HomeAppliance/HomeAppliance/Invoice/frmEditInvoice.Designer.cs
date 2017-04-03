﻿namespace HomeAppliance.Invoice
{
    partial class frmEditInvoice
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
            this.btnSearchCustomerProperty = new System.Windows.Forms.Button();
            this.btnEditInvoiceExit = new System.Windows.Forms.Button();
            this.grpCharge = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkPSTExempt = new System.Windows.Forms.CheckBox();
            this.chkHSTExempt = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPST = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dataListParts = new System.Windows.Forms.DataGridView();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblServiceNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblCustomerComplain = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.RichTextBox();
            this.drpTechnician = new System.Windows.Forms.ComboBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.lblSerDate = new System.Windows.Forms.Label();
            this.dateServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lstProperty = new System.Windows.Forms.ListView();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lstOwner = new System.Windows.Forms.ListView();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.dateInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.grpCharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCustomerProperty
            // 
            this.btnSearchCustomerProperty.Location = new System.Drawing.Point(343, 48);
            this.btnSearchCustomerProperty.Name = "btnSearchCustomerProperty";
            this.btnSearchCustomerProperty.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomerProperty.TabIndex = 44;
            this.btnSearchCustomerProperty.Text = "Search";
            this.btnSearchCustomerProperty.UseVisualStyleBackColor = true;
            // 
            // btnEditInvoiceExit
            // 
            this.btnEditInvoiceExit.Location = new System.Drawing.Point(527, 421);
            this.btnEditInvoiceExit.Name = "btnEditInvoiceExit";
            this.btnEditInvoiceExit.Size = new System.Drawing.Size(75, 23);
            this.btnEditInvoiceExit.TabIndex = 43;
            this.btnEditInvoiceExit.Text = "Exit";
            this.btnEditInvoiceExit.UseVisualStyleBackColor = true;
            // 
            // grpCharge
            // 
            this.grpCharge.Controls.Add(this.btnUpdate);
            this.grpCharge.Controls.Add(this.chkPSTExempt);
            this.grpCharge.Controls.Add(this.chkHSTExempt);
            this.grpCharge.Controls.Add(this.txtTotal);
            this.grpCharge.Controls.Add(this.label6);
            this.grpCharge.Controls.Add(this.txtPST);
            this.grpCharge.Controls.Add(this.label5);
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
            this.grpCharge.Location = new System.Drawing.Point(424, 28);
            this.grpCharge.Name = "grpCharge";
            this.grpCharge.Size = new System.Drawing.Size(178, 387);
            this.grpCharge.TabIndex = 42;
            this.grpCharge.TabStop = false;
            this.grpCharge.Text = "Charge";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(97, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // chkPSTExempt
            // 
            this.chkPSTExempt.AutoSize = true;
            this.chkPSTExempt.Location = new System.Drawing.Point(92, 222);
            this.chkPSTExempt.Name = "chkPSTExempt";
            this.chkPSTExempt.Size = new System.Drawing.Size(85, 17);
            this.chkPSTExempt.TabIndex = 15;
            this.chkPSTExempt.Text = "PST Exempt";
            this.chkPSTExempt.UseVisualStyleBackColor = true;
            // 
            // chkHSTExempt
            // 
            this.chkHSTExempt.AutoSize = true;
            this.chkHSTExempt.Location = new System.Drawing.Point(92, 198);
            this.chkHSTExempt.Name = "chkHSTExempt";
            this.chkHSTExempt.Size = new System.Drawing.Size(86, 17);
            this.chkHSTExempt.TabIndex = 14;
            this.chkHSTExempt.Text = "HST Exempt";
            this.chkHSTExempt.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(75, 172);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // txtPST
            // 
            this.txtPST.Location = new System.Drawing.Point(75, 146);
            this.txtPST.Name = "txtPST";
            this.txtPST.Size = new System.Drawing.Size(100, 20);
            this.txtPST.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PST:";
            // 
            // txtHST
            // 
            this.txtHST.Location = new System.Drawing.Point(75, 120);
            this.txtHST.Name = "txtHST";
            this.txtHST.Size = new System.Drawing.Size(100, 20);
            this.txtHST.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HST:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(75, 94);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal:";
            // 
            // txtServiceCalls
            // 
            this.txtServiceCalls.Location = new System.Drawing.Point(75, 68);
            this.txtServiceCalls.Name = "txtServiceCalls";
            this.txtServiceCalls.Size = new System.Drawing.Size(100, 20);
            this.txtServiceCalls.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Service Call:";
            // 
            // txtLabour
            // 
            this.txtLabour.Location = new System.Drawing.Point(75, 42);
            this.txtLabour.Name = "txtLabour";
            this.txtLabour.Size = new System.Drawing.Size(100, 20);
            this.txtLabour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Labour:";
            // 
            // txtMaterials
            // 
            this.txtMaterials.Location = new System.Drawing.Point(75, 13);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.Size = new System.Drawing.Size(100, 20);
            this.txtMaterials.TabIndex = 1;
            // 
            // lblmaterials
            // 
            this.lblmaterials.AutoSize = true;
            this.lblmaterials.Location = new System.Drawing.Point(17, 16);
            this.lblmaterials.Name = "lblmaterials";
            this.lblmaterials.Size = new System.Drawing.Size(52, 13);
            this.lblmaterials.TabIndex = 0;
            this.lblmaterials.Text = "Materials:";
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(98, 422);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(78, 23);
            this.btnRemovePart.TabIndex = 41;
            this.btnRemovePart.Text = "Remove Part";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(16, 422);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 40;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
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
            this.dataListParts.TabIndex = 39;
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
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(8, 343);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(48, 13);
            this.lblParts.TabIndex = 38;
            this.lblParts.Text = "Part List:";
            // 
            // lblServiceNotes
            // 
            this.lblServiceNotes.AutoSize = true;
            this.lblServiceNotes.Location = new System.Drawing.Point(215, 224);
            this.lblServiceNotes.Name = "lblServiceNotes";
            this.lblServiceNotes.Size = new System.Drawing.Size(77, 13);
            this.lblServiceNotes.TabIndex = 37;
            this.lblServiceNotes.Text = "Service Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(218, 240);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 96);
            this.txtNotes.TabIndex = 36;
            this.txtNotes.Text = "";
            // 
            // lblCustomerComplain
            // 
            this.lblCustomerComplain.AutoSize = true;
            this.lblCustomerComplain.Location = new System.Drawing.Point(11, 224);
            this.lblCustomerComplain.Name = "lblCustomerComplain";
            this.lblCustomerComplain.Size = new System.Drawing.Size(103, 13);
            this.lblCustomerComplain.TabIndex = 35;
            this.lblCustomerComplain.Text = "Customer Complaint:";
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(11, 240);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(198, 96);
            this.txtComplaint.TabIndex = 34;
            this.txtComplaint.Text = "";
            // 
            // drpTechnician
            // 
            this.drpTechnician.FormattingEnabled = true;
            this.drpTechnician.Location = new System.Drawing.Point(218, 197);
            this.drpTechnician.Name = "drpTechnician";
            this.drpTechnician.Size = new System.Drawing.Size(121, 21);
            this.drpTechnician.TabIndex = 33;
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Location = new System.Drawing.Point(215, 177);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(63, 13);
            this.lblTechnician.TabIndex = 32;
            this.lblTechnician.Text = "Technician:";
            // 
            // lblSerDate
            // 
            this.lblSerDate.AutoSize = true;
            this.lblSerDate.Location = new System.Drawing.Point(8, 177);
            this.lblSerDate.Name = "lblSerDate";
            this.lblSerDate.Size = new System.Drawing.Size(72, 13);
            this.lblSerDate.TabIndex = 31;
            this.lblSerDate.Text = "Service Date:";
            // 
            // dateServiceDate
            // 
            this.dateServiceDate.Location = new System.Drawing.Point(11, 197);
            this.dateServiceDate.Name = "dateServiceDate";
            this.dateServiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateServiceDate.TabIndex = 30;
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(215, 55);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(67, 13);
            this.lblProperty.TabIndex = 29;
            this.lblProperty.Text = "Property Info";
            // 
            // lstProperty
            // 
            this.lstProperty.Location = new System.Drawing.Point(218, 77);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(200, 97);
            this.lstProperty.TabIndex = 28;
            this.lstProperty.UseCompatibleStateImageBehavior = false;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(13, 55);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(72, 13);
            this.lblOwner.TabIndex = 27;
            this.lblOwner.Text = "Customer Info";
            // 
            // lstOwner
            // 
            this.lstOwner.Location = new System.Drawing.Point(12, 77);
            this.lstOwner.Name = "lstOwner";
            this.lstOwner.Size = new System.Drawing.Size(200, 97);
            this.lstOwner.TabIndex = 26;
            this.lstOwner.UseCompatibleStateImageBehavior = false;
            // 
            // lblInvDate
            // 
            this.lblInvDate.AutoSize = true;
            this.lblInvDate.Location = new System.Drawing.Point(12, 9);
            this.lblInvDate.Name = "lblInvDate";
            this.lblInvDate.Size = new System.Drawing.Size(71, 13);
            this.lblInvDate.TabIndex = 25;
            this.lblInvDate.Text = "Invoice Date:";
            // 
            // dateInvoiceDate
            // 
            this.dateInvoiceDate.Location = new System.Drawing.Point(11, 28);
            this.dateInvoiceDate.Name = "dateInvoiceDate";
            this.dateInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateInvoiceDate.TabIndex = 24;
            // 
            // frmEditInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 458);
            this.Controls.Add(this.btnSearchCustomerProperty);
            this.Controls.Add(this.btnEditInvoiceExit);
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
            this.Name = "frmEditInvoice";
            this.Text = "Edit Invoice";
            this.grpCharge.ResumeLayout(false);
            this.grpCharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCustomerProperty;
        private System.Windows.Forms.Button btnEditInvoiceExit;
        private System.Windows.Forms.GroupBox grpCharge;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkPSTExempt;
        private System.Windows.Forms.CheckBox chkHSTExempt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPST;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.DataGridView dataListParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblServiceNotes;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblCustomerComplain;
        private System.Windows.Forms.RichTextBox txtComplaint;
        private System.Windows.Forms.ComboBox drpTechnician;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.Label lblSerDate;
        private System.Windows.Forms.DateTimePicker dateServiceDate;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.ListView lstProperty;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ListView lstOwner;
        private System.Windows.Forms.Label lblInvDate;
        private System.Windows.Forms.DateTimePicker dateInvoiceDate;
    }
}