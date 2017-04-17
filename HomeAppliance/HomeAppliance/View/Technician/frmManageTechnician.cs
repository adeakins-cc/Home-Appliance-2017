using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAppliance.View.Technician
{
    public partial class frmManageTechnician : Form
    {
        public frmManageTechnician()
        {
            InitializeComponent();
        }

        private void frmManageTechnician_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.homeAppDBDataSet.Technician);

        }

        private void fillByTechnicianToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.technicianTableAdapter.FillByTechnician(this.homeAppDBDataSet.Technician);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
