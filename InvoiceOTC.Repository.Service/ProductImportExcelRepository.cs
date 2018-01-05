using System;
using System.Collections.Generic;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using System.Linq;
using System.Windows.Forms;

namespace InvoiceOTC.Repository.Service
{
    public class ProductImportExcelRepository : IProductImportExcel
    {
        public IList<Product> CheckIfExistRecord(IList<Product> source, IList<Product> sourceExcel)
        {
            var list3 = sourceExcel.Except(source).ToList();
            return list3;
        }

        public IList<Product> dataGridToObjectList(DataGridView dataGridView1)
        {
            IList<Product> listImport = new List<Product>();
            if (dataGridView1.DataSource == null) return null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!string.IsNullOrWhiteSpace(row.Cells[9].Value.ToString()))
                {
                    Product myItem = new Product();
                    myItem.itemCode = row.Cells[0].Value.ToString();
                    myItem.itemName = row.Cells[1].Value.ToString();
                    myItem.itemSort = row.Cells[2].Value.ToString();
                    myItem.brand = row.Cells[4].Value.ToString();
                    myItem.jenis = row.Cells[6].Value.ToString();
                    myItem.category = row.Cells[7].Value.ToString();
                    myItem.subCategory = row.Cells[8].Value.ToString();
                    myItem.price = Convert.ToDecimal(row.Cells[9].Value);

                    listImport.Add(myItem);
                }
                else
                {
                    return listImport;
                }
            }

            return listImport;
        }
    }
}
