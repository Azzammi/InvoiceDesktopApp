namespace InvoiceOTC.Model
{
    public class InvoiceDetail
    {
        #region Properties

        //Property Variables
        //public int detailId { get; set; }
        public int invoiceID {get; set;}
        public string itemCode {get; set;}
        public int itemQty {get; set;}
        public double discount {get; set;}
        public decimal itemPrice {get; set;}
        public decimal subTotal {get; set;}       

        #endregion
    }
}
