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
    public partial class frmManageCategories : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
        SqlCommand dbCommand = new SqlCommand();
        bool buttonClicked;

        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            displayCategory();
        }

        private void displayCategory()
        {
            string getCategoryQuery = "SELECT * FROM Category ORDER BY name ASC";
            DataTable dt = new DataTable();
            SqlDataAdapter cateAdapter = new SqlDataAdapter(getCategoryQuery, dbConn);
            cateAdapter.Fill(dt);
            dgvCategory.DataSource = dt;
        }

        private void executeQuery(String query)
        {
            try
            {
                dbConn.Open();
                dbCommand = new SqlCommand(query, dbConn);
                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    if (buttonClicked == true)
                    {
                        MessageBox.Show("New Category is added");
                    }
                    else if (buttonClicked == false)
                    {
                        MessageBox.Show("Successfully delete category");
                    }
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

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            string insertQuery = "INSERT INTO Category(name) VALUES ('" + txtName.Text + "')";
            executeQuery(insertQuery);
            displayCategory();
            txtName.Text = "";
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string selectedCategory = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            string editQuery = "UPDATE Category SET name = '" + txtName.Text + "' WHERE categoryId = '" + selectedCategory + "'";
            executeQuery(editQuery);
            displayCategory();
            txtName.Text = "";
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            buttonClicked = false;
            if (dgvCategory.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Confirm to delete category", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string selectedIndex = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                    string deleteQuery = "DELETE FROM Category WHERE categoryId = '" + selectedIndex + "'";
                    executeQuery(deleteQuery);
                    displayCategory();
                    txtName.Text = "";
                }
            }
        }

        private void dgvCategory_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnManageCategoriesExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}