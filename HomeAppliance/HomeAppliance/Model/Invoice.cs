using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    public class Invoice
    {
        private int invoiceID;
        private Customer customer;
        private Property property;
        private DateTime serviceDate;
        private DateTime invoiceDate;
        private Technician technician;
        private string customerComplaints;
        private string notes;
        private decimal partTotal;
        private decimal labour;
        private decimal serviceCharge;
        private decimal GST;
        private decimal PST;
        private decimal subTotal;
        private decimal grossTotal;
        private string PONumber;
        private string make;
        private string model;
        private string serialNumber;
        private Boolean chargeTax;
        

        public Invoice()
        {
            invoiceID = 0;
            customer = new Customer();
            property = new Property();
            serviceDate = DateTime.Now;
            invoiceDate = DateTime.Now;
            technician = new Technician();
            customerComplaints = "";
            notes = "";
            partTotal = 0;
            labour = 0;
            serviceCharge = 0;
            GST = 0;
            PST = 0;
            subTotal = 0;
            grossTotal = 0;
            PONumber = "";
            make = "";
            model = "";
            serialNumber = "";
        }

        public void setInvoiceID(int invoiceID)
        {
            this.invoiceID = invoiceID;
        }
        public int getInvoiceID()
        {
            return invoiceID;
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

        public void setPartTotal(decimal partTotal)
        {
            this.partTotal = partTotal;
        }
        public decimal getPartTotal()
        {
            return partTotal;
        }

        public void setLabour(decimal labour)
        {
            this.labour = labour;
        }
        public decimal getLabour()
        {
            return labour;
        }

        public void setServiceCharge(decimal serviceCharge)
        {
            this.serviceCharge = serviceCharge;
        }
        public decimal getServiceCharge()
        {
            return serviceCharge;
        }

        public void setGST(decimal GST)
        {
            this.GST = GST;
        }
        public decimal getGST()
        {
            return GST;
        }

        public void setPST(decimal PST)
        {
            this.PST = PST;
        }
        public decimal getPST()
        {
            return PST;
        }

        public void setSubTotal(decimal subTotal)
        {
            this.subTotal = subTotal;
        }
        public decimal getSubTotal()
        {
            return subTotal;
        }  

        public void setGrossTotal(decimal grossTotal)
        {
            this.grossTotal = grossTotal;
        }
        public decimal getGrossTotal()
        {
            return grossTotal;
        }

        public void setPONumber(string PONumber)
        {
            this.PONumber = PONumber;
        }
        public string getPONumber()
        {
            return PONumber;
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

        public void setChargeTax(Boolean chargeTax)
        {
            this.chargeTax = chargeTax;
        }
        public Boolean getChargeTax()
        {
            return chargeTax;
        }
    }
}
