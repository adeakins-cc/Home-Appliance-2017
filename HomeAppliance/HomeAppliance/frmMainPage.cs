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
using HomeAppliance.View.Technician;
using HomeAppliance;

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
            newInvoicePage.Show();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            frmManageCustomer customerPage = new frmManageCustomer();
            customerPage.Show();
        }

        private void btnManageProperty_Click(object sender, EventArgs e)
        {
            dgvStreetBuildings propertyPage = new dgvStreetBuildings();
            propertyPage.Show();
        }

        private void btnManageParts_Click(object sender, EventArgs e)
        {
            frmManageParts partPage = new frmManageParts();
            partPage.Show();
        }

        private void btnManageTechnician_Click(object sender, EventArgs e)
        {
            frmManageTechnician technicianPage = new frmManageTechnician();
            technicianPage.Show();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            frmManageCategories categoryPage = new frmManageCategories();
            categoryPage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplayInvoice_Click(object sender, EventArgs e)
        {
            frmManageFinance viewInvoicePage = new frmManageFinance();
            viewInvoicePage.Show();
        }

        private void btnManageFinacial_Click(object sender, EventArgs e)
        {
            frmManageFinance viewFinancesPage = new frmManageFinance();
            viewFinancesPage.Show();
        }
    }
}
