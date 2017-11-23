using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Repository.API;
using System.Data.Common;
using Dapper;

namespace InvoiceOTC.Repository.Service
{
    public class DapperContext : IDapperContext
    {
        #region Declaration
        private readonly string m_ProviderName;
        private readonly string m_ConnectionString;
        private IDbConnection m_Db;
        #endregion

        #region Constructor
        public DapperContext()
        {
            //For Get directory and database
            //var dbName = System.IO.Directory.GetCurrentDirectory() + "OTF_Invoice";

            string dbName = "OTF_Invoice";

            m_ProviderName = "System.Data.SqlClient";
            //m_ConnectionString = "Data Source = (local)/sqlexpress; Initial Catalog = " + dbName + "; Integrated Security = True;" ;
            m_ConnectionString = @"Data Source = (local)\sqlexpress; Initial Catalog = " + dbName + "; Integrated Security = True;";
        }

        /// <summary>
        /// DapperContext For Logger Data
        /// </summary>
        /// <param name="isLogger">Just Set True</param>
        public DapperContext(bool isLogger)
        {
            string dbName = System.IO.Directory.GetCurrentDirectory() + "\\OTF_Invoice";

            m_ProviderName = "System.Data.SQLite";
            m_ConnectionString = @"Data Source = " + dbName + "; Version = 3";
        }
        #endregion
        private IDbConnection GetOpenConnection(string providerName, string connectionString)
        {
            DbConnection conn = null;

            try
            {
                DbProviderFactory provider = DbProviderFactories.GetFactory(providerName);
                conn = provider.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch
            {
            }

            return conn;
        }
        public IDbConnection db
        {
            get
            {
                return m_Db ?? (m_Db = GetOpenConnection(m_ProviderName, m_ConnectionString));
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
