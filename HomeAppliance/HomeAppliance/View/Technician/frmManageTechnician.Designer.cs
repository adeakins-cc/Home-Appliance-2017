namespace HomeAppliance.View.Technician
{
    partial class frmManageTechnician
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
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeAppDBDataSet = new HomeAppliance.HomeAppDBDataSet();
            this.technicianTableAdapter = new HomeAppliance.HomeAppDBDataSetTableAdapters.TechnicianTableAdapter();
            this.fillByTechnicianToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByTechnicianToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnAddTech = new System.Windows.Forms.Button();
            this.txtTechName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditTech = new System.Windows.Forms.Button();
            this.btnDeleteTech = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvTechList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            this.fillByTechnicianToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechList)).BeginInit();
            this.SuspendLayout();
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataMember = "Technician";
            this.technicianBindingSource.DataSource = this.homeAppDBDataSetBindingSource;
            // 
            // homeAppDBDataSetBindingSource
            // 
            this.homeAppDBDataSetBindingSource.DataSource = this.homeAppDBDataSet;
            this.homeAppDBDataSetBindingSource.Position = 0;
            // 
            // homeAppDBDataSet
            // 
            this.homeAppDBDataSet.DataSetName = "HomeAppDBDataSet";
            this.homeAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technicianTableAdapter
            // 
            this.technicianTableAdapter.ClearBeforeFill = true;
            // 
            // fillByTechnicianToolStrip
            // 
            this.fillByTechnicianToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByTechnicianToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByTechnicianToolStripButton});
            this.fillByTechnicianToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByTechnicianToolStrip.Name = "fillByTechnicianToolStrip";
            this.fillByTechnicianToolStrip.Size = new System.Drawing.Size(316, 27);
            this.fillByTechnicianToolStrip.TabIndex = 1;
            this.fillByTechnicianToolStrip.Text = "fillByTechnicianToolStrip";
            // 
            // fillByTechnicianToolStripButton
            // 
            this.fillByTechnicianToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTechnicianToolStripButton.Name = "fillByTechnicianToolStripButton";
            this.fillByTechnicianToolStripButton.Size = new System.Drawing.Size(118, 24);
            this.fillByTechnicianToolStripButton.Text = "FillByTechnician";
            // 
            // btnAddTech
            // 
            this.btnAddTech.Location = new System.Drawing.Point(13, 254);
            this.btnAddTech.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTech.Name = "btnAddTech";
            this.btnAddTech.Size = new System.Drawing.Size(135, 28);
            this.btnAddTech.TabIndex = 2;
            this.btnAddTech.Text = "Add Technician";
            this.btnAddTech.UseVisualStyleBackColor = true;
            this.btnAddTech.Click += new System.EventHandler(this.btnAddTech_Click);
            // 
            // txtTechName
            // 
            this.txtTechName.Location = new System.Drawing.Point(69, 218);
            this.txtTechName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(235, 22);
            this.txtTechName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // btnEditTech
            // 
            this.btnEditTech.Location = new System.Drawing.Point(168, 254);
            this.btnEditTech.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTech.Name = "btnEditTech";
            this.btnEditTech.Size = new System.Drawing.Size(135, 28);
            this.btnEditTech.TabIndex = 5;
            this.btnEditTech.Text = "Edit Technician";
            this.btnEditTech.UseVisualStyleBackColor = true;
            this.btnEditTech.Click += new System.EventHandler(this.btnEditTech_Click);
            // 
            // btnDeleteTech
            // 
            this.btnDeleteTech.Location = new System.Drawing.Point(13, 291);
            this.btnDeleteTech.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTech.Name = "btnDeleteTech";
            this.btnDeleteTech.Size = new System.Drawing.Size(135, 28);
            this.btnDeleteTech.TabIndex = 6;
            this.btnDeleteTech.Text = "Delete Technician";
            this.btnDeleteTech.UseVisualStyleBackColor = true;
            this.btnDeleteTech.Click += new System.EventHandler(this.btnDeleteTech_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 291);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvTechList
            // 
            this.dgvTechList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechList.Location = new System.Drawing.Point(13, 30);
            this.dgvTechList.Name = "dgvTechList";
            this.dgvTechList.RowTemplate.Height = 24;
            this.dgvTechList.Size = new System.Drawing.Size(291, 181);
            this.dgvTechList.TabIndex = 8;
            this.dgvTechList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTechList_MouseClick);
            // 
            // frmManageTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 367);
            this.Controls.Add(this.dgvTechList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteTech);
            this.Controls.Add(this.btnEditTech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTechName);
            this.Controls.Add(this.btnAddTech);
            this.Controls.Add(this.fillByTechnicianToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageTechnician";
            this.Text = "frmManageTechnician";
            this.Load += new System.EventHandler(this.frmManageTechnician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            this.fillByTechnicianToolStrip.ResumeLayout(false);
            this.fillByTechnicianToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource homeAppDBDataSetBindingSource;
        private HomeAppDBDataSet homeAppDBDataSet;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private HomeAppDBDataSetTableAdapters.TechnicianTableAdapter technicianTableAdapter;
        private System.Windows.Forms.ToolStrip fillByTechnicianToolStrip;
        private System.Windows.Forms.ToolStripButton fillByTechnicianToolStripButton;
        private System.Windows.Forms.Button btnAddTech;
        private System.Windows.Forms.TextBox txtTechName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditTech;
        private System.Windows.Forms.Button btnDeleteTech;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvTechList;
    }
}