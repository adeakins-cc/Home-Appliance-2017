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
        private string firstName;
        private string lastName;
        private string companyName;
        //Address 1
        private string unitNumber_01;
        private string streetNumber_01;
        private string streetName_01;
        private City city_01;
        private string postalCode_01;
        //Address 2
        private string unitNumber_02;
        private string streetNumber_02;
        private string streetName_02;
        private City city_02;
        private string postalCode_02;

        private string bussinessPhone;
        private string homePhone;
        private string fax;
        private string contactMobile;
        private string contactName;
        private string comments;
        private DateTime dateActive;
        private DateTime dateModified;
        private string contactEmail;

        public Customer()
        {
            customerID      = 0;
            firstName       = "";
            lastName        = "";
            companyName     = "";

            unitNumber_01   = "";
            streetNumber_01 = "";
            streetName_01   = "";
            city_01         = new City();
            postalCode_01   = "";

            unitNumber_02   = "";
            streetNumber_02 = "";
            streetName_02   = "";
            city_02         = new City();
            postalCode_02   = "";

            bussinessPhone  = "";
            homePhone       = "";
            fax             = "";
            contactMobile   = "";
            contactName     = "";
            comments        = "";
            dateActive      = DateTime.Now;
            dateModified    = DateTime.Now;
            contactEmail    = "";
        }

        public void setCustomerID(int customerID)
        {
            this.customerID = customerID;
        }
        public int getCustomerID()
        {
            return customerID;
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

        public void setCompanyName(string companyName)
        {
            this.companyName = companyName;
        }
        public string getCompanyName()
        {
            return companyName;
        }

        public void setUnitNumber_01(string unitNumber_01)
        {
            this.unitNumber_01 = unitNumber_01;
        }
        public string getUnitNumber_01()
        {
            return unitNumber_01;
        }

        public void setStreetNumber_01(string streetNumber_01)
        {
            this.streetNumber_01 = streetNumber_01;
        }
        public string getStreetNumber_01()
        {
            return streetNumber_01;
        }

        public void setStreetName_01(string streetName_01)
        {
            this.streetName_01 = streetName_01;
        }
        public string getStreetName_01()
        {
            return streetName_01;
        }

        public void setCity_01(City city_01)
        {
            this.city_01 = city_01;
        }
        public City getCity_01()
        {
            return city_01;
        }

        public void setPostalCode_01(string postalCode_01)
        {
            this.postalCode_01 = postalCode_01;
        }
        public string getPostalCode_01()
        {
            return postalCode_01;
        }

        public void setUnitNumber_02(string unitNumber_02)
        {
            this.unitNumber_02 = unitNumber_02;
        }
        public string getUnitNumber_02()
        {
            return unitNumber_02;
        }

        public void setStreetNumber_02(string streetNumber_02)
        {
            this.streetNumber_02 = streetNumber_02;
        }
        public string getStreetNumber_02()
        {
            return streetNumber_02;
        }

        public void setStreetName_02(string streetName_02)
        {
            this.streetName_02 = streetName_02;
        }
        public string getStreetName_02()
        {
            return streetName_02;
        }

        public void setCity_02(City city_02)
        {
            this.city_02 = city_02;
        }
        public City getCity_02()
        {
            return city_02;
        }

        public void setPostalCode_02(string postalCode_02)
        {
            this.postalCode_02 = postalCode_02;
        }
        public string getPostalCode_02()
        {
            return postalCode_02;
        }

        public void setBussinessPhone(string bussinessPhone)
        {
            this.bussinessPhone = bussinessPhone;
        }
        public string getBussinessPhone()
        {
            return bussinessPhone;
        }

        public void setHomePhone(string homePhone)
        {
            this.homePhone = homePhone;
        }
        public string getHomePhone()
        {
            return homePhone;
        }

        public void setFax(string fax)
        {
            this.fax = fax;
        }
        public string getFax()
        {
            return fax;
        }

        public void setContactMobile(string contactMobile)
        {
            this.contactMobile = contactMobile;
        }
        public string getContactMobile()
        {
            return contactMobile;
        }

        public void setContactName(string contactName)
        {
            this.contactName = contactName;
        }
        public string getContactName()
        {
            return contactName;
        }

        public void setComments(string comments)
        {
            this.comments = comments;
        }
        public string getComments()
        {
            return comments;
        }

        public void setDateActive(DateTime dateActive)
        {
            this.dateActive = dateActive;
        }
        public DateTime getDateActive()
        {
            return dateActive;
        }

        public void setDateModified(DateTime dateModified)
        {
            this.dateModified = dateModified;
        }
        public DateTime getDateModified()
        {
            return dateModified;
        }
        
        public void setContactEmail(string contactEmail)
        {
            this.contactEmail = contactEmail;
        }
        public string getContactEmail()
        {
            return contactEmail;
        }
    }
}
