using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using Invoice_OTC.Model;
using System.Data;

namespace Invoice_OTC.Data_Access
{
    class OutletListDAO
    {
        internal enum OutletParameter{
            OutletCode,
            OutletName,
            OutletAddrees,
            OutletRoute,
            OutletSalesman
        }

        #region COnstructor
        public OutletListDAO()
        {

        }
        #endregion

        #region Methods
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
        internal void ShowListWithLinq(outletList list)
        {
            //Set the connection
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Get a typed table
            Table<OUTLET> items = db.GetTable<OUTLET>();

            //Get all author
            var allItem = from roti in items select roti;

            outletItem nextItem = null;
            foreach (var item in allItem)
            {
                nextItem = new outletItem();
                nextItem.OutletCode = item.OUTLCODE;
                nextItem.OutletName = item.OUTLNAME;
                nextItem.OutletAddress = item.OUTLADDRESS;
                nextItem.OutletRoute = item.OUTLROUTE;
                nextItem.SlsmCode = item.OUTLSLSM;
                nextItem.OutletStatus = (bool)item.OUTLSTAT;

                list.Add(nextItem);
            }
        }
        internal void ShowListWithLinq(outletList list, OutletParameter param, string paramValue)
        {
            //Set the connection
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Get a typed table
            Table<OUTLET> items = db.GetTable<OUTLET>();

            var allItem = from roti in items select roti;

            //Get all author
            switch (param)
            {
                case OutletParameter.OutletCode:
                    allItem = from roti in items where roti.OUTLCODE == paramValue select roti;
                    break;
                case OutletParameter.OutletName:
                    allItem = from roti in items where roti.OUTLNAME.Contains(paramValue) select roti;
                    break;
                case OutletParameter.OutletAddrees:
                    allItem = from roti in items where roti.OUTLADDRESS == paramValue select roti;
                    break;
                case OutletParameter.OutletRoute:
                    allItem = from roti in items where roti.OUTLROUTE == paramValue select roti;
                    break;
                case OutletParameter.OutletSalesman:
                    allItem = from roti in items where roti.OUTLSLSM == paramValue select roti;
                    break;
                default:
                    allItem = from roti in items select roti;
                    break;
            }         

            outletItem nextItem = null;
            foreach (var item in allItem)
            {
                nextItem = new outletItem();
                nextItem.OutletCode = item.OUTLCODE;
                nextItem.OutletName = item.OUTLNAME;
                nextItem.OutletAddress = item.OUTLADDRESS;
                nextItem.OutletRoute = item.OUTLROUTE;
                nextItem.SlsmCode = item.OUTLSLSM;
                nextItem.OutletStatus = (bool)item.OUTLSTAT;

                list.Add(nextItem);
            }
        }
        #endregion
    }
}
