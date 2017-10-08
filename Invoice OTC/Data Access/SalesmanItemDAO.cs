using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Data_Access
{
    class SalesmanItemDAO
    {
        #region Declaration
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public SalesmanItemDAO()
        {
            m_ConnectionString = Properties.Settings.Default.ConnectionString.ToString();
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(SalesmanItem newItem)
        {

        }
        internal void UpdateDatabaseRecord(SalesmanItem updateItem)
        {

        }
        internal void DeleteDatabaseRecord(string SlsmCode)
        {

        }
        #endregion
    }
}
