using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAppliance.View.Invoice
{
    public partial class frmViewInvoice : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
        SqlCommand dbCommand = new SqlCommand();
        public frmViewInvoice()
        {
            InitializeComponent();
        }

        private void frmViewInvoice_Load(object sender, EventArgs e)
        {

            Reports.InvoiceReporting cryRpt = new Reports.InvoiceReporting();
            cryRpt.Load("Reports/InvoiceReporting.rpt");
            cryRepo.ReportSource = cryRpt;
            cryRepo.Refresh();
        }
    }
}
