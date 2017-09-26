using Invoice_OTC.Model;
using System;
using System.Data;

namespace Invoice_OTC.Data_Access
{
    class RotiListDAO
    {
        #region declarations

        #endregion

        #region Constuctor
        public RotiListDAO()
        {
        }
        #endregion

        #region Methods
        internal void ShowList(RotiList list)
        {
            string sql = "SELECT [rotiID],[InvoiceID],[itemCode],[itemName],[itemQty],[itemPrice] FROM [OTF_Invoice].[dbo].[invoiceDetail]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Creaete variable for dataSet table
            DataTable customerTabel = dataSet.Tables[0];

            rotiItem nextDetail = null;

            foreach (DataRow parentRow in customerTabel.Rows)
            {
                nextDetail = new rotiItem();

                nextDetail.ID = Convert.ToInt32(parentRow["rotiID"]);
                nextDetail.Invoiceid = Convert.ToInt32(parentRow["InvoiceID"]);
                nextDetail.Code = parentRow["itemCode"].ToString();
                nextDetail.Qty = Convert.ToInt32(parentRow["itemQty"]);
                nextDetail.Price = Convert.ToDecimal(parentRow["itemPrice"]);

                list.Add(nextDetail);
            }

            dataSet.Dispose();
        }        
        #endregion
    }
}
