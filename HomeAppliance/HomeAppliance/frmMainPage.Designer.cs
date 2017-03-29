namespace HomeAppliance
{
    partial class frmMain
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnDisplayInvoice = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.btnManageProperty = new System.Windows.Forms.Button();
            this.btnManageTechnician = new System.Windows.Forms.Button();
            this.btnManageParts = new System.Windows.Forms.Button();
            this.grpManagement = new System.Windows.Forms.GroupBox();
            this.btnPrintReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(18, 408);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(352, 48);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset DB Connection";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewInvoice.Location = new System.Drawing.Point(18, 17);
            this.btnNewInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(159, 115);
            this.btnNewInvoice.TabIndex = 1;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            // 
            // btnDisplayInvoice
            // 
            this.btnDisplayInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayInvoice.Location = new System.Drawing.Point(186, 17);
            this.btnDisplayInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayInvoice.Name = "btnDisplayInvoice";
            this.btnDisplayInvoice.Size = new System.Drawing.Size(159, 115);
            this.btnDisplayInvoice.TabIndex = 2;
            this.btnDisplayInvoice.Text = "Display Invoices";
            this.btnDisplayInvoice.UseVisualStyleBackColor = true;
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(9, 43);
            this.btnManageCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(192, 83);
            this.btnManageCustomer.TabIndex = 3;
            this.btnManageCustomer.Text = "Manage Customers";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            // 
            // btnManageProperty
            // 
            this.btnManageProperty.Location = new System.Drawing.Point(250, 43);
            this.btnManageProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageProperty.Name = "btnManageProperty";
            this.btnManageProperty.Size = new System.Drawing.Size(208, 83);
            this.btnManageProperty.TabIndex = 4;
            this.btnManageProperty.Text = "Manage Property";
            this.btnManageProperty.UseVisualStyleBackColor = true;
            // 
            // btnManageTechnician
            // 
            this.btnManageTechnician.Location = new System.Drawing.Point(250, 162);
            this.btnManageTechnician.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageTechnician.Name = "btnManageTechnician";
            this.btnManageTechnician.Size = new System.Drawing.Size(208, 83);
            this.btnManageTechnician.TabIndex = 5;
            this.btnManageTechnician.Text = "Manage Technicians";
            this.btnManageTechnician.UseVisualStyleBackColor = true;
            // 
            // btnManageParts
            // 
            this.btnManageParts.Location = new System.Drawing.Point(9, 162);
            this.btnManageParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageParts.Name = "btnManageParts";
            this.btnManageParts.Size = new System.Drawing.Size(192, 83);
            this.btnManageParts.TabIndex = 6;
            this.btnManageParts.Text = "Manage Parts";
            this.btnManageParts.UseVisualStyleBackColor = true;
            // 
            // grpManagement
            // 
            this.grpManagement.Controls.Add(this.btnManageCustomer);
            this.grpManagement.Controls.Add(this.btnManageProperty);
            this.grpManagement.Controls.Add(this.btnManageParts);
            this.grpManagement.Controls.Add(this.btnManageTechnician);
            this.grpManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManagement.Location = new System.Drawing.Point(18, 140);
            this.grpManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpManagement.Name = "grpManagement";
            this.grpManagement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpManagement.Size = new System.Drawing.Size(495, 260);
            this.grpManagement.TabIndex = 7;
            this.grpManagement.TabStop = false;
            this.grpManagement.Text = "Management";
            // 
            // btnPrintReports
            // 
            this.btnPrintReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReports.Location = new System.Drawing.Point(354, 17);
            this.btnPrintReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintReports.Name = "btnPrintReports";
            this.btnPrintReports.Size = new System.Drawing.Size(159, 115);
            this.btnPrintReports.TabIndex = 8;
            this.btnPrintReports.Text = "Print Reports";
            this.btnPrintReports.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(400, 408);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 48);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 472);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintReports);
            this.Controls.Add(this.grpManagement);
            this.Controls.Add(this.btnDisplayInvoice);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Main Page";
            this.grpManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnDisplayInvoice;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnManageProperty;
        private System.Windows.Forms.Button btnManageTechnician;
        private System.Windows.Forms.Button btnManageParts;
        private System.Windows.Forms.GroupBox grpManagement;
        private System.Windows.Forms.Button btnPrintReports;
        private System.Windows.Forms.Button btnExit;
    }
}

