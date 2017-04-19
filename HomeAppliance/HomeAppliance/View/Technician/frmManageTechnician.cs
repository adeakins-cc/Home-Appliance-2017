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

namespace HomeAppliance.View.Technician
{
    public partial class frmManageTechnician : Form
    {
        SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
        SqlCommand dbCommand = new SqlCommand();
        bool buttonClicked;

        public frmManageTechnician()
        {
            InitializeComponent();
        }

        private void frmManageTechnician_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.homeAppDBDataSet.Technician);
            displayTech();
        }

        //private void fillByTechnicianToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.technicianTableAdapter.FillByTechnician(this.homeAppDBDataSet.Technician);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}

        private void displayTech()
        {
            string getTechList = "SELECT * FROM Technician ORDER BY name ASC";
            DataTable dt = new DataTable();
            SqlDataAdapter techAdapter = new SqlDataAdapter(getTechList, dbConn);
            techAdapter.Fill(dt);
            dgvTechList.DataSource = dt;
            dgvTechList.Columns[0].Visible = false;
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
                        MessageBox.Show("New Technician is added");
                    }
                    else if (buttonClicked == false)
                    {
                        MessageBox.Show("Successfully delete technician");
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

        private void btnAddTech_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            string insertQuery = "INSERT INTO Technician(name) VALUES ('" + txtTechName.Text + "')";
            executeQuery(insertQuery);
            displayTech();
            txtTechName.Text = "";
        }

        private void btnEditTech_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            string selectedTech = dgvTechList.CurrentRow.Cells[0].Value.ToString();
            string editQuery = "UPDATE Technician SET name = '" + txtTechName.Text + "' WHERE technicianId = '" + selectedTech + "'";
            executeQuery(editQuery);
            displayTech();
            txtTechName.Text = "";
        }

        private void btnDeleteTech_Click(object sender, EventArgs e)
        {
            buttonClicked = false;
            if (dgvTechList.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Confirm to delete technician", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string selectedIndex = dgvTechList.CurrentRow.Cells[0].Value.ToString();
                    string deleteQuery = "DELETE FROM Technician WHERE technicianId = '" + selectedIndex + "'";
                    executeQuery(deleteQuery);
                    displayTech();
                    txtTechName.Text = "";
                }
            }
        }

        private void dgvTechList_MouseClick(object sender, MouseEventArgs e)
        {
            txtTechName.Text = dgvTechList.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
