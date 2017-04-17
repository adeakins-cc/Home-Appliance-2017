using HomeAppliance.Model;
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
        // Table name constant 
        public Part newPart { get; set; }
        public Model.Invoice newInvoice = new Model.Invoice();
        public decimal quantity { get; set; }
        public decimal materialTotal;
        public decimal total;
        public decimal GST = 0.05M;
        public decimal PST = 0.08M;

        public int propertyId { get; set; }
        public int customerId { get; set; }


        public void verifyAndTotals()
        {

            #region verifyPartTotal
            try
            {
                newInvoice.setPartTotal(materialTotal);
                txtMaterials.Text = materialTotal.ToString();
            }
            catch (Exception)
            {
                newInvoice.setPartTotal(0);
                txtMaterials.Text = "0";

            }
            #endregion
            #region verifyLabourTotal
            try
            {
                newInvoice.setLabour(Convert.ToDecimal(txtLabour.Text));
            }
            catch (Exception)
            {
                newInvoice.setLabour(0);
                txtLabour.Text = "0";

            }
            #endregion
            #region verifyServiceCharge
            try
            {
                newInvoice.setServiceCharge(Convert.ToDecimal(txtServiceCalls.Text));
            }
            catch (Exception)
            {
                newInvoice.setServiceCharge(0);
                txtServiceCalls.Text = "0";

            }
            #endregion
            #region verifySubTotal
            try
            {
                newInvoice.setSubTotal(Convert.ToDecimal(txtSubtotal.Text));
            }
            catch (Exception)
            {
                newInvoice.setSubTotal(0);
                txtSubtotal.Text = "0";

            }
            #endregion
            #region verifyPST
            try
            {
                newInvoice.setPST(Convert.ToDecimal(txtPST.Text));
            }
            catch (Exception)
            {
                newInvoice.setPST(0);
                txtPST.Text = "0";

            }
            #endregion
            #region verifyGST
            try
            {
                newInvoice.setGST(Convert.ToDecimal(txtGST.Text));
            }
            catch (Exception)
            {
                newInvoice.setGST(0);
                txtGST.Text = "0";

            }
            #endregion
            #region verifyTotal
            try
            {
                newInvoice.setGrossTotal(Convert.ToDecimal(txtTotal.Text));
            }
            catch (Exception)
            {
                newInvoice.setGrossTotal(0);
                txtTotal.Text = "0";

            }
            #endregion

            newInvoice.setSubTotal(newInvoice.getPartTotal() + newInvoice.getLabour() + newInvoice.getServiceCharge());
            txtSubtotal.Text = newInvoice.getSubTotal().ToString();
            newInvoice.setGST(newInvoice.getSubTotal() * GST);
            txtGST.Text = newInvoice.getGST().ToString();
            if (chkPSTExempt.Checked != true)
            {
                newInvoice.setPST(newInvoice.getSubTotal() * PST);
                txtPST.Text = newInvoice.getPST().ToString();
            }
            else
            {
                newInvoice.setPST(0);
                txtPST.Text = newInvoice.getPST().ToString();
            }

            newInvoice.setGrossTotal(newInvoice.getGST() + newInvoice.getPST() + newInvoice.getSubTotal());
            txtTotal.Text = newInvoice.getGrossTotal().ToString();

        }
        public void updatePartList()
        {
            if (quantity > 0)
            {
                var row = (DataGridViewRow)dataListParts.RowTemplate.Clone();
                row.CreateCells(dataListParts, newPart.getPartID(), newPart.getName(), newPart.getPrice(), quantity);
                dataListParts.Rows.Add(row);
            }
            materialTotal += newPart.getPrice() * quantity;
            verifyAndTotals();
            quantity = 0;
        }
        public frmNewInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Taxes' table. You can move, or remove it, as needed.
            this.taxesTableAdapter.Fill(this.homeAppDBDataSet.Taxes);
            // Fill the table.
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.homeAppDBDataSet.Technician);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.PartsList' table. You can move, or remove it, as needed.
            this.partsListTableAdapter.Fill(this.homeAppDBDataSet.PartsList);
            verifyAndTotals();
        }

        private void btnSearchCustomerProperty_Click(object sender, EventArgs e)
        {
            frmPropertySearch chooseProperty = new frmPropertySearch(this);
            chooseProperty.ShowDialog();
            //dgvStreetBuildings selectPropertyCustomer = new dgvStreetBuildings();
            //selectPropertyCustomer.ShowDialog();
        }

        private void btnNewInvoiceExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            frmAddPart newPart = new frmAddPart(this);
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
            newRow.PSTExempt    = chkPSTExempt.CheckState.ToString();
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
            Decimal mat = (decimal)dataListParts.SelectedRows[0].Cells[2].Value * (decimal)dataListParts.SelectedRows[0].Cells[3].Value;
            materialTotal -= mat;
            verifyAndTotals();
            dataListParts.Rows.RemoveAt(dataListParts.CurrentCell.RowIndex);
        }

        private void chkPSTExempt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPSTExempt.Checked != true)
            {
                newInvoice.setPST(0);
            }
            verifyAndTotals();

        }
    }
}
