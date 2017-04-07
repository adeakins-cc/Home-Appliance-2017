namespace HomeAppliance
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
            this.btnManagePropertyExit = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnNewProperty = new System.Windows.Forms.Button();
            this.btnManagePropertySearch = new System.Windows.Forms.Button();
            this.txtSearchProperty = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.lblDateActive = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.tvStreetList = new System.Windows.Forms.TreeView();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lstBuildingList = new System.Windows.Forms.ListView();
            this.lblBuildingList = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.lblOwnerInfo = new System.Windows.Forms.Label();
            this.btnSaveNewProperty = new System.Windows.Forms.Button();
            this.btnCancelP = new System.Windows.Forms.Button();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.txtBuildingStreet = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtSuperintendent = new System.Windows.Forms.TextBox();
            this.txtSuperPhone = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManagePropertyExit
            // 
            this.btnManagePropertyExit.Location = new System.Drawing.Point(595, 589);
            this.btnManagePropertyExit.Name = "btnManagePropertyExit";
            this.btnManagePropertyExit.Size = new System.Drawing.Size(94, 23);
            this.btnManagePropertyExit.TabIndex = 12;
            this.btnManagePropertyExit.Text = "Exit";
            this.btnManagePropertyExit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(595, 125);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteProperty.TabIndex = 11;
            this.btnDeleteProperty.Text = "Delete property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(595, 91);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateProperty.TabIndex = 10;
            this.btnUpdateProperty.Text = "Update property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // btnNewProperty
            // 
            this.btnNewProperty.Location = new System.Drawing.Point(595, 57);
            this.btnNewProperty.Name = "btnNewProperty";
            this.btnNewProperty.Size = new System.Drawing.Size(94, 23);
            this.btnNewProperty.TabIndex = 9;
            this.btnNewProperty.Text = "Add property";
            this.btnNewProperty.UseVisualStyleBackColor = true;
            this.btnNewProperty.Click += new System.EventHandler(this.btnNewProperty_Click);
            // 
            // btnManagePropertySearch
            // 
            this.btnManagePropertySearch.Location = new System.Drawing.Point(221, 12);
            this.btnManagePropertySearch.Name = "btnManagePropertySearch";
            this.btnManagePropertySearch.Size = new System.Drawing.Size(75, 23);
            this.btnManagePropertySearch.TabIndex = 14;
            this.btnManagePropertySearch.Text = "Search";
            this.btnManagePropertySearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchProperty
            // 
            this.txtSearchProperty.Location = new System.Drawing.Point(12, 12);
            this.txtSearchProperty.Name = "txtSearchProperty";
            this.txtSearchProperty.Size = new System.Drawing.Size(185, 20);
            this.txtSearchProperty.TabIndex = 15;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtSuperPhone);
            this.GroupBox1.Controls.Add(this.txtSuperintendent);
            this.GroupBox1.Controls.Add(this.txtUnits);
            this.GroupBox1.Controls.Add(this.txtBuildingStreet);
            this.GroupBox1.Controls.Add(this.txtBuildingNumber);
            this.GroupBox1.Controls.Add(this.txtCity);
            this.GroupBox1.Controls.Add(this.lblLastModified);
            this.GroupBox1.Controls.Add(this.lblDateActive);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.lblPropertyID);
            this.GroupBox1.Location = new System.Drawing.Point(13, 404);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(319, 168);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Property Details";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(9, 84);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(160, 20);
            this.txtCity.TabIndex = 30;
            // 
            // lblLastModified
            // 
            this.lblLastModified.Location = new System.Drawing.Point(176, 144);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(152, 16);
            this.lblLastModified.TabIndex = 29;
            this.lblLastModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateActive
            // 
            this.lblDateActive.Location = new System.Drawing.Point(16, 144);
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
            // lblPropertyID
            // 
            this.lblPropertyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPropertyID.Location = new System.Drawing.Point(241, 21);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(72, 16);
            this.lblPropertyID.TabIndex = 0;
            this.lblPropertyID.Text = "PropertyID";
            this.lblPropertyID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tvStreetList
            // 
            this.tvStreetList.Location = new System.Drawing.Point(12, 57);
            this.tvStreetList.Name = "tvStreetList";
            this.tvStreetList.Size = new System.Drawing.Size(284, 341);
            this.tvStreetList.TabIndex = 17;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(12, 35);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(94, 17);
            this.lblStreetName.TabIndex = 18;
            this.lblStreetName.Text = "Street Names";
            // 
            // lstBuildingList
            // 
            this.lstBuildingList.Location = new System.Drawing.Point(304, 57);
            this.lstBuildingList.Name = "lstBuildingList";
            this.lstBuildingList.Size = new System.Drawing.Size(265, 341);
            this.lstBuildingList.TabIndex = 19;
            this.lstBuildingList.UseCompatibleStateImageBehavior = false;
            // 
            // lblBuildingList
            // 
            this.lblBuildingList.AutoSize = true;
            this.lblBuildingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingList.Location = new System.Drawing.Point(302, 35);
            this.lblBuildingList.Name = "lblBuildingList";
            this.lblBuildingList.Size = new System.Drawing.Size(107, 17);
            this.lblBuildingList.TabIndex = 20;
            this.lblBuildingList.Text = "Street Buildings";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtOwnerID);
            this.GroupBox2.Controls.Add(this.lblOwnerInfo);
            this.GroupBox2.Location = new System.Drawing.Point(347, 404);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(285, 168);
            this.GroupBox2.TabIndex = 21;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Owner Details";
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(191, 17);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(64, 20);
            this.txtOwnerID.TabIndex = 2;
            this.txtOwnerID.Visible = false;
            // 
            // lblOwnerInfo
            // 
            this.lblOwnerInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.lblOwnerInfo.Location = new System.Drawing.Point(16, 48);
            this.lblOwnerInfo.Name = "lblOwnerInfo";
            this.lblOwnerInfo.Size = new System.Drawing.Size(239, 112);
            this.lblOwnerInfo.TabIndex = 0;
            // 
            // btnSaveNewProperty
            // 
            this.btnSaveNewProperty.Location = new System.Drawing.Point(595, 331);
            this.btnSaveNewProperty.Name = "btnSaveNewProperty";
            this.btnSaveNewProperty.Size = new System.Drawing.Size(94, 23);
            this.btnSaveNewProperty.TabIndex = 22;
            this.btnSaveNewProperty.Text = "Save";
            this.btnSaveNewProperty.UseVisualStyleBackColor = true;
            // 
            // btnCancelP
            // 
            this.btnCancelP.Location = new System.Drawing.Point(595, 368);
            this.btnCancelP.Name = "btnCancelP";
            this.btnCancelP.Size = new System.Drawing.Size(94, 23);
            this.btnCancelP.TabIndex = 23;
            this.btnCancelP.Text = "Cancel";
            this.btnCancelP.UseVisualStyleBackColor = true;
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(9, 40);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(69, 20);
            this.txtBuildingNumber.TabIndex = 31;
            // 
            // txtBuildingStreet
            // 
            this.txtBuildingStreet.Location = new System.Drawing.Point(97, 40);
            this.txtBuildingStreet.Name = "txtBuildingStreet";
            this.txtBuildingStreet.Size = new System.Drawing.Size(216, 20);
            this.txtBuildingStreet.TabIndex = 32;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(184, 84);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(109, 20);
            this.txtUnits.TabIndex = 33;
            // 
            // txtSuperintendent
            // 
            this.txtSuperintendent.Location = new System.Drawing.Point(9, 123);
            this.txtSuperintendent.Name = "txtSuperintendent";
            this.txtSuperintendent.Size = new System.Drawing.Size(160, 20);
            this.txtSuperintendent.TabIndex = 34;
            // 
            // txtSuperPhone
            // 
            this.txtSuperPhone.Location = new System.Drawing.Point(184, 123);
            this.txtSuperPhone.Name = "txtSuperPhone";
            this.txtSuperPhone.Size = new System.Drawing.Size(109, 20);
            this.txtSuperPhone.TabIndex = 35;
            // 
            // frmManageProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 628);
            this.Controls.Add(this.btnCancelP);
            this.Controls.Add(this.btnSaveNewProperty);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lblBuildingList);
            this.Controls.Add(this.lstBuildingList);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.tvStreetList);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtSearchProperty);
            this.Controls.Add(this.btnManagePropertySearch);
            this.Controls.Add(this.btnManagePropertyExit);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.btnNewProperty);
            this.Name = "frmManageProperty";
            this.Text = "Manage Property";
            this.Load += new System.EventHandler(this.frmManageProperty_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManagePropertyExit;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnNewProperty;
        private System.Windows.Forms.Button btnManagePropertySearch;
        private System.Windows.Forms.TextBox txtSearchProperty;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblLastModified;
        internal System.Windows.Forms.Label lblDateActive;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.TreeView tvStreetList;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.ListView lstBuildingList;
        private System.Windows.Forms.Label lblBuildingList;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtOwnerID;
        internal System.Windows.Forms.Label lblOwnerInfo;
        private System.Windows.Forms.Button btnSaveNewProperty;
        private System.Windows.Forms.Button btnCancelP;
        private System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox txtSuperPhone;
        private System.Windows.Forms.TextBox txtSuperintendent;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtBuildingStreet;
        private System.Windows.Forms.TextBox txtBuildingNumber;
    }
}