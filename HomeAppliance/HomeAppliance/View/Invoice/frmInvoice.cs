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
    public partial class frmNewInvoice : Form
    {
        DataColumn column = new DataColumn();
        DataTable table = new DataTable("Invoice");
        public frmNewInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.homeAppDBDataSet.Technician);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.PartsList' table. You can move, or remove it, as needed.
            this.partsListTableAdapter.Fill(this.homeAppDBDataSet.PartsList);
            newRow();
        }

        private void btnSearchCustomerProperty_Click(object sender, EventArgs e)
        {
            frmManageProperty selectPropertyCustomer = new frmManageProperty();
            selectPropertyCustomer.ShowDialog();
        }

        private void btnNewInvoiceExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            frmAddPart newPart = new frmAddPart();
            newPart.ShowDialog();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            // Add the column to a new DataTable.
            table.Columns.Add(column);
        }

        private void newRow()
        {
            column.DataType          = System.Type.GetType("System.Int32");
            column.AutoIncrement     = true;
            column.AutoIncrementSeed = 1000;
            column.AutoIncrementStep = 10;
        }

        private void invoiceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
