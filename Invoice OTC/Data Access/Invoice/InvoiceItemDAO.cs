using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;

namespace Invoice_OTC.Data_Access
{
    public class InvoiceItemDAO
    {
        #region Methods 

        internal void CreateDatabaseRecord(InvoiceItem newInvoice)
        {
            //int number = 0;

            //NumberingList newNumber = new NumberingList("invoice", "noInvoice");
            //foreach(numberingItem item in newNumber)
            //{
            //    number = Convert.ToInt32(item);
            //}

            //Built SqlQuery
            string sql = string.Format("INSERT INTO invoice "
                                + "(noInvoice) "
                                + "OUTPUT INSERTED.invoiceID "
                                + " VALUES "
                                + "('[1313]')");

            //ExecuteQuery
                int newRecordId = DataProvider.ExecuteScalar(sql);

            //Set record ID of the new object
            newInvoice.InvoiceID = newRecordId;
        }

        internal void UpdateDatabaseRecord(InvoiceItem changedInvoice)
        {
            StringBuilder sqlQuery = new StringBuilder("Update invoice SET ");
            sqlQuery.Append(String.Format("noInvoice = '{0}', ", changedInvoice.Nomor));
            sqlQuery.Append(String.Format("periodeBulan = '{0}', ", changedInvoice.PeriodeBulan));
            sqlQuery.Append(String.Format("outletCode = '{0}', ", changedInvoice.OutletCode));            
            sqlQuery.Append(String.Format("subTotal = '{0}', ", changedInvoice.SubTotal));
            sqlQuery.Append(String.Format("ppn = '{0}', ", changedInvoice.PPN));
            sqlQuery.Append(String.Format("total = '{0}', ", changedInvoice.Total));
            sqlQuery.Append(String.Format("issuedDate = '{0}' ", changedInvoice.IssuedData));
            sqlQuery.Append(String.Format("WHERE InvoiceID = '{0}'", changedInvoice.InvoiceID));

            //Execute Query
            DataProvider.ExecuteNonQuery(sqlQuery.ToString());
        }

        internal void DeleteDatabaseRecord(int invoiceID)
        {
            //Build 'Delete' Query
            string sqlQuery = string.Format("Delete from invoice WHERE invoiceID = '{0}' ", invoiceID);

            //Execute Query
            DataProvider.ExecuteNonQuery(sqlQuery);
        }
        #endregion

    }
}
