using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Data_Access
{
    public class rotiItemDAO
    {
        #region Methods
        internal void CreateDatabaseRecord(rotiItem newRoti, int parentID)
        {
            //Built "insert" query
            String sql = string.Format("INSERT INTO invoiceDetail "
                + "(itemCode,invoiceID, itemQty, itemPrice) "
                +" OUTPUT INSERTED.rotiID  "
                + "VALUES ('0',{0},0,0)",parentID);
            //Execute Query
            int newRecordID = DataProvider.ExecuteScalar(sql);

            //Set record ID of new Object
            newRoti.ID = newRecordID;          
        }

        internal void UpdateDatabaseRecord(rotiItem changedRoti)
        {
            StringBuilder sqlQuery = new StringBuilder("Update invoiceDetail SET ");           
            sqlQuery.Append(String.Format("itemCode = '{0}', ", changedRoti.ItemCode));            
            sqlQuery.Append(String.Format("itemQty = '{0}', ", changedRoti.Qty));
            sqlQuery.Append(String.Format("itemPrice = '{0}' , ", changedRoti.Price));
            sqlQuery.Append(String.Format("discount = '{0}' ,", changedRoti.Discount));
            sqlQuery.Append(String.Format("subTotal = '{0}' ", changedRoti.SubTotal));
            sqlQuery.Append(String.Format("WHERE rotiID = '{0}'",  changedRoti.ID));

            //Execute Query
            DataProvider.ExecuteNonQuery(sqlQuery.ToString());
        }

        internal void DeleteDatabaseRecord(int p_ID)
        {
            //Build 'Delete' Query
            string sqlQuery = string.Format("Delete from invoiceDetail WHERE rotiID = '{0}' ", p_ID);

            //Execute Query
            DataProvider.ExecuteNonQuery(sqlQuery);
        }
        #endregion

    }
}
