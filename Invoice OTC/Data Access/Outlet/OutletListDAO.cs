using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;
using System.Data;

namespace Invoice_OTC.Data_Access
{
    class OutletListDAO
    {
        #region COnstructor
        public OutletListDAO()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// To Get all List
        /// </summary>
        /// <param name="list"></param>
        internal void ShowList(outletList list)
        {
            //Build a query string
            string sql = string.Format("SELECT [OUTLCODE],[OUTLNAME],[OUTLADDRESS],[OUTLSLSM],[OUTLROUTE],[OUTLSTAT] FROM [OTF_Invoice].[dbo].[OUTLET]");

            //Get a dataset from the query
            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variables for dataset
            DataTable rotiTable = dataSet.Tables[0];

            //Load roti list from the database
            outletItem nextItem = null;
            foreach (DataRow parent in rotiTable.Rows)
            {
                nextItem = new outletItem();
                nextItem.OutletCode = parent["OUTLCODE"].ToString();
                nextItem.OutletName = parent["OUTLNAME"].ToString();
                nextItem.OutletAddress = parent["OUTLADDRESS"].ToString();
                nextItem.OutletRoute = parent["OUTLROUTE"].ToString();
                nextItem.SlsmCode = parent["OUTLSLSM"].ToString();
                nextItem.OutletStatus = Convert.ToBoolean(parent["OUTLSTAT"]);

                //Add the data item to the data list
                if(nextItem.OutletCode == "")
                {
                    nextItem.DeleteDatabaseRecord();
                }
                list.Add(nextItem);
            }

            //Dispose of the dataset
            dataSet.Dispose();
        }

        /// <summary>
        /// To get list per salesman
        /// </summary>
        /// <param name="list"></param>
        /// <param name="slsmCode"></param>
        internal void ShowList(outletList list, string slsmCode)
        {
            //Build a query string
            string sql = string.Format("SELECT [OUTLCODE],[OUTLNAME],[OUTLADDRESS],[OUTLSLSM],[OUTLROUTE],[OUTLSTAT] FROM [OTF_Invoice].[dbo].[OUTLET] WHERE [OUTLSLSM] = '" + slsmCode + "'");

            //Get a dataset from the query
            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variables for dataset
            DataTable rotiTable = dataSet.Tables[0];

            //Load roti list from the database
            outletItem nextItem = null;
            foreach (DataRow parent in rotiTable.Rows)
            {
                nextItem = new outletItem();
                nextItem.OutletCode = parent["OUTLCODE"].ToString();
                nextItem.OutletName = parent["OUTLNAME"].ToString();
                nextItem.OutletAddress = parent["OUTLADDRESS"].ToString();
                nextItem.OutletRoute = parent["OUTLROUTE"].ToString();
                nextItem.SlsmCode = parent["OUTLSLSM"].ToString();
                nextItem.OutletStatus = Convert.ToBoolean(parent["OUTLSTAT"]);

                //Add the data item to the data list
                if (nextItem.OutletCode == "")
                {
                    nextItem.DeleteDatabaseRecord();
                }
                list.Add(nextItem);
            }

            //Dispose of the dataset
            dataSet.Dispose();
        }
        #endregion
    }
}
