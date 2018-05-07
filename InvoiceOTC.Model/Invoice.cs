using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSCollections;

namespace InvoiceOTC.Model
{
    public class Invoice
    {
        #region Properties
        
        public int invoiceID { get; set; }
        public string nomorInvoice { get; set; }
        public DateTime dueDate { get; set; }
        public string outletCode { get; set; }
        public decimal subTotal { get; set; }
        public float ppn { get; set; }
        public decimal total { get; set; }
        public DateTime issuedDate { get; set; }
        public bool isPPN { get; set; }
        public string nomorPO { get; set; }
        public string pengguna { get; set; }
        public string periode { get; set; }
        public string idPayment { get; set; }
        public bool isPayed { get; set; }
        public decimal amountDue { get; set; }

        public List<InvoiceDetail> detail {get; set;}
        public FSBindingList<InvoiceDetail> p_Items { get; set; }
        #endregion
    }
}
