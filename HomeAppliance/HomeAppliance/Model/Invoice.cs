using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class Invoice
    {
        private int invoiceID;
        private DateTime serviceDate;
        private DateTime invoiceDate;
        private Customer customer;
        private Property property;
        private Technician technician;
        private decimal serviceCharge;
        private decimal partTotal;
        private byte chargeGST;
        private decimal GST;
        private byte chargeHST;
        private decimal HST;
        private decimal grossTotal;


        public Invoice()
        {
            invoiceID = 0;
            serviceDate = DateTime.Now;
            invoiceDate = DateTime.Now;
            customer = new Customer();
            property = new Property();
            technician = new Technician();
            serviceCharge = 0;
            partTotal = 0;
            chargeGST = 0;
            GST = 0;
            chargeHST = 0;
            HST = 0;
            grossTotal = 0;
        }









        List<Customer> getCustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            return customerList;
        }
        List<Property> getPropertyList()
        {
            List<Property> propertyList = new List<Property>();
            return propertyList;
        }
        List<Technician> getTechnicianSList()
        {
            List<Technician> technicianList = new List<Technician>();
            return technicianList;
        }

    }
}
