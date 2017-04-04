using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class PartsUsed
    {
        private int usedPartID;
        private Invoice invoice;
        private Part part;
        private decimal editPrice;
        private int quantity;

        public PartsUsed()
        {
            usedPartID  = 0;
            invoice     = new Invoice();
            part        = new Part();
            editPrice   = 0;
            quantity    = 0;
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

        public void setQuantity(int quantity)
        {
            this.usedPartID = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }


    }
}
