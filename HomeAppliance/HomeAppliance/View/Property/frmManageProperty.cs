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
            //using (dbConn)
            //{
            //    string propertyQuery = "SELECT * FROM Property";
            //    string customerQuery = "SELECT * FROM Customer";
            //    string fullQuery = propertyQuery + ";" + customerQuery;

            //    DataSet dsFullDataQuery = new DataSet();
            //    SqlDataAdapter da = new SqlDataAdapter(fullQuery, dbConn);
            //    da.Fill(dsFullDataQuery);

            //    dsFullDataQuery.Tables[0].TableName = "Property";
            //    dsFullDataQuery.Tables[1].TableName = "Customer";

            //    DataRelation Customer_Property = new DataRelation("custProperty", dsFullDataQuery.Tables["Customer"].Columns["customerId"],
            //                                                dsFullDataQuery.Tables["Property"].Columns["customerId"]);

            //    TreeNode streetNameNode = new TreeNode("Street Name");
            //    foreach (DataRow streetNameDT in dsFullDataQuery.Tables["Property"].Rows)
            //    {

            //        streetNameNode.Nodes.Add(streetNameDT["streetName"].ToString());
            //    }

            //    tvStreetList.Nodes.Add(streetNameNode);
            //}
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
            dbCommand.CommandText = "SELECT * FROM Property WHERE propertyId = " + propID;
            readPropInfo = dbCommand.ExecuteReader();
            readPropInfo.Read();

            txtBuildingNumber.Text = readPropInfo["streetNumber"].ToString();
            txtBuildingStreet.Text = readPropInfo["streetName"].ToString();
            //city
            txtUnits.Text = readPropInfo["unitNumber"].ToString();
            txtSuperintendent.Text = readPropInfo["superintendent"].ToString();
            txtSuperPhone.Text = readPropInfo["superintendentPhone"].ToString();

            dbCommand.Connection.Close();
        }
    }
}