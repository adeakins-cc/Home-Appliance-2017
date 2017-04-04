using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class Category
    {
        private int categoryID;
        private string name;

        public Category()
        {
            categoryID  = 0;
            name        = "";
        }

        public void setCategoryID(int categoryID)
        {
            this.categoryID = categoryID;
        }
        public int getCategoryID()
        {
            return categoryID;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}
