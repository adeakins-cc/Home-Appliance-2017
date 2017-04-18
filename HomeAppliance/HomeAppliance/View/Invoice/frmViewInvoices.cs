using HomeAppliance.View.Invoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAppliance
{
    public partial class frmManageFinance : Form
    {
        public frmManageFinance()
        {
            InitializeComponent();
        }

        private void txtInvoiceStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewInvoiceRange_Click(object sender, EventArgs e)
        {
            frmViewInvoice invoice = new frmViewInvoice();
            invoice.ShowDialog();
        }

        private void frmManageFinance_Load(object sender, EventArgs e)
        {

        }
    }
}
