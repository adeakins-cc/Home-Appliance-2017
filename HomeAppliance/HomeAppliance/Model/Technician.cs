using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    public class Technician
    {
        private int technicianID;
        private string tecnicianName;

        public Technician()
            {
            technicianID    = 0;
            tecnicianName   = "";
            }

        public void setTechnicianID(int technicianID)
        {
            this.technicianID = technicianID;
        }
        public int getTechnicianID()
        {
            return technicianID;
        }

        public void setTechnicianName(string tecnicianName)
        {
            this.tecnicianName = tecnicianName;
        }
        public string getStreetName()
        {
            return tecnicianName;
        }


    }
}
