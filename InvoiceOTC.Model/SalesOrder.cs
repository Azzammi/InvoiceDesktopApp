using System;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class SalesOrder
    {
        public int soId { get; set; }
        public string manualRef { get; set; }
        public string account { get; set; }
        public DateTime soCreated { get; set; }
        public DateTime soDate { get; set; }
        public string slsmCode { get; set; }
        public string slsmName { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public int qtyWeekAgo { get; set; }
        public int qtyOrder { get; set; }
        public string otherRef { get; set; }
    }
}
