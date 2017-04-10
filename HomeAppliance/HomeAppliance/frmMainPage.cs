using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeAppliance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            frmNewInvoice newInvoicePage = new frmNewInvoice();
            newInvoicePage.ShowDialog();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            frmManageCustomer customerPage = new frmManageCustomer();
            customerPage.ShowDialog();
        }

        private void btnManageProperty_Click(object sender, EventArgs e)
        {
            frmManageProperty propertyPage = new frmManageProperty();
            propertyPage.ShowDialog();
        }

        private void btnManageParts_Click(object sender, EventArgs e)
        {
            frmManageParts partPage = new frmManageParts();
            partPage.ShowDialog();
        }

        private void btnManageTechnician_Click(object sender, EventArgs e)
        {
            frmManageTechnican technicianPage = new frmManageTechnican();
            technicianPage.ShowDialog();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            frmManageCategories categoryPage = new frmManageCategories();
            categoryPage.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
