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
    public partial class frmNewInvoice : Form
    {
        public frmNewInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.PartsList' table. You can move, or remove it, as needed.
            this.partsListTableAdapter.Fill(this.homeAppDBDataSet.PartsList);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this.homeAppDBDataSet.Part);

        }

        private void btnSearchCustomerProperty_Click(object sender, EventArgs e)
        {

        }

        private void btnNewInvoiceExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
