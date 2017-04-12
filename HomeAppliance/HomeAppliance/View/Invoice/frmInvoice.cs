using HomeAppliance.View.Invoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAppliance
{
    public partial class frmNewInvoice : Form
    {
        // Table name constants
        private const String CATEGORIES_TABLE = "Invoice";

        // Field name constants
        private const String CATEGORYID_FIELD = "invoiceId";
        private const String CATEGORYNAME_FIELD = "CategoryName";
        private const String DESCRIPTION_FIELD = "Description";

        private DataTable dt;
        DataColumn column = new DataColumn();
        DataTable table = new DataTable("Invoice");
        public frmNewInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // Create the Categories table.
            dt = new DataTable(CATEGORIES_TABLE);

            // Add the identity column.
            DataColumn col = dt.Columns.Add(CATEGORYID_FIELD,
                typeof(System.Int32));
            col.AllowDBNull = false;
            col.AutoIncrement = true;
            col.AutoIncrementSeed = -1;
            col.AutoIncrementStep = -1;
            // Set the primary key.
            dt.PrimaryKey = new DataColumn[] { col };

            // Add the other columns.
            col = dt.Columns.Add(CATEGORYNAME_FIELD, typeof(System.String));
            col.AllowDBNull = false;
            col.MaxLength = 15;
            dt.Columns.Add(DESCRIPTION_FIELD, typeof(System.String));

            // Fill the table.
            // TODO: This line of code loads data into the 'homeAppDBDataSet.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.homeAppDBDataSet.Technician);
            // TODO: This line of code loads data into the 'homeAppDBDataSet.PartsList' table. You can move, or remove it, as needed.
            this.partsListTableAdapter.Fill(this.homeAppDBDataSet.PartsList);

            // Bind the default view for the table to the grid.
            //frmNewInvoice.DataSource = dt.DefaultView;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            // Add a new row.
            /*DataRow row = dt.NewRow();
            row[CATEGORYNAME_FIELD] = categoryNameTextBox.Text;
            row[DESCRIPTION_FIELD] = descriptionTextBox.Text;
            dt.Rows.Add(row);*/
        }

        private void btnSearchCustomerProperty_Click(object sender, EventArgs e)
        {
            frmManageProperty selectPropertyCustomer = new frmManageProperty();
            selectPropertyCustomer.ShowDialog();
        }

        private void btnNewInvoiceExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            frmAddPart newPart = new frmAddPart();
            newPart.ShowDialog();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            // Add the column to a new DataTable.
            table.Columns.Add(column);
        }

        private void newRow()
        {
            column.DataType          = System.Type.GetType("System.Int32");
            column.AutoIncrement     = true;
            column.AutoIncrementSeed = 1000;
            column.AutoIncrementStep = 10;
        }

        private void invoiceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
