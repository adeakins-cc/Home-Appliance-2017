namespace HomeAppliance
{
    partial class frmViewInvoices
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewInvoiceRange = new System.Windows.Forms.Button();
            this.txtInvoiceStart = new System.Windows.Forms.TextBox();
            this.txtInvoiceEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewInvoiceExit = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnInvoiceByDate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date:";
            // 
            // btnViewInvoiceRange
            // 
            this.btnViewInvoiceRange.Location = new System.Drawing.Point(254, 117);
            this.btnViewInvoiceRange.Name = "btnViewInvoiceRange";
            this.btnViewInvoiceRange.Size = new System.Drawing.Size(82, 23);
            this.btnViewInvoiceRange.TabIndex = 4;
            this.btnViewInvoiceRange.Text = "View Invoices";
            this.btnViewInvoiceRange.UseVisualStyleBackColor = true;
            // 
            // txtInvoiceStart
            // 
            this.txtInvoiceStart.Location = new System.Drawing.Point(103, 91);
            this.txtInvoiceStart.Name = "txtInvoiceStart";
            this.txtInvoiceStart.Size = new System.Drawing.Size(115, 20);
            this.txtInvoiceStart.TabIndex = 5;
            this.txtInvoiceStart.TextChanged += new System.EventHandler(this.txtInvoiceStart_TextChanged);
            // 
            // txtInvoiceEnd
            // 
            this.txtInvoiceEnd.Location = new System.Drawing.Point(306, 90);
            this.txtInvoiceEnd.Name = "txtInvoiceEnd";
            this.txtInvoiceEnd.Size = new System.Drawing.Size(118, 20);
            this.txtInvoiceEnd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Invoice Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Invoice Id:";
            // 
            // btnViewInvoiceExit
            // 
            this.btnViewInvoiceExit.Location = new System.Drawing.Point(342, 117);
            this.btnViewInvoiceExit.Name = "btnViewInvoiceExit";
            this.btnViewInvoiceExit.Size = new System.Drawing.Size(82, 23);
            this.btnViewInvoiceExit.TabIndex = 9;
            this.btnViewInvoiceExit.Text = "Exit";
            this.btnViewInvoiceExit.UseVisualStyleBackColor = true;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(18, 36);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 10;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(224, 36);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 11;
            // 
            // btnInvoiceByDate
            // 
            this.btnInvoiceByDate.Location = new System.Drawing.Point(342, 62);
            this.btnInvoiceByDate.Name = "btnInvoiceByDate";
            this.btnInvoiceByDate.Size = new System.Drawing.Size(82, 23);
            this.btnInvoiceByDate.TabIndex = 12;
            this.btnInvoiceByDate.Text = "View Invoices";
            this.btnInvoiceByDate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Invoice range";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select Date range";
            // 
            // frmViewInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 148);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInvoiceByDate);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnViewInvoiceExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoiceEnd);
            this.Controls.Add(this.txtInvoiceStart);
            this.Controls.Add(this.btnViewInvoiceRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmViewInvoices";
            this.Text = "View Invioces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewInvoiceRange;
        private System.Windows.Forms.TextBox txtInvoiceStart;
        private System.Windows.Forms.TextBox txtInvoiceEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewInvoiceExit;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnInvoiceByDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}