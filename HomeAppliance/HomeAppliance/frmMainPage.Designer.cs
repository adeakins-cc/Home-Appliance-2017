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
            this.btnManageFinacial = new System.Windows.Forms.Button();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.btnPrintReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(21, 233);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(186, 33);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reconnect to database";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewInvoice.Location = new System.Drawing.Point(21, 13);
            this.btnNewInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(171, 33);
            this.btnNewInvoice.TabIndex = 1;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // btnDisplayInvoice
            // 
            this.btnDisplayInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayInvoice.Location = new System.Drawing.Point(238, 13);
            this.btnDisplayInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayInvoice.Name = "btnDisplayInvoice";
            this.btnDisplayInvoice.Size = new System.Drawing.Size(188, 33);
            this.btnDisplayInvoice.TabIndex = 2;
            this.btnDisplayInvoice.Text = "Display Invoices";
            this.btnDisplayInvoice.UseVisualStyleBackColor = true;
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomer.Location = new System.Drawing.Point(8, 34);
            this.btnManageCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(171, 32);
            this.btnManageCustomer.TabIndex = 3;
            this.btnManageCustomer.Text = "Manage Customers";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // btnManageProperty
            // 
            this.btnManageProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProperty.Location = new System.Drawing.Point(225, 34);
            this.btnManageProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageProperty.Name = "btnManageProperty";
            this.btnManageProperty.Size = new System.Drawing.Size(188, 33);
            this.btnManageProperty.TabIndex = 4;
            this.btnManageProperty.Text = "Manage Property";
            this.btnManageProperty.UseVisualStyleBackColor = true;
            this.btnManageProperty.Click += new System.EventHandler(this.btnManageProperty_Click);
            // 
            // btnManageTechnician
            // 
            this.btnManageTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTechnician.Location = new System.Drawing.Point(225, 86);
            this.btnManageTechnician.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageTechnician.Name = "btnManageTechnician";
            this.btnManageTechnician.Size = new System.Drawing.Size(188, 33);
            this.btnManageTechnician.TabIndex = 5;
            this.btnManageTechnician.Text = "Manage Technicians";
            this.btnManageTechnician.UseVisualStyleBackColor = true;
            this.btnManageTechnician.Click += new System.EventHandler(this.btnManageTechnician_Click);
            // 
            // btnManageParts
            // 
            this.btnManageParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageParts.Location = new System.Drawing.Point(8, 86);
            this.btnManageParts.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageParts.Name = "btnManageParts";
            this.btnManageParts.Size = new System.Drawing.Size(171, 33);
            this.btnManageParts.TabIndex = 6;
            this.btnManageParts.Text = "Manage Parts";
            this.btnManageParts.UseVisualStyleBackColor = true;
            this.btnManageParts.Click += new System.EventHandler(this.btnManageParts_Click);
            // 
            // grpManagement
            // 
            this.grpManagement.Controls.Add(this.btnManageFinacial);
            this.grpManagement.Controls.Add(this.btnManageCategories);
            this.grpManagement.Controls.Add(this.btnManageCustomer);
            this.grpManagement.Controls.Add(this.btnManageProperty);
            this.grpManagement.Controls.Add(this.btnManageParts);
            this.grpManagement.Controls.Add(this.btnManageTechnician);
            this.grpManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManagement.Location = new System.Drawing.Point(13, 79);
            this.grpManagement.Margin = new System.Windows.Forms.Padding(4);
            this.grpManagement.Name = "grpManagement";
            this.grpManagement.Padding = new System.Windows.Forms.Padding(4);
            this.grpManagement.Size = new System.Drawing.Size(648, 146);
            this.grpManagement.TabIndex = 7;
            this.grpManagement.TabStop = false;
            this.grpManagement.Text = "Management";
            // 
            // btnManageFinacial
            // 
            this.btnManageFinacial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageFinacial.Location = new System.Drawing.Point(458, 34);
            this.btnManageFinacial.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageFinacial.Name = "btnManageFinacial";
            this.btnManageFinacial.Size = new System.Drawing.Size(161, 33);
            this.btnManageFinacial.TabIndex = 8;
            this.btnManageFinacial.Text = "Manage Finacial";
            this.btnManageFinacial.UseVisualStyleBackColor = true;
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCategories.Location = new System.Drawing.Point(458, 86);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Size = new System.Drawing.Size(161, 32);
            this.btnManageCategories.TabIndex = 7;
            this.btnManageCategories.Text = "Manage Categories";
            this.btnManageCategories.UseVisualStyleBackColor = true;
            this.btnManageCategories.Click += new System.EventHandler(this.btnManageCategories_Click);
            // 
            // btnPrintReports
            // 
            this.btnPrintReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReports.Location = new System.Drawing.Point(471, 13);
            this.btnPrintReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintReports.Name = "btnPrintReports";
            this.btnPrintReports.Size = new System.Drawing.Size(161, 33);
            this.btnPrintReports.TabIndex = 8;
            this.btnPrintReports.Text = "Print Reports";
            this.btnPrintReports.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(548, 233);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 26);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 272);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintReports);
            this.Controls.Add(this.grpManagement);
            this.Controls.Add(this.btnDisplayInvoice);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Button btnManageFinacial;
    }
}

