using System;

namespace InvoiceOTC.Model
{
    public class ProductPrices
    {
        public string itemCode { get; set; }
        public DateTime dateFrom { get; set; }
        public decimal price { get; set; }
    }
}
