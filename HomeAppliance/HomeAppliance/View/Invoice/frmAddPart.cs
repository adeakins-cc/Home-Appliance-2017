using HomeAppliance.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAppliance.View.Invoice
{

    public partial class frmAddPart : Form
    {

        Part newPart = new Part();
        frmNewInvoice newInvoice;
        public frmAddPart(frmNewInvoice newInvoice01)
        {
            InitializeComponent();
            newInvoice = newInvoice01;
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this.homeAppDBDataSet.Part);
            dataGridParts.Columns[2].Width = 269;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (newPart.getPartID() > 0)
            {
                newInvoice.newPart = newPart;
                newInvoice.quantity = numQTY.Value;
                newInvoice.updatePartList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Part");
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            newPart.setPartID((int)dataGridParts.SelectedRows[0].Cells[0].Value);
            newPart.setName(dataGridParts.SelectedRows[0].Cells[2].Value.ToString());
            newPart.setPrice((decimal)dataGridParts.SelectedRows[0].Cells[3].Value);
            txtSearchName.Text = newPart.getName();              
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            try
            {
                bs.DataSource = dataGridParts.DataSource;
                bs.Filter = "Name like '%" + txtSearchName.Text + "%'";
                dataGridParts.DataSource = bs;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
