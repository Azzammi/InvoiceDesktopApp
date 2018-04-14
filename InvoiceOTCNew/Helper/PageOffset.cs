using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTCNew.Helper
{
    class PageOffset : System.ComponentModel.IListSource
    {
        public bool ContainsListCollection { get; protected set; } //IListSource Properties
        public int TotalRecords { get; set; } //Properties
        public int PageSize { get; set; } //Properise

        public IList GetList() //IListSource Properties
        {
            // Return a list of page offsets based on "totalRecords" and "pageSize"
            var pageOffsets = new List<int>();
            for (int offset = 0; offset < TotalRecords; offset += PageSize)
                pageOffsets.Add(offset);
            return pageOffsets;
        }        
    }
}
