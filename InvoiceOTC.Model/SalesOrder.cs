using System;
using System.Collections.Generic;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class SalesOrder
    {
        public int salesorderId { get; set; }
        public string manualRef { get; set; }
        public string accountRef { get; set; }
        public DateTime soCreated { get; set; }
        public DateTime soDate { get; set; }    
        public string outlCode { get; set; }       
        public string outlName { get; set; }
        public int qtyOrder { get; set; }
        public decimal totalAmount { get; set; }
        public string otherRef { get; set; }
        public string nomorSO { get; set; }

        public IList<SalesOrderDetail> detail { get; set; }
        public FSCollections.FSBindingList<SalesOrderDetail> p_Items { get; set; }
    }
}
