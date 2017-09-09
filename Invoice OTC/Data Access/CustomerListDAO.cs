using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;
using System.Data;

namespace Invoice_OTC.Data_Access
{
   public class CustomerListDAO
    {
        #region Constructor
        public CustomerListDAO() { }
        #endregion

        #region Methods
        public void LoadCustomerList(CustomerList list)
        {
            
            string sql ="SELECT SLSMCODE, SLSMNAME, SLSMSUPV FROM OTFSLSM";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Creaete variable for dataSet table
            DataTable customerTabel = dataSet.Tables[0];

            CustomerItem nextCustomer = null;

            foreach(DataRow parentRow in customerTabel.Rows)
            {
                nextCustomer = new CustomerItem();

                nextCustomer.SlsmCode = parentRow["SLSMCODE"].ToString();
                nextCustomer.SlsmName = parentRow["SLSMNAME"].ToString();

                list.Add(nextCustomer);
            }

            dataSet.Dispose();
        }
        #endregion
    }
}
