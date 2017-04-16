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
        // Table name constants

        public frmNewInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // Fill the table.
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.homeAppDBDataSet.Technician);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.PartsList' table. You can move, or remove it, as needed.
            this.partsListTableAdapter.Fill(this.homeAppDBDataSet.PartsList);

        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            HomeAppDBDataSet.InvoiceDataTable tableInvoice = new HomeAppDBDataSet.InvoiceDataTable();
            HomeAppDBDataSet.InvoiceRow newRow = homeAppDBDataSet.Invoice.NewInvoiceRow();
        }

        private void btnSearchCustomerProperty_Click(object sender, EventArgs e)
        {
            dgvStreetBuildings selectPropertyCustomer = new dgvStreetBuildings();
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
            HomeAppDBDataSet.InvoiceDataTable tableInvoice = new HomeAppDBDataSet.InvoiceDataTable();
            HomeAppDBDataSet.InvoiceRow newRow = homeAppDBDataSet.Invoice.NewInvoiceRow();
            newRow.customerId   = Convert.ToInt32(lblCustomerId.Text);
            newRow.propertyId   = Convert.ToInt32(lblPropertyId.Text);
            newRow.serviceDate  = Convert.ToDateTime(dateServiceDate);
            newRow.invoiceDate  = Convert.ToDateTime(dateInvoiceDate);
            newRow.technicianId = Convert.ToInt32(drpTechnician.SelectedIndex);
            newRow.complaints   = txtComplaint.Text;
            newRow.notes        = txtNotes.Text;
            newRow.partTotal    = Convert.ToDecimal(txtMaterials.Text);
            newRow.labour       = Convert.ToDecimal(txtLabour.Text);
            newRow.serviceCharge = Convert.ToDecimal(txtServiceCalls.Text);
            newRow.GST          = Convert.ToDecimal(txtGST.Text);
            newRow.PST          = Convert.ToDecimal(txtPST.Text);
            newRow.subTotal     = Convert.ToDecimal(txtSubtotal.Text);
            newRow.grossTotal   = Convert.ToDecimal(txtTotal.Text);
            newRow.poNumber     = txtPONumber.Text;
            newRow.PSTExempt    = chkRSTExempt.CheckState.ToString();
            newRow.make         = txtMake.Text;
            newRow.model        = txtModel.Text;
            newRow.serialNumber = txtSerialNumber.Text;
            tableInvoice.AddInvoiceRow(newRow);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillBy1(this.homeAppDBDataSet.Invoice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillBy1(this.homeAppDBDataSet.Invoice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {

        }
    }
}
