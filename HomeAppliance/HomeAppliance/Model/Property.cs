using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class Property
    {
        //fields
        private int     propertyID;
        private Customer customer;
        private int     unitNumber;
        private int     streetNumber;
        private string  streetName;
        private string  city;
        private string  province;
        private string  country;
        private string  postalCode;

        public Property()
        {
            propertyID      = 0;
            customer        = new Customer();
            unitNumber      = 0;
            streetNumber    = 0;
            streetName      = "";
            city            = "";
            province        = "";
            country         = "";
            postalCode      = "";
        }

        public void setPropertyID(int propertyID)
        {
            this.propertyID = propertyID; 
        }
        public int getPropertyID()
        {
            return propertyID;
        }

        public void setCustomer(Customer customer)
        {
            this.customer = customer;
        }
        public Customer getCustomer()
        {
            return customer;
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

        public void setStreetNumber(string streetName)
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
    }
}
