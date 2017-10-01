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
        bool buttonClicked;

        public frmManageCustomer()
        {
            InitializeComponent();
        }

        private void frmManageCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.homeAppDBDataSet.Customer);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.homeAppDBDataSet.City);
            // TODO: This line of code loads data into the 'homeAppDBDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.homeAppDBDataSet.Customer);

            getCustomerList();
            btnSaveCust.Enabled = false;
            btnCancelCust.Enabled = false;
            txtStreetNum01.Text = "";
        }

        private void getCustomerList()
        {
            dbConn.Open();
            tvCustomerList.Nodes.Clear();

            int nodeNumber = 0;
            int innerNodeCounter;

            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = dbConn;
            SqlDataReader reader;
            try
            {
                tvCustomerList.Nodes.Add(new TreeNode("Company"));
                dbCommand.CommandText = "SELECT customerId, companyName FROM Customer WHERE companyName != '' ORDER BY companyName ASC";
                reader = dbCommand.ExecuteReader();
                innerNodeCounter = 0;

                while (reader.Read())
                {
                    tvCustomerList.Nodes[nodeNumber].Nodes.Add(new TreeNode(reader["companyName"].ToString()));
                    tvCustomerList.Nodes[nodeNumber].Nodes[innerNodeCounter].Tag = reader["customerId"].ToString();
                    innerNodeCounter += 1;
                }

                dbCommand.Connection.Close();
                dbCommand.Connection.Open();

                nodeNumber += 1;

                tvCustomerList.Nodes.Add(new TreeNode("Customer"));
                dbCommand.CommandText = "SELECT customerId, firstName, lastName, c.name FROM Customer cus JOIN City c " +
                                        " ON cus.cityId_01 = c.cityId WHERE firstName != '' ORDER BY firstName ASC";
                reader = dbCommand.ExecuteReader();
                innerNodeCounter = 0;

                while (reader.Read())
                {
                    tvCustomerList.Nodes[nodeNumber].Nodes.Add(new TreeNode(reader["firstName"].ToString() + ", " + reader["lastName"].ToString()));
                    tvCustomerList.Nodes[nodeNumber].Nodes[innerNodeCounter].Tag = reader["customerId"].ToString();
                    innerNodeCounter += 1;
                }
                nodeNumber += 1;

                dbCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvCustomerList.SelectedNode.Tag != null)
            {
                displayInfo(tvCustomerList.SelectedNode.Tag.ToString());
            }
            else
            {
                tvCustomerList.SelectedNode.Expand();
            }
        }

        private void displayInfo(string custID)
        {
            try
            {
                SqlCommand dbCommand = new SqlCommand();
                dbCommand.Connection = dbConn;
                dbCommand.Connection.Close();
                dbCommand.Connection.Open();

                SqlDataReader infoReader;
                //dbCommand.CommandText = "SELECT * FROM Customer WHERE customerId = " + custID;
                dbCommand.CommandText = "SELECT *, c.name as 'City' FROM Customer cus JOIN City c on c.cityId = cus.cityId_01 WHERE customerId = " + custID;
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
                txtPostalCode01.Text = infoReader["postalCode_01"].ToString();
                txtPostalCode02.Text = infoReader["postalCode_02"].ToString();
                txtBussinessNumber.Text = infoReader["bussinessPhone"].ToString();
                txtPhone.Text = infoReader["homePhone"].ToString();
                txtFax.Text = infoReader["fax"].ToString();
                txtMobile.Text = infoReader["contactMobile"].ToString();
                txtContactName.Text = infoReader["contactName"].ToString();
                cobCityId01.Text = infoReader["name"].ToString();

                dbCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verifyInput()
        {
            string errMessage = "";
            if (txtCompanyName.Text == "")
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    errMessage += "\nFirst name and last name or company name is required";
                }
            }

            if (txtStreetNum01.Text == "" && txtStreetName01.Text == "")
            {
                errMessage += "\nStreet number and name are required";
            }

            if (errMessage != "")
            {
                MessageBox.Show(errMessage);
            }
        }

        private void executeQuery(String query)
        {
            try
            {
                dbConn.Open();
                SqlCommand dbCommand = new SqlCommand(query, dbConn);
                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    if (buttonClicked == true)
                    {
                        MessageBox.Show("New Customer is added");
                    }
                    else if (buttonClicked == false)
                    {
                        MessageBox.Show("Successfully delete customer");
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

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            verifyInput();

            SqlCommand checkInput = new SqlCommand("SELECT * FROM Customer WHERE ([firstName] = @firstName) OR ([lastName] = @lastName) OR ([companyName] = @companyName) ", dbConn);
            checkInput.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            checkInput.Parameters.AddWithValue("@lastName", txtLastName.Text);
            checkInput.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
            checkInput.Connection.Open();

            SqlDataReader reader = checkInput.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show(txtFirstName.Text + ", " + txtLastName.Text + " already exists");
            }
            else
            {
                string insertCust = "INSERT INTO Customer(firstName,lastName,companyName,unitNumber01,streetNumber01,streetName_01, cityId_01, postalCode_01," +
                                "unitNumber_02,streetNumber_02,streetName_02,cityId_02,postalCode_02,bussinessPhone,homePhone,fax,contactMobile,contactName) " +
                                "VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtCompanyName.Text + "','" + txtUnitNum01.Text + "','"
                                + txtStreetNum01.Text + "','" + txtStreetName01.Text + "','" + cobCityId01.SelectedValue.ToString() + "','" + txtPostalCode01.Text +
                                "','" + txtUnitNum02.Text + "','" + txtStreetNum02.Text + "','" + txtStreetName02 + "','" + cobCityId01.SelectedValue.ToString() +
                                "','" + txtPostalCode02.Text + "','" + txtBussinessNumber.Text + "','" + txtPhone.Text + "','" + txtFax.Text + "','" + txtMobile.Text + "','"
                                + txtContactName.Text + "')";
                executeQuery(insertCust);
                getCustomerList();
                clearField();
            }
            checkInput.Connection.Close();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Enabled = false;
            btnSearch.Enabled = false;
            tvCustomerList.Enabled = false;
            btnNewCustomer.Enabled = false;
            btnUpdateCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnSaveCust.Enabled = true;
            btnCancelCust.Enabled = true;
            buttonClicked = true;

            lblCustomerID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCompanyName.Text = "";
            txtUnitNum01.Text = "";
            txtUnitNum02.Text = "";
            txtStreetNum01.Text = "";
            txtStreetNum02.Text = "";
            txtStreetName01.Text = "";
            txtStreetName02.Text = "";
            txtPostalCode01.Text = "";
            txtPostalCode02.Text = "";
            txtContactName.Text = "";
            txtPhone.Text = "";
            txtMobile.Text = "";
            txtBussinessNumber.Text = "";
            txtOtherNumber.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            string selectedCustId = tvCustomerList.SelectedNode.Tag.ToString();
            string updateCust = "UPDATE Customer SET firstName = '" + txtFirstName.Text + "', lastName = '" + txtLastName.Text + "', companyName = '"
                                + txtCompanyName.Text + "', unitNumber01 = '" + txtUnitNum01.Text + "', streetNumber01 = '" + txtStreetNum01.Text
                                + "', streetName_01 = '" + txtStreetName01.Text + "', cityId_01 = '" + cobCityId01.SelectedValue.ToString() + "', postalCode_01 = '"
                                + txtPostalCode01.Text + "', unitNumber_02 = '" + txtUnitNum02.Text + "', streetNumber_02 = '" + txtStreetNum02.Text
                                + "', streetName_02 = '" + txtStreetName02.Text + "', cityId_02 = '" + cobCityId02.SelectedValue.ToString() + "', postalCode_02 = '"
                                + txtPostalCode02.Text + "', bussinessPhone = '" + txtBussinessNumber.Text + "', homePhone = '" + txtPhone.Text + "', fax = '"
                                + txtFax.Text + "', contactMobile = '" + txtMobile.Text + "', contactName = '" + txtContactName.Text
                                + "' WHERE customerId = '" + selectedCustId + "'";
            executeQuery(updateCust);
            getCustomerList();
            clearField();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            buttonClicked = false;

            if (MessageBox.Show("Confirm to delete customer", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string selectedCustId = tvCustomerList.SelectedNode.Tag.ToString();
                string deleteCust = "DELETE FROM Customer WHERE customerId = '" + selectedCustId + "'";
                executeQuery(deleteCust);
                getCustomerList();
                clearField();
            }
        }

        private void clearField()
        {
            lblCustomerID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCompanyName.Text = "";
            txtUnitNum01.Text = "";
            txtStreetNum01.Text = "";
            txtStreetName01.Text = "";
            txtPostalCode01.Text = "";
            txtBussinessNumber.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
            txtMobile.Text = "";
            txtContactName.Text = "";

            txtSearchCustomer.Enabled = true;
            btnSearch.Enabled = true;
            tvCustomerList.Enabled = true;
            btnNewCustomer.Enabled = true;
            btnUpdateCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            btnSaveCust.Enabled = false;
            btnCancelCust.Enabled = false;
        }

        private DataTable custDT(string sql, SqlConnection conn)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}