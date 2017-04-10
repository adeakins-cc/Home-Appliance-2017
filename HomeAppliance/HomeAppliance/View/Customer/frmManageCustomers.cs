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
    public partial class frmManageCustomer : Form
    {
        public frmManageCustomer()
        {
            InitializeComponent();
        }

        private void frmManageCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.homeAppDBDataSet1.Customer);
            // TODO: This line of code loads data into the 'homeAppDBDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.homeAppDBDataSet1.Customer);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.homeAppDBDataSet.City);

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void unitNumber01_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
