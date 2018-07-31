using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    public class OutletImportExcelRepository : IOutletImportExcel
    {
        public IList<Outlet> CheckIfExistRecord(IList<Outlet> source, IList<Outlet> sourceExcel)
        {
            var list3 = sourceExcel.Except(source).ToList();
            return list3;
        }

        public IList<Outlet> dataGridToObjectList(DataGridView dataGridView1)
        {
            IList<Outlet> listImport = new List<Outlet>();
            if (dataGridView1.DataSource == null) return null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null) break;

                if (!string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                {
                    Outlet myItem = new Outlet();
                    myItem.outlCode = row.Cells[2].Value.ToString();
                    myItem.outlName = row.Cells[3].Value.ToString();
                    myItem.outlAddress = row.Cells[4].Value.ToString();
                    myItem.slsmCode = row.Cells[0].Value.ToString();
                    myItem.outlRoute = row.Cells[5].Value.ToString();
                    myItem.outlStat = true;                   

                    listImport.Add(myItem);
                }
                
            }

            return listImport;
        }
    }
}
