using HomeAppliance.Model;
using HomeAppliance.View.Invoice;
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


namespace HomeAppliance
{
    public partial class frmNewInvoice : Form
    {
        // Table name constant 
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
        SqlCommand dbCommand = new SqlCommand();
        public Part newPart { get; set; }
        public Model.Invoice newInvoice = new Model.Invoice();
        public int invoiceId;
        public decimal quantity { get; set; }
        public decimal materialTotal;
        public decimal total;
        public decimal GST = 0.05M;
        public decimal PST = 0.08M;

        public int propertyId = 0;
        public int customerId = 0;
        public string error = "";

        public void generatedInvoiceId()
        {
            dbCommand.Connection = dbConn;
            dbCommand.Connection.Close();
            dbCommand.Connection.Open();

            SqlDataReader readPropInfo;
            dbCommand.CommandText = "SELECT invoiceId FROM Invoice ORDER BY invoiceId DESC";
            readPropInfo = dbCommand.ExecuteReader();
            readPropInfo.Read();
            invoiceId = (int)readPropInfo["invoiceid"] + 1;
            lblInvoiceId.Text = invoiceId.ToString();
        }

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
        public void loadPropertyCustomer()
        {
            if (propertyId != 0)
            {
                dbCommand.Connection = dbConn;
                dbCommand.Connection.Close();
                dbCommand.Connection.Open();

                SqlDataReader readPropInfo;
                dbCommand.CommandText = "SELECT * FROM Property WHERE propertyId = " + propertyId;
                readPropInfo = dbCommand.ExecuteReader();
                readPropInfo.Read();

                string propertyText = "";
                propertyText += readPropInfo["unitNumber"].ToString() + " " + readPropInfo["streetNumber"].ToString() + "\n " +
                    readPropInfo["streetName"].ToString() + " " + readPropInfo["cityId"].ToString() + "\n " +
                    readPropInfo["superintendent"].ToString() + " " + readPropInfo["superintendentPhone"].ToString();
                txtProperty.Text = propertyText;

                dbCommand.CommandText = "SELECT * FROM Customer WHERE customerId = " + customerId;
                readPropInfo.Close();
                readPropInfo = dbCommand.ExecuteReader();
                readPropInfo.Read();

                string customerText = "";
                customerText += readPropInfo["firstName"].ToString() + " " + readPropInfo["lastName"].ToString() + "\n " +
                    readPropInfo["companyName"].ToString() + "\n " + readPropInfo["unitNumber01"].ToString() + " " +
                    readPropInfo["streetNumber01"].ToString() + " " + readPropInfo["streetName_01"].ToString();
                txtCustomer.Text = customerText;
            }
            
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // Fill the table.
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.homeAppDBDataSet.Technician);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.PartsList' table. You can move, or remove it, as needed.
            this.partsListTableAdapter.Fill(this.homeAppDBDataSet.PartsList);
            verifyAndTotals();
            loadPropertyCustomer();
            generatedInvoiceId();
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
            HomeAppDBDataSet.InvoiceDataTable tableInvoice = homeAppDBDataSet.Invoice;
            HomeAppDBDataSet.InvoiceRow newRow = homeAppDBDataSet.Invoice.NewInvoiceRow();
            newRow.invoiceId    = invoiceId;
            newRow.customerId   = customerId;
            newRow.propertyId   = propertyId;
            newRow.serviceDate  = dateServiceDate.Value;
            newRow.invoiceDate  = dateInvoiceDate.Value;
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
            error = "";
            if (customerId == 0)
            {
                error += "No Customer chosen. \n";
            }
            if (propertyId == 0)
            {
                error += "No Property chosen. \n";
            }
            
            if (error != "")
            {
                MessageBox.Show(error);
            }
            else
            {
                tableInvoice.ImportRow(newRow);
                this.Close();
            }

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
