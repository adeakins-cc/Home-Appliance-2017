﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using HomeAppliance.Reports;

namespace HomeAppliance.View.Invoice
{
    public partial class frmViewInvoice : Form
    {
        public frmViewInvoice()
        {
            InitializeComponent();
        }

        private void frmViewInvoice_Load(object sender, EventArgs e)
        {

            InvoiceReporting rpt = new InvoiceReporting();
            
            BindingSource bs = new BindingSource();
            
                cryRepo.ReportSource = rpt;
            

        }

        private void cryRepo_Load(object sender, EventArgs e)
        {
                
        }
    }
}
