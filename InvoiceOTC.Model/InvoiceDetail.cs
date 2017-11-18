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
        private int p_ID { get; set; }
        private int invoiceID {get; set;}
        private string itemCode {get; set;}
        private int itemQty {get; set;}
        private double discount {get; set;}
        private decimal itemPrice {get; set;}
        private decimal subTotal {get; set;}

        #endregion
    }
}
