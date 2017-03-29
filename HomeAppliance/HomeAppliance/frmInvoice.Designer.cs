namespace HomeAppliance
{
    partial class frmInvoice
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
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.lstOwner = new System.Windows.Forms.ListView();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lstProperty = new System.Windows.Forms.ListView();
            this.lblSerDate = new System.Windows.Forms.Label();
            this.dtServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.drpTechnician = new System.Windows.Forms.ComboBox();
            this.lblCustomerComplain = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblServiceNotes = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.grpCharge = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblmaterials = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.Location = new System.Drawing.Point(11, 28);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtInvoiceDate.TabIndex = 0;
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
            // dtServiceDate
            // 
            this.dtServiceDate.Location = new System.Drawing.Point(11, 197);
            this.dtServiceDate.Name = "dtServiceDate";
            this.dtServiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtServiceDate.TabIndex = 6;
            this.dtServiceDate.ValueChanged += new System.EventHandler(this.dtServiceDate_ValueChanged);
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 240);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
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
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(218, 240);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(200, 96);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partName,
            this.Price,
            this.quality});
            this.dataGridView1.Location = new System.Drawing.Point(12, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 56);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.grpCharge.Controls.Add(this.button1);
            this.grpCharge.Controls.Add(this.btnPost);
            this.grpCharge.Controls.Add(this.checkBox2);
            this.grpCharge.Controls.Add(this.checkBox1);
            this.grpCharge.Controls.Add(this.textBox7);
            this.grpCharge.Controls.Add(this.label6);
            this.grpCharge.Controls.Add(this.textBox6);
            this.grpCharge.Controls.Add(this.label5);
            this.grpCharge.Controls.Add(this.textBox5);
            this.grpCharge.Controls.Add(this.label4);
            this.grpCharge.Controls.Add(this.textBox4);
            this.grpCharge.Controls.Add(this.label3);
            this.grpCharge.Controls.Add(this.textBox3);
            this.grpCharge.Controls.Add(this.label2);
            this.grpCharge.Controls.Add(this.textBox2);
            this.grpCharge.Controls.Add(this.label1);
            this.grpCharge.Controls.Add(this.textBox1);
            this.grpCharge.Controls.Add(this.lblmaterials);
            this.grpCharge.Location = new System.Drawing.Point(424, 28);
            this.grpCharge.Name = "grpCharge";
            this.grpCharge.Size = new System.Drawing.Size(178, 387);
            this.grpCharge.TabIndex = 21;
            this.grpCharge.TabStop = false;
            this.grpCharge.Text = "Charge";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Session";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(97, 246);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 16;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(92, 222);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "PST Exempt";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(92, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "HST Exempt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(75, 172);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(75, 146);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(75, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Labour:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(527, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCharge);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblServiceNotes);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblCustomerComplain);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.drpTechnician);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.lblSerDate);
            this.Controls.Add(this.dtServiceDate);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.lstProperty);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lstOwner);
            this.Controls.Add(this.lblInvDate);
            this.Controls.Add(this.dtInvoiceDate);
            this.Name = "frmInvoice";
            this.Text = "New Invoices";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCharge.ResumeLayout(false);
            this.grpCharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.Label lblInvDate;
        private System.Windows.Forms.ListView lstOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.ListView lstProperty;
        private System.Windows.Forms.Label lblSerDate;
        private System.Windows.Forms.DateTimePicker dtServiceDate;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.ComboBox drpTechnician;
        private System.Windows.Forms.Label lblCustomerComplain;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblServiceNotes;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.GroupBox grpCharge;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblmaterials;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button2;
    }
}