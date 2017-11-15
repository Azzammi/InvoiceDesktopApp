using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace InvoiceOTC.Model
{
    public class Product : FSBindingItem
    {
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string itemSort { get; set; }
        public string brand { get; set; }
        public string jenis { get; set; }
        public string category { get; set; }
        public string subCategory { get; set; }
        public Nullable<decimal> price { get; set; }
        public bool stat { get; set; }
    }
}
