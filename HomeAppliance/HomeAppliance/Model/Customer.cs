using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class Customer
    {
        private int customerID;
        private string companyName;
        private string firstName;
        private string lastName;
        private string contactName;
        private int contactPhone;
        private int contactMobile;
        private int fax;
        private int bussinessPhone;
        private string contactEmail;
        private int unitNumber;
        private int streetNumber;
        private string streetName;
        private string city;
        private string province;
        private string country;
        private string postalCode;

        public Customer()
        {
            customerID      = 0;
            companyName     = "";
            firstName       = "";
            lastName        = "";
            contactName     = "";
            contactPhone    = 0;
            contactMobile   = 0;
            fax             = 0;
            bussinessPhone  = 0;
            contactEmail    = "";
            unitNumber      = 0;
            streetNumber    = 0;
            streetName      = "";
            city            = "";
            province        = "";
            country         = "";
            postalCode      = "";
        }

        public void setCustomerID(int customerID)
        {
            this.customerID = customerID;
        }
        public int getCustomerID()
        {
            return customerID;
        }

        public void setCompanyName(string companyName)
        {
            this.companyName = companyName;
        }
        public string getCompanyName()
        {
            return companyName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getFirstName()
        {
            return firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string getLastName()
        {
            return lastName;
        }

        public void setContactName(string contactName)
        {
            this.contactName = contactName;
        }
        public string getContactName()
        {
            return contactName;
        }

        public void setContactPhone(int contactPhone)
        {
            this.contactPhone = contactPhone;
        }
        public int getContactPhone()
        {
            return contactPhone;
        }

        public void setContactMobile(int contactMobile)
        {
            this.contactMobile = contactMobile;
        }
        public int getContactMobile()
        {
            return contactMobile;
        }

        public void setFax(int fax)
        {
            this.fax = fax;
        }
        public int getFax()
        {
            return fax;
        }

        public void setBussinessPhone(int bussinessPhone)
        {
            this.bussinessPhone = bussinessPhone;
        }
        public int getBussinessPhone()
        {
            return bussinessPhone;
        }

        public void setContactEmail(string contactEmail)
        {
            this.contactEmail = contactEmail;
        }
        public string getContactEmail()
        {
            return contactEmail;
        }

        public void setUnitNumber(int unitNumber)
        {
            this.unitNumber = unitNumber;
        }
        public int getUnitNumber()
        {
            return unitNumber;
        }

        public void setStreetNumber(int streetNumber)
        {
            this.streetNumber = streetNumber;
        }
        public int getStreetNumber()
        {
            return streetNumber;
        }

        public void setStreetName(string streetName)
        {
            this.streetName = streetName;
        }
        public string getStreetName()
        {
            return streetName;
        }

        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return city;
        }

        public void setProvince(string province)
        {
            this.province = province;
        }
        public string getProvince()
        {
            return province;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }
        public string getCountry()
        {
            return country;
        }

        public void setPostalCode(string postalCode)
        {
            this.postalCode = postalCode;
        }
        public string getPostalCode()
        {
            return postalCode;
        }
        List<Property> getPropertyList()
        {
            List<Property> propertyList = new List<Property>();
            return propertyList;
        }
    }
}
