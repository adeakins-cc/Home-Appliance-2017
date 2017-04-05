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
        private string customerComplaints;
        private string notes;
        private decimal serviceCharge;
        private decimal labour;
        private decimal subTotal;
        private decimal partTotal;
        private byte chargeHST;
        private decimal HST;
        private decimal grossTotal;
        private string make;
        private string model;
        private string serialNumber;
        private string PONumber;

        public Invoice()
        {
            invoiceID = 0;
            serviceDate = DateTime.Now;
            invoiceDate = DateTime.Now;
            customer = new Customer();
            property = new Property();
            technician = new Technician();
            customerComplaints = "";
            notes = "";
            serviceCharge = 0;
            labour = 0;
            partTotal = 0;
            subTotal = 0;
            chargeHST = 0;
            HST = 0;
            grossTotal = 0;
        }

        public void setInvoiceID(int invoiceID)
        {
            this.invoiceID = invoiceID;
        }
        public int getInvoiceID()
        {
            return invoiceID;
        }

        public void setServiceDate(DateTime serviceDate)
        {
            this.serviceDate = serviceDate;
        }
        public DateTime getServiceDate()
        {
            return serviceDate;
        }

        public void setInvoiceDate(DateTime invoiceDate)
        {
            this.invoiceDate = invoiceDate;
        }
        public DateTime getInvoiceDate()
        {
            return invoiceDate;
        }

        public void setCustomer(Customer customer)
        {
            this.customer = customer;
        }
        public Customer getCustomer()
        {
            return customer;
        }

        public void setProperty(Property property)
        {
            this.property = property;
        }
        public Property getProperty()
        {
            return property;
        }

        public void setTechnician(Technician technician)
        {
            this.technician = technician;
        }
        public Technician getTechnician()
        {
            return technician;
        }

        public void setCustomerComplaints(string customerComplaints)
        {
            this.customerComplaints = customerComplaints;
        }
        public string getCustomerComplaints()
        {
            return customerComplaints;
        }

        public void setNotes(string notes)
        {
            this.notes = notes;
        }
        public string getNotes()
        {
            return notes;
        }

        public void setServiceCharge(decimal serviceCharge)
        {
            this.serviceCharge = serviceCharge;
        }
        public decimal getServiceCharge()
        {
            return serviceCharge;
        }

        public void setLabour(decimal labour)
        {
            this.labour = labour;
        }
        public decimal getLabour()
        {
            return labour;
        }

        public void setPartTotal(decimal partTotal)
        {
            this.partTotal = partTotal;
        }
        public decimal getPartTotal()
        {
            return partTotal;
        }

        public void setSubTotal(decimal subTotal)
        {
            this.subTotal = subTotal;
        }
        public decimal getSubTotal()
        {
            return subTotal;
        }

        public void setChargeHST(byte chargeHST)
        {
            this.chargeHST = chargeHST;
        }
        public byte getChargeHST()
        {
            return chargeHST;
        }

        public void setHST(decimal HST)
        {
            this.HST = HST;
        }
        public decimal getHST()
        {
            return HST;
        }

        public void setGrossTotal(decimal grossTotal)
        {
            this.grossTotal = grossTotal;
        }
        public decimal getGrossTotal()
        {
            return grossTotal;
        }

        public void setMake(string make)
        {
            this.make = make;
        }
        public string getMake()
        {
            return customerComplaints;
        }

        public void setModel(string model)
        {
            this.model = model;
        }
        public string getModel()
        {
            return model;
        }

        public void setSerialNumber(string serialNumber)
        {
            this.serialNumber = serialNumber;
        }
        public string getSerialNumber()
        {
            return serialNumber;
        }

        public void setPONumber(string PONumber)
        {
            this.PONumber = PONumber;
        }
        public string getPONumber()
        {
            return PONumber;
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
        List<PartList> getPartList()
        {
            List<PartList> partList = new List<PartList>();
            return partList;
        }

    }
}
