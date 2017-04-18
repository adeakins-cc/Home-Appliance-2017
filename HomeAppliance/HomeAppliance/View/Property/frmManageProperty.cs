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
    public partial class dgvStreetBuildings : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
        SqlCommand dbCommand = new SqlCommand();

        public dgvStreetBuildings()
        {
            InitializeComponent();
        }

        private void frmManageProperty_Load(object sender, EventArgs e)
        {
            display();
        }

        private DataTable propDT(string sql, SqlConnection conn)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        private void display()
        {
            dbConn.Open();
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
        }

        private void dgvBuildings_MouseClick(object sender, MouseEventArgs e)
        {
            int propID = int.Parse(dgvBuildings.CurrentRow.Cells[0].Value.ToString());

            dbCommand.Connection = dbConn;
            dbCommand.Connection.Close();
            dbCommand.Connection.Open();

            SqlDataReader readPropInfo;
            dbCommand.CommandText = "SELECT *, cus.firstName, cus.lastName FROM Property p JOIN Customer cus ON p.customerId = cus.customerId "+
                                    " WHERE propertyId = " + propID;
            readPropInfo = dbCommand.ExecuteReader();
            readPropInfo.Read();

            txtBuildingNumber.Text = readPropInfo["streetNumber"].ToString();
            txtBuildingStreet.Text = readPropInfo["streetName"].ToString();
            txtUnits.Text = readPropInfo["unitNumber"].ToString();
            txtSuperintendent.Text = readPropInfo["superintendent"].ToString();
            txtSuperPhone.Text = readPropInfo["superintendentPhone"].ToString();
            lblCustID.Text = readPropInfo["customerId"].ToString();

            dbCommand.CommandText = "SELECT name FROM City WHERE cityId = " + readPropInfo["cityId"].ToString();
            readPropInfo.Close();
            readPropInfo = dbCommand.ExecuteReader();
            readPropInfo.Read();

            txtCity.Text = readPropInfo["name"].ToString();

            dbCommand.CommandText = "SELECT * FROM Customer WHERE customerId = " + lblCustID.Text;
            readPropInfo.Close();
            readPropInfo = dbCommand.ExecuteReader();
            readPropInfo.Read();

            txtCustomer.Text = readPropInfo["firstName"].ToString() + ", " + readPropInfo["lastName"].ToString() + " (Company: " + readPropInfo["companyName"].ToString()+")";
            txtAddress01.Text = readPropInfo["unitNumber01"].ToString() + " " + readPropInfo["streetNumber01"].ToString() + " " +
                readPropInfo["streetName_01"].ToString() + " " + readPropInfo["cityId_01"].ToString() + " " + readPropInfo["postalCode_01"].ToString();
            txtAddress02.Text = readPropInfo["unitNumber_02"].ToString() + " " + readPropInfo["streetNumber_02"].ToString() + " " +
                readPropInfo["streetName_02"].ToString() + " " + readPropInfo["cityId_02"].ToString() + " " + readPropInfo["postalCode_02"].ToString();
            
            dbCommand.Connection.Close();
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
            txtCustomer.ReadOnly = false;
            txtAddress01.ReadOnly = false;
            txtAddress02.ReadOnly = false;

            clearFields();
        }

        private void clearFields()
        {
            txtBuildingNumber.Text = "";
            txtBuildingStreet.Text = "";
            txtCity.Text = "";
            txtUnits.Text = "";
            txtSuperintendent.Text = "";
            txtSuperPhone.Text = "";
            txtCustomer.Text = "";
            txtAddress01.Text = "";
            txtAddress02.Text = "";
        }

        private void btnManagePropertyExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}