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

        public void setServiceCharge(decimal serviceCharge)
        {
            this.serviceCharge = serviceCharge;
        }
        public decimal getServiceCharge()
        {
            return serviceCharge;
        }

        public void setPartTotal(decimal partTotal)
        {
            this.partTotal = partTotal;
        }
        public decimal getPartTotal()
        {
            return partTotal;
        }

        public void setChargeGST(byte chargeGST)
        {
            this.chargeGST = chargeGST;
        }
        public byte getChargeGST()
        {
            return chargeGST;
        }

        public void setGST(decimal GST)
        {
            this.GST = GST;
        }
        public decimal getGST()
        {
            return GST;
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
        List<PartsUsed> getPartList()
        {
            List<PartsUsed> partList = new List<PartsUsed>();
            return partList;
        }

    }
}
