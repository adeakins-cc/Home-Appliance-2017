namespace HomeAppliance.View.Invoice
{
    partial class frmViewInvoice
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
            this.cryRepo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.InvoiceReporting1 = new HomeAppliance.Reports.InvoiceReporting();
            this.SuspendLayout();
            // 
            // cryRepo
            // 
            this.cryRepo.ActiveViewIndex = -1;
            this.cryRepo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRepo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryRepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRepo.Location = new System.Drawing.Point(0, 0);
            this.cryRepo.Name = "cryRepo";
            this.cryRepo.Size = new System.Drawing.Size(705, 637);
            this.cryRepo.TabIndex = 0;
            this.cryRepo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 637);
            this.Controls.Add(this.cryRepo);
            this.Name = "frmViewInvoice";
            this.Text = "frmViewInvoice";
            this.Load += new System.EventHandler(this.frmViewInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRepo;
        private Reports.InvoiceReporting InvoiceReporting1;
    }
}