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
    public partial class frmManageParts : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
        SqlCommand dbCommand = new SqlCommand();
        bool buttonClicked;

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
            displayPartList();
        }

        public void displayPartList()
        {
            CategoryClass obj = cbbCategory.SelectedItem as CategoryClass;
            if (obj != null)
            {
                dgvPartDetails.DataSource = DataService.getPartByCategoryID(obj.categoryId);
            }
        }

        public void executeQuery(String query)
        {
            try
            {
                dbConn.Open();
                dbCommand = new SqlCommand(query, dbConn);
                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New part is added");
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        private void btnNewPart_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            txtPartName.Enabled = true;
            txtPrice.Enabled = true;
            btnSavePart.Enabled = true;
            btnCancelPart.Enabled = true;
            dgvPartDetails.Enabled = false;
            btnNewPart.Enabled = false;
            btnEditPart.Enabled = false;
            btnDeletePart.Enabled = false;

            txtPartName.Text = "";
            txtPrice.Text = "";
        }

        private void btnEditPart_Click(object sender, EventArgs e)
        {
            buttonClicked = false;
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

        private void btnSavePart_Click(object sender, EventArgs e)
        {
            if (buttonClicked == true)
            {
                // insert into part

            }
            if (buttonClicked == false)
            {
                // update selected part
           

            }
        }

        private void btnManagePartsExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}