using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class PartList
    {
        private int usedPartID;
        private Invoice invoice;
        private int quantity;
        private Part part;
        private decimal editPrice;

        public PartList()
        {
            usedPartID  = 0;
            invoice     = new Invoice();
            quantity    = 0;
            part        = new Part();
            editPrice   = 0;
        }

        public void setUsedPartID(int usedPartID)
        {
            this.usedPartID = usedPartID;
        }
        public int getUsedPartID()
        {
            return usedPartID;
        }

        public void setInvoice(Invoice invoice)
        {
            this.invoice = invoice;
        }
        public Invoice getInvoice()
        {
            return invoice;
        }

        public void setQuantity(int quantity)
        {
            this.usedPartID = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }

        public void setPart(Part part)
        {
            this.part = part;
        }
        public Part getPart()
        {
            return part;
        }

        public void setEditPrice(decimal editPrice)
        {
            this.editPrice = editPrice;
        }
        public decimal getEditPrice()
        {
            return editPrice;
        }

        
    }
}
