using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;
using System.Data;

namespace Invoice_OTC.Data_Access
{
    class RotiToChooseListDAO
    {
        #region Constructor 

        public RotiToChooseListDAO()
        {

        }

        #endregion

        #region Methods

        public void ListRotiToChoose(RotiToChooseList rotiList)
        {
            //Build a query string
            string sql = string.Format("SELECT ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat FROM [ITEM]");

            //Get a dataset from the query
            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variables for dataset
            DataTable rotiTable = dataSet.Tables[0];

            //Load roti list from the database
            RotiToChooseItem nextRoti = null;
            foreach(DataRow parent in rotiTable.Rows)
            {
                nextRoti = new RotiToChooseItem();
                nextRoti.ItemCode = parent["itemCode"].ToString();
                nextRoti.ItemName = parent["itemName"].ToString();
                nextRoti.ItemSort = parent["itemSort"].ToString();
                nextRoti.Brand = parent["Brand"].ToString();
                nextRoti.Jenis = parent["Jenis"].ToString();
                nextRoti.Category = parent["Category"].ToString();
                nextRoti.SubCategory = parent["SubCategory"].ToString();
                nextRoti.Price = Convert.ToDecimal(parent["Price"]);
                nextRoti.Stat = Convert.ToBoolean(parent["Stat"]);

                //Add the data item to the data list
                rotiList.Add(nextRoti);
            }

            //Dispose of the dataset
            dataSet.Dispose();
        }

        #endregion
    }
}
