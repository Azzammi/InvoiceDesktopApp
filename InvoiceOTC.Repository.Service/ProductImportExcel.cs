using System;
using System.Collections.Generic;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System.Linq;

namespace InvoiceOTC.Repository.Service
{
    public class ProductImportExcel : IProductImportExcel
    {
        public IList<Product> CheckIfExistRecord(IList<Product> source, IList<Product> sourceExcel)
        {
            var list3 = source.Except(sourceExcel).ToList();
            return list3;
        }
    }
}
