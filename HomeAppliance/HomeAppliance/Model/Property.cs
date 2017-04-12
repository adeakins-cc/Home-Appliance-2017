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
        private int      propertyID;
        private Customer customer;
        private string   unitNumber;
        private string   streetNumber;
        private string   streetName;
        private City     city;
        private string   superintendent;
        private string   superintendentPhone;
        private DateTime dateActive;
        private DateTime dateModified;

        public Property()
        {
            propertyID          = 0;
            customer            = new Customer();
            unitNumber          = "";
            streetNumber        = "";
            streetName          = "";
            city                = new City();
            superintendent      = "";
            superintendentPhone = "";
            dateActive          = DateTime.Now;
            dateModified        = DateTime.Now;
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

        public void setUnitNumber(string unitNumber)
        {
            this.unitNumber = unitNumber;
        }
        public string getUnitNumber()
        {
            return unitNumber;
        }

        public void setStreetNumber(string streetNumber)
        {
            this.streetNumber = streetNumber;
        }
        public string getStreetNumber()
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

        public void setCity(City city)
        {
            this.city = city;
        }
        public City getCity()
        {
            return city;
        }

        public void setSuperintendent(string superintendent)
        {
            this.superintendent = superintendent;
        }
        public string getSuperintendent()
        {
            return superintendent;
        }

        public void setSuperintendentPhone(string superintendentPhone)
        {
            this.superintendentPhone = superintendentPhone;
        }
        public string getSuperintendentPhone()
        {
            return superintendentPhone;
        }

        public void setDateActive(DateTime dateActive)
        {
            this.dateActive = dateActive;
        }
        public string getDateActive()
        {
            return superintendentPhone;
        }

        public void setDateModified(DateTime dateModified)
        {
            this.dateModified = dateModified;
        }
        public DateTime getDateModified()
        {
            return dateModified;
        }
    }
}
