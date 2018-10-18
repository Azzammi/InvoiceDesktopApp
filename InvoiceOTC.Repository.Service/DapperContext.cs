using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
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
            #region  SQL Server Connection Section
            /*
            //For Get directory and database
            //var dbName = System.IO.Directory.GetCurrentDirectory() + "OTF_Invoice";

            string dbName = "OTF_Invoice";

            m_ProviderName = "System.Data.SqlClient";
            ///m_ConnectionString = "Data Source = (local)/sqlexpress; Initial Catalog = " + dbName + "; Integrated Security = True;" ;
            m_ConnectionString = @"Data Source = (local)\sqlexpress; Initial Catalog = " + dbName + "; Integrated Security = True;";
            */
            #endregion

            var server = "localhost";
            var port = "5433";
            var dbName = "OTF_Invoice";
            var userID = "postgres";
            var userPassword = "password";
            //var appName = "Invoice OTC";

            m_ProviderName = "Npgsql";
            m_ConnectionString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}", server, port, userID, userPassword, dbName);

            if (m_Db == null)
            {
                m_Db = GetOpenConnection(m_ProviderName, m_ConnectionString);
            }
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

        #region Properties        
        public IDbConnection db
        {
            get
            {
                return m_Db ?? (m_Db = GetOpenConnection(m_ProviderName, m_ConnectionString));
            }
        }
        #endregion        

        #region Methods   
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
        #endregion

    }
}
