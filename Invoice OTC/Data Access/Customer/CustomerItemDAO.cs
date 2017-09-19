using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;
using Invoice_OTC.Properties;

namespace Invoice_OTC.Data_Access
{
    class CustomerItemDAO
    {
        #region Declaration
        public static string m_ConnectionString;
        #endregion

        #region Constructor
        public CustomerItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(CustomerItem newItem)
        {

        }
        internal void UpdateDatabaseRecord(CustomerItem updateItem)
        {

        }
        internal void DeleteDatabaseRecord(string SlsmCode)
        {

        }
        #endregion
    }
}
