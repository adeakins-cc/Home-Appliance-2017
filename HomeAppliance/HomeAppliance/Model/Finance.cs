using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance.Model
{
    class Finance
    {
        private int         finacialID;
        private DateTime    postDate;
        private Invoice     invoice;
        private decimal     totalDue;
        private decimal     amountPaid;
        private string      notes;
        private DateTime    paidDate;
        private string      chequeName;
        private string      chequeNumber;
        private DateTime    dateOnCheque;

        public Finance()
        {
            finacialID      = 0;
            postDate        = DateTime.Now;
            invoice         = new Invoice();
            totalDue        = 0;
            amountPaid      = 0;
            notes           = "";
            paidDate        = DateTime.Now;
            chequeName      = "";
            chequeNumber    = "";
            dateOnCheque    = DateTime.Now;
        }

        public void setFinancialID(int finacialID)
        {
            this.finacialID = finacialID;
        }
        public int getFinacialID()
        {
            return finacialID;
        }

        public void setPostDate(DateTime postDate)
        {
            this.postDate = postDate;
        }
        public DateTime getPostDate()
        {
            return postDate;
        }

        public void setInvoice(Invoice invoice)
        {
            this.invoice = invoice;
        }
        public Invoice getinvoice()
        {
            return invoice;
        }

        public void setTotalDue(decimal totalDue)
        {
            this.totalDue = totalDue;
        }
        public decimal getTotalDue()
        {
            return totalDue;
        }

        public void setAmountPaid(decimal amountPaid)
        {
            this.amountPaid = amountPaid;
        }
        public decimal getAmountPaid()
        {
            return amountPaid;
        }

        public void setNotes(string notes)
        {
            this.notes = notes;
        }
        public string getNotes()
        {
            return notes;
        }

        public void setPaidDate(DateTime paidDate)
        {
            this.paidDate = paidDate;
        }
        public DateTime getPaidDate()
        {
            return paidDate;
        }

        public void setChequeName(string chequeName)
        {
            this.chequeName = chequeName;
        }
        public string getChequeName()
        {
            return chequeName;
        }

        public void setChequeNumber(string chequeNumber)
        {
            this.chequeNumber = chequeNumber;
        }
        public string getChequeNumber()
        {
            return chequeNumber;
        }

        public void setDateOnCheque(DateTime dateOnCheque)
        {
            this.dateOnCheque = dateOnCheque;
        }
        public DateTime getDateOnCheque()
        {
            return dateOnCheque;
        }
    }
}
