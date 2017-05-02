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
using CrystalDecisions.CrystalReports.Engine;
using HomeAppliance.Reports;
using static HomeAppliance.HomeAppDBDataSet;

namespace HomeAppliance.View.Invoice
{
    public partial class frmViewInvoice : Form
    {
        public frmViewInvoice()
        {
            InitializeComponent();
        }

        private void frmViewInvoice_Load(object sender, EventArgs e)
        {
            InvoiceReporting rpt;
            // Creating object of our report.
            rpt = new InvoiceReporting();

            SqlConnection dbConn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=HomeAppDB;Integrated Security=True");
            SqlCommand dbCommand = new SqlCommand();

            string partListQuery = "SELECT Invoice.invoiceId, Invoice.serviceDate, Invoice.invoiceDate, Invoice.complaints, Invoice.notes, Invoice.partTotal, Invoice.labour, Invoice.serviceCharge, Invoice.GST, Invoice.PST, Invoice.subTotal, " +
                         "Invoice.grossTotal, Invoice.PSTExempt, Invoice.poNumber, Invoice.make, Invoice.model, Invoice.serialNumber, Technician.name AS techName, Customer.firstName, Customer.lastName, Customer.companyName, " +
                         "Customer.unitNumber01 AS customerUnitNumber, Customer.streetNumber01 AS customerStreetNumber, Customer.streetName_01 AS customerStreetName, Customer.postalCode_01 AS customerPostalCode, CustCity.name AS customerCity, " +
                         "CustCity.province AS customerProvince, CustCity.counrty AS customerCountry, Customer.bussinessPhone, Customer.homePhone, " +
                         "Customer.fax, Customer.contactMobile, Customer.contactName, Customer.contactEmail, Property.unitNumber AS propertyUnitNumber, Property.streetNumber AS propertyStreetnumber, Property.streetName AS propertyStreetName " +
                         ", PropCity.name AS propertyCity, PropCity.province AS propertyProvince, PropCity.counrty AS propertyCountry, Property.superintendent, Property.superintendentPhone " +
                         "FROM Invoice INNER JOIN " +
                         "Customer ON Invoice.customerId = Customer.customerId INNER JOIN " +
                         "City AS CustCity ON Customer.cityId_01 = CustCity.cityId INNER JOIN " +
                         "Property ON Invoice.propertyId = Property.propertyId INNER JOIN " +
                         "City AS PropCity ON Property.cityId = PropCity.cityId INNER JOIN " +
                         "Technician ON Invoice.technicianId = Technician.technicianId;";

                          /*"FROM City AS CustCity INNER JOIN " +
                         "Customer ON CustCity.cityId = Customer.cityId_01 INNER JOIN " +
                         "Invoice ON Customer.customerId = Invoice.customerId INNER JOIN " +
                         "Property ON Invoice.propertyId = Property.propertyId INNER JOIN " +
                         "Technician ON Invoice.technicianId = Technician.technicianId INNER JOIN " +
                         "City AS PropCity ON Property.cityId = PropCity.cityId;";*/
            DataTable dt = new DataTable();
            SqlDataAdapter partAdapter = new SqlDataAdapter(partListQuery, dbConn);
            partAdapter.Fill(dt);
            rpt.SetDataSource(dt);

            // Binding the crystalReportViewer with our report object. 
            cryRepo.ReportSource = rpt;
        }

        private void cryRepo_Load(object sender, EventArgs e)
        {
                
        }
    }
}
