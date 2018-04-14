using System;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class Product 
    {
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string itemSort { get; set; }
        public string brand { get; set; }
        public string jenis { get; set; }
        public string category { get; set; }
        public string subCategory { get; set; }
        public decimal price { get; set; }
        public bool stat { get; set; }
    }
}
