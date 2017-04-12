using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class Taxes
    {
        private int taxId;
        private string name;
        private decimal rate;

        public Taxes()
        {
            taxId   = 0;
            name    = "";
            rate    = 0;
        }

        public void setTaxId(int taxId)
        {
            this.taxId = taxId;
        }
        public int getTaxId()
        {
            return taxId;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        public void setRate(decimal rate)
        {
            this.rate = rate;
        }
        public decimal getRate()
        {
            return rate;
        }
    }
}
