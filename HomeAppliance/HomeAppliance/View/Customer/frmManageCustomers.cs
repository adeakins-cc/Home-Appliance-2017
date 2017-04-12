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
    public partial class frmManageCustomer : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");

        public frmManageCustomer()
        {
            InitializeComponent();
        }

        private void frmManageCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.homeAppDBDataSet1.Customer);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.homeAppDBDataSet.City);

            getCustomerList();
        }

        private void getCustomerList()
        {
            dbConn.Open();
            treeView1.Nodes.Clear();

            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = dbConn;
            SqlDataReader reader;
            try
            {
                dbCommand.CommandText = "SELECT customerId, companyName FROM Customer WHERE companyName != '' ORDER BY companyName ASC";
                reader = dbCommand.ExecuteReader();
                TreeNode companyNode = new TreeNode("Company");
                while (reader.Read())
                {
                    companyNode.Nodes.Add(reader["companyName"].ToString());
                }
                treeView1.Nodes.Add(companyNode);

                dbCommand.Connection.Close();
                dbCommand.Connection.Open();

                dbCommand.CommandText = "SELECT customerId, firstName, lastName FROM Customer WHERE firstName != '' ORDER BY firstName ASC";
                reader = dbCommand.ExecuteReader();
                TreeNode customerNode = new TreeNode("Customer");
                while (reader.Read())
                {
                    customerNode.Nodes.Add(reader["firstName"].ToString() + ", " + reader["lastName"].ToString());
                }
                treeView1.Nodes.Add(customerNode);
                
                dbCommand.Connection.Close();
                dbCommand.Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayInfo(int custID)
        {
            try
            {
                SqlCommand dbCommand = new SqlCommand();
                dbCommand.Connection = dbConn;
                dbCommand.Connection.Close();
                dbCommand.Connection.Open();

                SqlDataReader infoReader;
                dbCommand.CommandText = "SELECT * FROM Customer WHERE customerId = " + custID;
                infoReader = dbCommand.ExecuteReader();
                infoReader.Read();

                lblCustomerID.Text = infoReader["customerId"].ToString();
                txtFirstName.Text = infoReader["firstName"].ToString();
                txtLastName.Text = infoReader["lastName"].ToString();
                txtCompanyName.Text = infoReader["companyName"].ToString();
                txtUnitNum01.Text = infoReader["unitNumber01"].ToString();
                txtUnitNum02.Text = infoReader["unitNumber_02"].ToString();
                txtStreetNum01.Text = infoReader["streetNumber01"].ToString();
                txtStreetNum02.Text = infoReader["streetNumber_02"].ToString();
                txtStreetName01.Text = infoReader["streetName_01"].ToString();
                txtStreetName02.Text = infoReader["streetName_02"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
