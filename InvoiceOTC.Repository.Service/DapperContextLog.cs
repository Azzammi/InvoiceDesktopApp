using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    class DapperContextLog : IDapperContext
    {
        #region Declaration
        private readonly string m_providerName;
        private readonly string m_ConnectionString;
        private IDbConnection m_Db;
        #endregion

        #region Constructor
        public DapperContextLog()
        {

        }
        #endregion

        public IDbConnection db
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            if (m_Db != null)
            {
                try
                {
                    if (m_Db.State != ConnectionState.Closed)
                        m_Db.Close();
                }
                finally
                {
                    m_Db.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }

        public string GetLastID()
        {
            throw new NotImplementedException();
        }
    }
}
