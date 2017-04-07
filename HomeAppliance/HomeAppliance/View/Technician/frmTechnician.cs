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
    public partial class frmTechnician : Form
    {
        public frmTechnician()
        {
            InitializeComponent();
        }

        private void frmTechnician_Load(object sender, EventArgs e)
        {

        }

        private void btnNewTechnician_Click(object sender, EventArgs e)
        {
            frmNewTechnician newTechPage = new frmNewTechnician();
            newTechPage.ShowDialog();
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            frmEditTechnician editTechPage = new frmEditTechnician();
            editTechPage.ShowDialog();
        }
    }
}
