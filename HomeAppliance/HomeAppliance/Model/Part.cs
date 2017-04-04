using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class Part
    {
        private int partID;
        private Category category;
        private string name;
        private decimal price;

        public Part()
        {
            partID = 0;
            category = new Category();
            name = "";
            price = 0;
        }

        public void setPartID(int partID)
        {
            this.partID = partID;
        }
        public int getPartID()
        {
            return partID;
        }

        public void setCategory(Category category)
        {
            this.category = category;
        }
        public Category getCategory()
        {
            return category;
        }
        
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }
        public decimal getPrice()
        {
            return price;
        }

    }
}
