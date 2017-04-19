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
        }

        private void cbbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displayPartList();
        }

        public void displayPartList()
        {
            string partListQuery = "SELECT partId, name, price FROM Part WHERE categoryId = " + cbbCategory.SelectedValue.ToString() + " ORDER BY name ASC";
            DataTable dt = new DataTable();
            SqlDataAdapter partAdapter = new SqlDataAdapter(partListQuery, dbConn);
            partAdapter.Fill(dt);
            dgvPartDetails.DataSource = dt;
        }

        public void executeQuery(String query)
        {
            try
            {
                dbConn.Open();
                dbCommand = new SqlCommand(query, dbConn);
                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    if (buttonClicked == true)
                    {
                        MessageBox.Show("New part is added");
                    }
                    else if (buttonClicked == false)
                    {
                        MessageBox.Show("Part is successfully updated");
                    }
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

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvPartDetails.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Confirm to delete part", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string selectedIndex = dgvPartDetails.CurrentRow.Cells[0].Value.ToString();
                    string deleteQuery = "DELETE FROM Part WHERE partId = '" + selectedIndex + "'";
                    executeQuery(deleteQuery);
                    displayPartList();
                    MessageBox.Show("Successfully delete part");
                    txtPartName.Text = "";
                    txtPrice.Text = "";
                }
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
                string insertQuery = "INSERT INTO Part(name, price, categoryId) VALUES ('" + txtPartName.Text + "'," + txtPrice.Text + "," 
                                        + cbbCategory.SelectedValue.ToString() + ")";
                executeQuery(insertQuery);
                displayPartList();
                txtPartName.Text = "";
                txtPrice.Text = "";

                txtPartName.Enabled = false;
                txtPrice.Enabled = false;
                btnSavePart.Enabled = false;
                btnCancelPart.Enabled = false;
                dgvPartDetails.Enabled = true;
                btnNewPart.Enabled = true;
                btnEditPart.Enabled = true;
                btnDeletePart.Enabled = true;
            }
            if (buttonClicked == false)
            {
                string selectedCategory = dgvPartDetails.CurrentRow.Cells[0].Value.ToString();
                string editQuery = "UPDATE Part SET name = '" + txtPartName.Text + "', price = " + txtPrice.Text + 
                                   " WHERE partId = '" + selectedCategory + "'";
                executeQuery(editQuery);
                displayPartList();
                txtPartName.Text = "";
                txtPrice.Text = "";
                txtPartName.Enabled = false;
                txtPrice.Enabled = false;
                btnSavePart.Enabled = false;
                btnCancelPart.Enabled = false;
                dgvPartDetails.Enabled = true;
                btnNewPart.Enabled = true;
                btnEditPart.Enabled = true;
                btnDeletePart.Enabled = true;
            }
        }

        private void btnManagePartsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}