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
    public partial class frmManageParts : Form
    {
        public frmManageParts()
        {
            InitializeComponent();
        }

        private void frmManageParts_Load(object sender, EventArgs e)
        {

            txtPartName.Enabled = false;
            txtPrice.Enabled = false;
            btnSavePart.Enabled = false;
            btnCancelPart.Enabled = false;

            // TODO: This line of code loads data into the 'homeAppDBDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.homeAppDBDataSet.Category);


            // display parts detail for selected category
            cbbCategory.DataSource = DataService.getAllCategory();
            cbbCategory.DisplayMember = "name";
            cbbCategory.ValueMember = "categoryId";
            CategoryClass obj = cbbCategory.SelectedItem as CategoryClass;
            if (obj!=null)
            {
                dgvPartDetails.DataSource = DataService.getPartByCategoryID(obj.categoryId);
            }
        }

        private void cbbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CategoryClass obj = cbbCategory.SelectedItem as CategoryClass;
            if (obj != null)
            {
                dgvPartDetails.DataSource = DataService.getPartByCategoryID(obj.categoryId);
            }
        }

        private void btnEditPart_Click(object sender, EventArgs e)
        {
            if (dgvPartDetails.SelectedRows.Count > 0)
            {
                txtPartName.Enabled = true;
                txtPrice.Enabled = true;
                btnSavePart.Enabled = true;
                btnCancelPart.Enabled = true;
            }
        }

        private void dgvPartDetails_MouseClick(object sender, MouseEventArgs e)
        {
            txtPartName.Text = dgvPartDetails.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvPartDetails.CurrentRow.Cells[2].Value.ToString();
        }
    }
}