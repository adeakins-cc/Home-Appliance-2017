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
                    MessageBox.Show("New Category is added");
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

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            // need to drop and re-create DB tables due to auto-increment primary key
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


    }
}
