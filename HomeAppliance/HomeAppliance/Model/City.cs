using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class City
    {
        private int cityId;
        private string name;
        private string province;
        private string country;

        public City()
        {
            cityId = 0;
            name = "";
            province = "ON";
            country = "CANADA";
        }

        public void setCityId(int cityId)
        {
            this.cityId = cityId;
        }
        public int getCityId()
        {
            return cityId;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
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
    }
}
