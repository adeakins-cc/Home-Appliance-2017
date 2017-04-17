﻿using System;
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

            int nodeNumber = 0;
            int innerNodeCounter;

            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = dbConn;
            SqlDataReader reader;
            try
            {
                treeView1.Nodes.Add(new TreeNode("Company"));
                dbCommand.CommandText = "SELECT customerId, companyName FROM Customer WHERE companyName != '' ORDER BY companyName ASC";
                reader = dbCommand.ExecuteReader();
                innerNodeCounter = 0;
                
                while (reader.Read())
                {
                    treeView1.Nodes[nodeNumber].Nodes.Add(new TreeNode(reader["companyName"].ToString()));
                    treeView1.Nodes[nodeNumber].Nodes[innerNodeCounter].Tag = reader["customerId"].ToString();
                    innerNodeCounter += 1;
                }

                dbCommand.Connection.Close();
                dbCommand.Connection.Open();

                nodeNumber += 1;

                treeView1.Nodes.Add(new TreeNode("Customer"));
                dbCommand.CommandText = "SELECT customerId, firstName, lastName FROM Customer WHERE firstName != '' ORDER BY firstName ASC";
                reader = dbCommand.ExecuteReader();
                innerNodeCounter = 0;

                while (reader.Read())
                {
                    treeView1.Nodes[nodeNumber].Nodes.Add(new TreeNode(reader["firstName"].ToString() + ", " + reader["lastName"].ToString()));
                    treeView1.Nodes[nodeNumber].Nodes[innerNodeCounter].Tag = reader["customerId"].ToString();
                    innerNodeCounter += 1;
                }
                nodeNumber += 1;

                dbCommand.Connection.Close();
                dbCommand.Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                txtPostalCode01.Text = infoReader["postalCode_01"].ToString();
                txtPostalCode02.Text = infoReader["postalCode_02"].ToString();
                txtBussinessNumber.Text = infoReader["bussinessPhone"].ToString();
                txtPhone.Text = infoReader["homePhone"].ToString();
                txtFax.Text = infoReader["fax"].ToString();
                txtMobile.Text = infoReader["contactMobile"].ToString();
                txtContactName.Text = infoReader["contactName"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            displayInfo(treeView1.SelectedNode.Tag.ToString());
        }


        private void verifyInput()
        {
            if (txtCompanyName.Text == "")
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    MessageBox.Show("First name and last name or company name is required");
                }
            }

            if (txtStreetNum01.Text == "" && txtStreetName01.Text == "" )
            {
                MessageBox.Show("Street number and name are required");
            }

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone number is required");
            }
        }
    }
}