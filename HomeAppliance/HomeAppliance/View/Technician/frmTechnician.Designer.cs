namespace HomeAppliance
{
    partial class frmTechnician
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
            this.btnDeleteTechnicain = new System.Windows.Forms.Button();
            this.btnUpdateTechnician = new System.Windows.Forms.Button();
            this.btnNewTechnician = new System.Windows.Forms.Button();
            this.btnManageTechnicianExit = new System.Windows.Forms.Button();
            this.lstTechnician = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDeleteTechnicain
            // 
            this.btnDeleteTechnicain.Location = new System.Drawing.Point(13, 182);
            this.btnDeleteTechnicain.Name = "btnDeleteTechnicain";
            this.btnDeleteTechnicain.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteTechnicain.TabIndex = 14;
            this.btnDeleteTechnicain.Text = "Delete technician";
            this.btnDeleteTechnicain.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTechnician
            // 
            this.btnUpdateTechnician.Location = new System.Drawing.Point(137, 153);
            this.btnUpdateTechnician.Name = "btnUpdateTechnician";
            this.btnUpdateTechnician.Size = new System.Drawing.Size(116, 23);
            this.btnUpdateTechnician.TabIndex = 13;
            this.btnUpdateTechnician.Text = "Update technician";
            this.btnUpdateTechnician.UseVisualStyleBackColor = true;
            // 
            // btnNewTechnician
            // 
            this.btnNewTechnician.Location = new System.Drawing.Point(13, 153);
            this.btnNewTechnician.Name = "btnNewTechnician";
            this.btnNewTechnician.Size = new System.Drawing.Size(89, 23);
            this.btnNewTechnician.TabIndex = 12;
            this.btnNewTechnician.Text = "New technician";
            this.btnNewTechnician.UseVisualStyleBackColor = true;
            // 
            // btnManageTechnicianExit
            // 
            this.btnManageTechnicianExit.Location = new System.Drawing.Point(178, 182);
            this.btnManageTechnicianExit.Name = "btnManageTechnicianExit";
            this.btnManageTechnicianExit.Size = new System.Drawing.Size(75, 23);
            this.btnManageTechnicianExit.TabIndex = 15;
            this.btnManageTechnicianExit.Text = "Exit";
            this.btnManageTechnicianExit.UseVisualStyleBackColor = true;
            // 
            // lstTechnician
            // 
            this.lstTechnician.FormattingEnabled = true;
            this.lstTechnician.Items.AddRange(new object[] {
            "ID\t\tName"});
            this.lstTechnician.Location = new System.Drawing.Point(13, 13);
            this.lstTechnician.Name = "lstTechnician";
            this.lstTechnician.Size = new System.Drawing.Size(240, 134);
            this.lstTechnician.TabIndex = 16;
            this.lstTechnician.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 214);
            this.Controls.Add(this.lstTechnician);
            this.Controls.Add(this.btnManageTechnicianExit);
            this.Controls.Add(this.btnDeleteTechnicain);
            this.Controls.Add(this.btnUpdateTechnician);
            this.Controls.Add(this.btnNewTechnician);
            this.Name = "frmTechnician";
            this.Text = "Manage Technician";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteTechnicain;
        private System.Windows.Forms.Button btnUpdateTechnician;
        private System.Windows.Forms.Button btnNewTechnician;
        private System.Windows.Forms.Button btnManageTechnicianExit;
        private System.Windows.Forms.ListBox lstTechnician;
    }
}