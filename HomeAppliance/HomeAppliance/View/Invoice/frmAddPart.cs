using System;
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
        public frmAddPart()
        {
            InitializeComponent();
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this.homeAppDBDataSet.Part);

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            int part_Id = dataGridParts.CurrentRow.Selected;

            //newRow.quantity = Convert.ToDecimal(lstPartList.se)
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
