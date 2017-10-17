using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;
using System.Data;

namespace Invoice_OTC.Data_Access
{
    class SalesmanListDAO
    {
        #region Methods
        public void LoadCustomerList(SalesmanList list)
        {

            string sql = "SELECT [SLSMCODE],[SLSMNAME],[SLSMADDRESS],[SLSMTELP],[SLSMSUPV],[SLSMPHOTO],[STAT] FROM [OTF_Invoice].[dbo].[SALESMAN]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Creaete variable for dataSet table
            DataTable customerTabel = dataSet.Tables[0];

            SalesmanItem nextCustomer = null;

            foreach (DataRow parentRow in customerTabel.Rows)
            {
                nextCustomer = new SalesmanItem();

                nextCustomer.SlsmCode = parentRow["SLSMCODE"].ToString();
                nextCustomer.SlsmName = parentRow["SLSMNAME"].ToString();
                nextCustomer.SlsmAddress = parentRow["SLSMADDRESS"].ToString();
                nextCustomer.SlsmTelp = parentRow["SLSMTELP"].ToString();
                nextCustomer.SlsmSupv = parentRow["SLSMSUPV"].ToString();
                nextCustomer.SlsmPhoto = parentRow["SLSMPHOTO"].ToString();
                nextCustomer.Stat = Convert.ToBoolean(parentRow["STAT"]);

                list.Add(nextCustomer);
            }

            dataSet.Dispose();
        }
        #endregion
    }
}
