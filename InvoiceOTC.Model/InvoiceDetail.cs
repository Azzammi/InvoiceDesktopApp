using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Model
{
    public class InvoiceDetail
    {
        #region Declarations

        //Property Variables
        public int p_ID { get; set; }
        public int invoiceID {get; set;}
        public string itemCode {get; set;}
        public int itemQty {get; set;}
        public double discount {get; set;}
        public decimal itemPrice {get; set;}
        public decimal subTotal {get; set;}

        #endregion
    }
}
