using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Model
{
    public class Invoice
    {
        #region Declaration

        //Property Variables
        public IList<InvoiceDetail> p_Items {get; set;}
        public int invoiceID {get; set;}
        public string nomorInvoice;
        public DateTime dueDate {get; set;}
        public string outletName {get; set;}
        public decimal subTotal {get; set;}
        public float ppn {get; set;}
        public DateTime issuedDate {get; set;}
        public bool isPPN {get; set;}
        public string nomorPO {get; set;}
        public string pengguna {get; set;}
        public string periode {get; set;}
        public string paymentMethod {get; set;}
        public bool isPayed {get; set;}
        #endregion
    }
}
