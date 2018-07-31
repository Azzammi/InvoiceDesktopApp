using System;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class SalesOrderDetail
    {
        public int soDetailID { get; set; }
        public string manualRef { get; set; }       
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public int qtyOrder { get; set; }
        public decimal amount { get; set; }
        public string nomorSO { get; set; }

        /* Not inserted to database */
        public decimal itemPrice { get; set; }
    }
}
