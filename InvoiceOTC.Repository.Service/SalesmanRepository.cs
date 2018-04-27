using System;
using System.Collections.Generic;
using System.Linq;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using FSCollections;
using System.Windows.Forms;


namespace InvoiceOTC.Repository.Service
{
    public class SalesmanRepository : ISalesmanRepository
    {
        #region Declaration
        private ILog logger;
        private string m_Sql;
        private IDapperContext context;
        #endregion

        #region Constructor
        public SalesmanRepository() { context = new DapperContext(); }
        public SalesmanRepository(ILog _logger)
        {
            context = new DapperContext();
            this.logger = _logger;
        }
        #endregion

        #region Select Method
        public IList<Salesman> GetAll()
        {
            IList<Salesman> list = new List<Salesman>();
            try
            {
                m_Sql = @"SELECT slsmcode, slsmidnumber, slsmname, slsmaddress, slsmtelp, slsmsupv, slsmphoto, stat FROM salesman;";
                list = context.db.Query<Salesman>(m_Sql).ToListSorted();
            }
            catch (Exception ex)
            {
                logger.Error("Get data failed", ex);
            }
            return list;
        }
        public Salesman GetSalesmanByID(int salesmanID)
        {
            Salesman salesman = null;
            try
            {
                m_Sql = @"SELECT slsmcode, slsmidnumber, slsmname, slsmaddress, slsmtelp, slsmsupv, slsmphoto, stat FROM salesman WHERE slsmidnumber = @salesmanID";
                salesman = context.db.ExecuteScalar<Salesman>(m_Sql, new { salesmanID });
            }
            catch (Exception ex)
            {
                logger.Error("Error in select query", ex);
            }
            return salesman;
        }
        public Salesman GetSalesmanByCode(string salesmanCode)
        {
            Salesman salesman = null;
            try
            {
                m_Sql = @"SELECT slsmcode, slsmidnumber, slsmname, slsmaddress, slsmtelp, slsmsupv, slsmphoto, stat FROM salesman WHERE slsmcode = @salesmanCode;";
                salesman = context.db.ExecuteScalar<Salesman>(m_Sql, new { salesmanCode });
            }
            catch (Exception ex)
            {
                logger.Error("Error in select query", ex);
            }
            return salesman;
        }
        public IList<Salesman> Search(string key, string value)
        {
            IList<Salesman> list = new List<Salesman>();
            string newValue = "%" + value + "%";

            //Default Key For Search
            if (string.IsNullOrEmpty(key)) key = "slsmCode";            
            try
            {
                m_Sql = @"SELECT slsmcode, slsmidnumber, slsmname, slsmaddress, slsmtelp, slsmsupv, slsmphoto, stat FROM salesman " +
                         "WHERE " + key + " ILIKE @newValue;";

                list = context.db.Query<Salesman>(m_Sql, new { newValue }).ToListSorted();
            }
            catch (Exception ex)
            {
                logger.Error("Terjadi Error, silahkan liat log aktivitas", ex);
            }
            return list;
        }
        #endregion

        #region CRUD Method
        public int Save(Salesman obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO salesman(slsmcode, slsmidnumber, slsmname, slsmaddress, slsmtelp, slsmsupv, slsmphoto, stat)
                          VALUES (@slsmCode, @slsmIdNumber, @slsmName, @slsmAddress, @slsmTelp, @slsmSupv, @slsmPhoto, @stat);";
                result = context.db.Execute(m_Sql, obj);
            }
            catch(Exception ex)
            {
                logger.Error("Insert Record Error", ex);
            }

            return result;
        }
        public int Update(Salesman obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"UPDATE salesman
                          SET slsmidnumber = @slsmIdNumber,
                              slsmname = @slsmName, 
                              slsmaddress = @slsmAddress,   
                              slsmtelp = @slsmTelp, 
                              slsmsupv = @slsmSupv, 
                              slsmphoto = @slsmPhoto, 
                              stat = @stat
                              WHERE slsmCode = @slsmCode";
                result = context.db.Execute(m_Sql, obj);
            }
            catch (Exception ex)
            {
                logger.Error("Update Query Error", ex);
            }
            return result;
        }
        public int Delete(Salesman obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"DELETE FROM salesman WHERE slsmCode = @slsmCode";
                result = context.db.Execute(m_Sql, obj);
            }
            catch (Exception ex)
            {
                logger.Error("Delete Query Error", ex);
            }
            return result;
        }
        #endregion   
    } 
}
