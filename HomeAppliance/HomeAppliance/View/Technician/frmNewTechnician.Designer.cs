﻿namespace HomeAppliance
{
    partial class frmNewTechnician
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
            this.btnNewTechnicianExit = new System.Windows.Forms.Button();
            this.btnNewTechnicianSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewTechnicianExit
            // 
            this.btnNewTechnicianExit.Location = new System.Drawing.Point(167, 38);
            this.btnNewTechnicianExit.Name = "btnNewTechnicianExit";
            this.btnNewTechnicianExit.Size = new System.Drawing.Size(75, 23);
            this.btnNewTechnicianExit.TabIndex = 30;
            this.btnNewTechnicianExit.Text = "Exit";
            this.btnNewTechnicianExit.UseVisualStyleBackColor = true;
            // 
            // btnNewTechnicianSave
            // 
            this.btnNewTechnicianSave.Location = new System.Drawing.Point(167, 9);
            this.btnNewTechnicianSave.Name = "btnNewTechnicianSave";
            this.btnNewTechnicianSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewTechnicianSave.TabIndex = 29;
            this.btnNewTechnicianSave.Text = "Save";
            this.btnNewTechnicianSave.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Technician Info:";
            // 
            // frmNewTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 73);
            this.Controls.Add(this.btnNewTechnicianExit);
            this.Controls.Add(this.btnNewTechnicianSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewTechnician";
            this.Text = "New Technician";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTechnicianExit;
        private System.Windows.Forms.Button btnNewTechnicianSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}