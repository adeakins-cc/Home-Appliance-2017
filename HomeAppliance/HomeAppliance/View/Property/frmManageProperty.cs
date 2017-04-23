using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeAppliance.View.Property
{
    public partial class frmManageProperty : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
        SqlCommand dbCommand = new SqlCommand();
        bool addButtonClick;

        public frmManageProperty()
        {
            InitializeComponent();
        }

        private void frmManageProperty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet11.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.homeAppDBDataSet11.City);
            btnSaveNewProperty.Enabled = false;
            btnCancelP.Enabled = false;
            displayStreetName();
        }

        private DataTable propDT(string sql, SqlConnection conn)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        private void displayStreetName()
        {
            DataTable node = new DataTable();
            node = propDT("SELECT streetName FROM Property", dbConn);
            for (int i = 0; i < node.Rows.Count; i++)
            {
                tvStreetList.Nodes.Add(node.Rows[i][0].ToString());
            }
        }

        private DataTable createDT(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, dbConn);
            da.Fill(dt);
            return dt;
        }

        private void tvStreetList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode clickedNode = this.tvStreetList.SelectedNode;

            string propertyQuery = "SELECT propertyId, streetNumber, streetName, customerId FROM Property WHERE streetName = '" + tvStreetList.SelectedNode.Text + "'";
            dgvBuildings.DataSource = createDT(propertyQuery);
            dgvBuildings.Columns[3].Visible = false;
            dgvBuildings.Columns[0].Visible = false;
        }


        private void dgvBuildings_MouseClick(object sender, MouseEventArgs e)
        {
            int propID = int.Parse(dgvBuildings.CurrentRow.Cells[0].Value.ToString());

            dbCommand.Connection = dbConn;
            dbCommand.Connection.Close();
            dbCommand.Connection.Open();

            SqlDataReader readPropInfo;
            dbCommand.CommandText = "SELECT *, cus.firstName, cus.lastName FROM Property p JOIN Customer cus ON p.customerId = cus.customerId " +
                                    " JOIN City c ON p.cityId = c.cityId WHERE propertyId = " + propID;
            readPropInfo = dbCommand.ExecuteReader();
            readPropInfo.Read();

            txtBuildingNumber.Text = readPropInfo["streetNumber"].ToString();
            txtBuildingStreet.Text = readPropInfo["streetName"].ToString();
            txtUnits.Text = readPropInfo["unitNumber"].ToString();
            txtSuperintendent.Text = readPropInfo["superintendent"].ToString();
            txtSuperPhone.Text = readPropInfo["superintendentPhone"].ToString();
            txtCustID.Text = readPropInfo["customerId"].ToString();
            cbbCity.Text = readPropInfo["name"].ToString();

            dbCommand.CommandText = "SELECT * FROM Customer WHERE customerId = " + txtCustID.Text;
            readPropInfo.Close();
            readPropInfo = dbCommand.ExecuteReader();
            readPropInfo.Read();

           txtCustomer.Text = readPropInfo["firstName"].ToString() + ", " + readPropInfo["lastName"].ToString() + " (Company: " + readPropInfo["companyName"].ToString() + ")";
            txtAddress01.Text = readPropInfo["unitNumber01"].ToString() + " " + readPropInfo["streetNumber01"].ToString() + " " +
                readPropInfo["streetName_01"].ToString() + " " + readPropInfo["cityId_01"].ToString() + " " + readPropInfo["postalCode_01"].ToString();
            txtAddress02.Text = readPropInfo["unitNumber_02"].ToString() + " " + readPropInfo["streetNumber_02"].ToString() + " " +
                readPropInfo["streetName_02"].ToString() + " " + readPropInfo["cityId_02"].ToString() + " " + readPropInfo["postalCode_02"].ToString();

            dbCommand.Connection.Close();
        }

        private void clearFields()
        {
            txtBuildingNumber.Text = "";
            txtBuildingStreet.Text = "";
            cbbCity.Text = "";
            txtUnits.Text = "";
            txtSuperintendent.Text = "";
            txtSuperPhone.Text = "";
            txtCustomer.Text = "";
            txtAddress01.Text = "";
            txtAddress02.Text = "";
            txtCustID.Text = "";
        }

        private void executeQuery(String query)
        {
            try
            {
                dbConn.Open();
                dbCommand = new SqlCommand(query, dbConn);
                if (dbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New Property is added");
                  
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

        private void verifyField()
        {
            string errorMsg = "";
            if (txtBuildingNumber.Text == "" && txtBuildingStreet.Text == "")
            {
                errorMsg += "Street number and name is required";
            }
            if (cbbCity.Text == "")
            {
                errorMsg += "\nCity is required";
            }
            if (txtCustID.Text == "")
            {
                errorMsg += "\nCustomer ID is missing";
            }
            if (errorMsg != "")
            {
                MessageBox.Show(errorMsg);
            }
        }

        private void btnSaveNewProperty_Click(object sender, EventArgs e)
        {
            //verifyField();
            //string insertProp = "INSERT INTO Property(streetNumber, streetName, unitNumber, superintendent, superintendentPhone) VALUES('" +
            //       txtBuildingNumber.Text + "','" + txtBuildingStreet.Text + "','" + txtUnits.Text + "','" + txtSuperintendent + "','" + txtSuperPhone.Text + "')";
            //executeQuery(insertProp);
            //displayStreetName();
            //clearFields();
            if (addButtonClick == true)
            {
                // run insert new property
            }
            else if (addButtonClick == false)
            {
                // run update new property
                string selectedProperty = dgvBuildings.CurrentRow.Cells[0].Value.ToString();
                string updateProp = "UPDATE Property SET unitNumber = '" + txtUnits.Text + "', streetNumber = '" + txtBuildingNumber.Text + "', streetName = '" +
                                    txtBuildingStreet.Text + "', cityId = " + cbbCity.SelectedValue.ToString() + ", superintendent = '" + txtSuperintendent.Text +
                                    "', superintendentPhone = '" + txtSuperPhone.Text + "' WHERE propertyId = " + selectedProperty;
                executeQuery(updateProp);
                displayStreetName();
                clearFields();
            }


        }

        private void btnNewProperty_Click(object sender, EventArgs e)
        {
            tvStreetList.Enabled = false;
            dgvBuildings.Enabled = false;
            btnNewProperty.Enabled = false;
            btnUpdateProperty.Enabled = false;
            btnDeleteProperty.Enabled = false;
            btnSaveNewProperty.Enabled = true;
            btnCancelP.Enabled = true;
            GroupBox1.Enabled = true;
            txtCustID.ReadOnly = false;
            addButtonClick = true;

            clearFields();
        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {
            if (dgvBuildings.SelectedRows.Count > 0)
            {
                addButtonClick = false;
                GroupBox1.Enabled = true;
                btnNewProperty.Enabled = false;
                btnUpdateProperty.Enabled = false;
                btnDeleteProperty.Enabled = false;
                btnSaveNewProperty.Enabled = true;
                btnCancelP.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a property to update");
            }
            
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {

        }

        private void btnManagePropertyExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}