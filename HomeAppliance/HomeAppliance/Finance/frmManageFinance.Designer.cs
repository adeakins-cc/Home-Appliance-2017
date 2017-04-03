﻿namespace HomeAppliance.Finance
{
    partial class frmManageFinance
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
            this.dateSearchStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSearchEnd = new System.Windows.Forms.DateTimePicker();
            this.lstFinance = new System.Windows.Forms.ListBox();
            this.btnSearchDue = new System.Windows.Forms.Button();
            this.btnSearchOverdue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchList = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datePaid = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtChequeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChequeNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateOnCheque = new System.Windows.Forms.DateTimePicker();
            this.btnSaveFinance = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListAllOverdue = new System.Windows.Forms.Button();
            this.btnListAllDue = new System.Windows.Forms.Button();
            this.btnFinanceExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateSearchStart
            // 
            this.dateSearchStart.Location = new System.Drawing.Point(70, 10);
            this.dateSearchStart.Name = "dateSearchStart";
            this.dateSearchStart.Size = new System.Drawing.Size(200, 20);
            this.dateSearchStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date:";
            // 
            // dateSearchEnd
            // 
            this.dateSearchEnd.Location = new System.Drawing.Point(70, 36);
            this.dateSearchEnd.Name = "dateSearchEnd";
            this.dateSearchEnd.Size = new System.Drawing.Size(200, 20);
            this.dateSearchEnd.TabIndex = 3;
            this.dateSearchEnd.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lstFinance
            // 
            this.lstFinance.FormattingEnabled = true;
            this.lstFinance.Items.AddRange(new object[] {
            "Date\tInvoice\tOwner\t\tAmount\tPaid"});
            this.lstFinance.Location = new System.Drawing.Point(12, 12);
            this.lstFinance.Name = "lstFinance";
            this.lstFinance.Size = new System.Drawing.Size(279, 108);
            this.lstFinance.TabIndex = 5;
            // 
            // btnSearchDue
            // 
            this.btnSearchDue.Location = new System.Drawing.Point(198, 62);
            this.btnSearchDue.Name = "btnSearchDue";
            this.btnSearchDue.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDue.TabIndex = 6;
            this.btnSearchDue.Text = "Due";
            this.btnSearchDue.UseVisualStyleBackColor = true;
            // 
            // btnSearchOverdue
            // 
            this.btnSearchOverdue.Location = new System.Drawing.Point(36, 63);
            this.btnSearchOverdue.Name = "btnSearchOverdue";
            this.btnSearchOverdue.Size = new System.Drawing.Size(75, 22);
            this.btnSearchOverdue.TabIndex = 7;
            this.btnSearchOverdue.Text = "Overdue";
            this.btnSearchOverdue.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnSearchOverdue);
            this.groupBox1.Controls.Add(this.btnSearchList);
            this.groupBox1.Controls.Add(this.btnSearchDue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateSearchStart);
            this.groupBox1.Controls.Add(this.dateSearchEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearchList
            // 
            this.btnSearchList.Location = new System.Drawing.Point(117, 62);
            this.btnSearchList.Name = "btnSearchList";
            this.btnSearchList.Size = new System.Drawing.Size(75, 23);
            this.btnSearchList.TabIndex = 5;
            this.btnSearchList.Text = "List";
            this.btnSearchList.UseVisualStyleBackColor = true;
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(198, 17);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(75, 23);
            this.btnListAll.TabIndex = 6;
            this.btnListAll.Text = "List All";
            this.btnListAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveFinance);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateOnCheque);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtChequeNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtChequeName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAmountPaid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.datePaid);
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 254);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // datePaid
            // 
            this.datePaid.Location = new System.Drawing.Point(6, 36);
            this.datePaid.Name = "datePaid";
            this.datePaid.Size = new System.Drawing.Size(188, 20);
            this.datePaid.TabIndex = 0;
            this.datePaid.Value = new System.DateTime(2017, 4, 3, 11, 23, 18, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Paid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount Paid:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(94, 63);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPaid.TabIndex = 3;
            // 
            // txtChequeName
            // 
            this.txtChequeName.Location = new System.Drawing.Point(94, 89);
            this.txtChequeName.Name = "txtChequeName";
            this.txtChequeName.Size = new System.Drawing.Size(100, 20);
            this.txtChequeName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cheque name:";
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.Location = new System.Drawing.Point(94, 115);
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtChequeNumber.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cheque No:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(57, 180);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(137, 67);
            this.txtNotes.TabIndex = 8;
            this.txtNotes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date on Cheque:";
            // 
            // dateOnCheque
            // 
            this.dateOnCheque.Location = new System.Drawing.Point(6, 154);
            this.dateOnCheque.Name = "dateOnCheque";
            this.dateOnCheque.Size = new System.Drawing.Size(188, 20);
            this.dateOnCheque.TabIndex = 10;
            this.dateOnCheque.Value = new System.DateTime(2017, 4, 3, 11, 23, 18, 0);
            // 
            // btnSaveFinance
            // 
            this.btnSaveFinance.Location = new System.Drawing.Point(6, 224);
            this.btnSaveFinance.Name = "btnSaveFinance";
            this.btnSaveFinance.Size = new System.Drawing.Size(45, 23);
            this.btnSaveFinance.TabIndex = 12;
            this.btnSaveFinance.Text = "Save";
            this.btnSaveFinance.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListAllDue);
            this.groupBox3.Controls.Add(this.btnListAllOverdue);
            this.groupBox3.Controls.Add(this.btnListAll);
            this.groupBox3.Location = new System.Drawing.Point(0, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // btnListAllOverdue
            // 
            this.btnListAllOverdue.Location = new System.Drawing.Point(117, 17);
            this.btnListAllOverdue.Name = "btnListAllOverdue";
            this.btnListAllOverdue.Size = new System.Drawing.Size(75, 23);
            this.btnListAllOverdue.TabIndex = 7;
            this.btnListAllOverdue.Text = "All Overdue";
            this.btnListAllOverdue.UseVisualStyleBackColor = true;
            // 
            // btnListAllDue
            // 
            this.btnListAllDue.Location = new System.Drawing.Point(36, 17);
            this.btnListAllDue.Name = "btnListAllDue";
            this.btnListAllDue.Size = new System.Drawing.Size(75, 23);
            this.btnListAllDue.TabIndex = 8;
            this.btnListAllDue.Text = "All Due";
            this.btnListAllDue.UseVisualStyleBackColor = true;
            // 
            // btnFinanceExit
            // 
            this.btnFinanceExit.Location = new System.Drawing.Point(422, 272);
            this.btnFinanceExit.Name = "btnFinanceExit";
            this.btnFinanceExit.Size = new System.Drawing.Size(75, 23);
            this.btnFinanceExit.TabIndex = 10;
            this.btnFinanceExit.Text = "Exit";
            this.btnFinanceExit.UseVisualStyleBackColor = true;
            // 
            // frmManageFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 300);
            this.Controls.Add(this.btnFinanceExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstFinance);
            this.Name = "frmManageFinance";
            this.Text = "Manage Finance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateSearchStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateSearchEnd;
        private System.Windows.Forms.ListBox lstFinance;
        private System.Windows.Forms.Button btnSearchDue;
        private System.Windows.Forms.Button btnSearchOverdue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchList;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveFinance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateOnCheque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.TextBox txtChequeNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChequeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePaid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnListAllDue;
        private System.Windows.Forms.Button btnListAllOverdue;
        private System.Windows.Forms.Button btnFinanceExit;
    }
}