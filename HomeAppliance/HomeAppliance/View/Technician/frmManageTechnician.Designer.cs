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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAppDBDataSet)).BeginInit();
            this.fillByTechnicianToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.technicianBindingSource, "technicianId", true));
            this.listBox1.DataSource = this.technicianBindingSource;
            this.listBox1.DisplayMember = "name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 31);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 180);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "technicianId";
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
            this.fillByTechnicianToolStrip.Size = new System.Drawing.Size(346, 27);
            this.fillByTechnicianToolStrip.TabIndex = 1;
            this.fillByTechnicianToolStrip.Text = "fillByTechnicianToolStrip";
            // 
            // fillByTechnicianToolStripButton
            // 
            this.fillByTechnicianToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTechnicianToolStripButton.Name = "fillByTechnicianToolStripButton";
            this.fillByTechnicianToolStripButton.Size = new System.Drawing.Size(118, 24);
            this.fillByTechnicianToolStripButton.Text = "FillByTechnician";
            this.fillByTechnicianToolStripButton.Click += new System.EventHandler(this.fillByTechnicianToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Technician";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 218);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 254);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit Technician";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 290);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete Technician";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 290);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmManageTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByTechnicianToolStrip);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.ListBox listBox1;
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
    }
}