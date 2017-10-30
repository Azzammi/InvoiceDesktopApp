using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;
using System.Data;

namespace Invoice_OTC.Data_Access
{
    class AccountListDAO
    {
        #region Constructor

        #endregion

        #region Methods
        public void accountList<T>(AccountList<T> accountList)
        {
            //Build a query string
            string sql = string.Format("SELECT [userID],[userName],[password],[authLevel],[joinedDate],[isLoggedIn] FROM [OTF_Invoice].[dbo].[USERS]");

            //Get a dataset from the query
            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variables for dataset
            DataTable rotiTable = dataSet.Tables[0];

            //Load roti list from the database
            accountItem nextAccount = null;
            foreach (DataRow parent in rotiTable.Rows)
            {
                nextAccount = new accountItem();
                nextAccount.UserName = parent["userName"].ToString();
                nextAccount.PassWord = parent["password"].ToString();

                //Add the data item to the data list
                accountList.Add(nextAccount);
            }

            //Dispose of the dataset
            dataSet.Dispose();
        }

        #endregion
    }
}
