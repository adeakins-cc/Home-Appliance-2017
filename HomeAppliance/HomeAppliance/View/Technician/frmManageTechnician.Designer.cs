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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTechList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            this.fillByTechnicianToolStrip.SuspendLayout();
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
            this.fillByTechnicianToolStrip.Size = new System.Drawing.Size(226, 25);
            this.fillByTechnicianToolStrip.TabIndex = 1;
            this.fillByTechnicianToolStrip.Text = "fillByTechnicianToolStrip";
            // 
            // fillByTechnicianToolStripButton
            // 
            this.fillByTechnicianToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTechnicianToolStripButton.Name = "fillByTechnicianToolStripButton";
            this.fillByTechnicianToolStripButton.Size = new System.Drawing.Size(96, 22);
            this.fillByTechnicianToolStripButton.Text = "FillByTechnician";
            this.fillByTechnicianToolStripButton.Click += new System.EventHandler(this.fillByTechnicianToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Technician";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit Technician";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete Technician";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(119, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstTechList
            // 
            this.lstTechList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.technicianBindingSource, "technicianId", true));
            this.lstTechList.DataSource = this.technicianBindingSource;
            this.lstTechList.DisplayMember = "name";
            this.lstTechList.FormattingEnabled = true;
            this.lstTechList.Location = new System.Drawing.Point(10, 25);
            this.lstTechList.Name = "lstTechList";
            this.lstTechList.Size = new System.Drawing.Size(198, 147);
            this.lstTechList.TabIndex = 0;
            this.lstTechList.ValueMember = "technicianId";
            // 
            // frmManageTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 284);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByTechnicianToolStrip);
            this.Controls.Add(this.lstTechList);
            this.Name = "frmManageTechnician";
            this.Text = "frmManageTechnician";
            this.Load += new System.EventHandler(this.frmManageTechnician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).EndInit();
            this.fillByTechnicianToolStrip.ResumeLayout(false);
            this.fillByTechnicianToolStrip.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstTechList;
    }
}