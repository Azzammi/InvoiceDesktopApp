using System.Collections.Generic;
using System.Linq;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using FSCollections;

namespace InvoiceOTC.Repository.Service
{
    public class OutletRepository : IOutletRepository
    {
        #region Declaration
        protected ILog m_Log;
        protected string m_Sql;
        protected IDapperContext context;
        #endregion

        #region Constructor
        public OutletRepository()
        {
            context = new DapperContext();
        }
        public OutletRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
        }
        #endregion

        #region Select Methods
        public IList<Outlet> GetAll()
        {
            IList<Outlet> list = new List<Outlet>();
            try
            {
                m_Sql = @"SELECT OUTLCODE,OUTLNAME,OUTLADDRESS,OUTLSLSM,OUTLROUTE,OUTLSTAT FROM OUTLET";
                list = context.db.Query<Outlet>(m_Sql).ToListSorted();

            }
            catch
            {

            }
            return list;
        }

        public Outlet GetOutletByCode(string outletCode)
        {
            Outlet outlet = null;
            try
            {
                m_Sql = @"SELECT OUTLCODE,OUTLNAME,OUTLADDRESS,OUTLSLSM,OUTLROUTE,OUTLSTAT FROM OUTLET" +
                        " WHERE OUTLCODE = @outletCode";

                outlet = context.db.Query<Outlet>(m_Sql, new { outletCode }).SingleOrDefault();
            }
            catch
            {

            }
            return outlet;
        }

        public Outlet GetOutletByName(string outletName)
        {
            Outlet outlet = null;
            try
            {
                m_Sql = @"SELECT OUTLCODE,OUTLNAME,OUTLADDRESS,OUTLSLSM,OUTLROUTE,OUTLSTAT FROM OUTLET" +
                        " WHERE OUTLNAME = @outletName";

                outlet = context.db.Query<Outlet>(m_Sql, new { outletName }).SingleOrDefault();
            }
            catch
            {

            }
            return outlet;
        }

        public Outlet GetOutletBySalesmanID(string slsmCode)
        {
            Outlet outlet = null;
            try
            {
                m_Sql = @"SELECT OUTLCODE,OUTLNAME,OUTLADDRESS,OUTLSLSM,OUTLROUTE,OUTLSTAT FROM OUTLET" +
                        " WHERE OUTLSLSM = @slsmCode";

                outlet = context.db.Query<Outlet>(m_Sql, new { slsmCode }).SingleOrDefault();
            }
            catch
            {

            }
            return outlet;
        }

        public IList<Outlet> Search(string key, string value)
        {
            IList<Outlet> list = new List<Outlet>();
            string newValue = "%" + value + "%";

            //Set default value if Key isEmpty
            if (string.IsNullOrEmpty(key)) key = "ITEMNAME";

            try
            {
                m_Sql = @"SELECT outlcode, outlname, outladdress, outlslsm, outlroute, outlstat FROM outlet WHERE " + key + " ILIKE @newValue";

                list = context.db.Query<Outlet>(m_Sql, new { newValue }).ToListSorted();
            }
            catch
            {

            }
            return list;
        }

        public IList<Outlet> GetActiveOutlet()
        {
            IList<Outlet> list = new List<Outlet>();
            try
            {
                m_Sql = @"SELECT OUTLCODE,OUTLNAME,OUTLADDRESS,OUTLSLSM,OUTLROUTE,OUTLSTAT FROM OUTLET WHERE OUTLSTAT = 't'";
                list = context.db.Query<Outlet>(m_Sql).ToListSorted();

            }
            catch
            {

            }
            return list;
        }
        #endregion

        #region CRUD Methods
        public int Delete(Outlet obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From Outlet Where OutlCode = @outlCode";

                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }
            return result;
        }      

        public int Save(Outlet obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO OUTLET " +
                        "(OutlCode, OutlName, OutlAddress, OutlSlsm, OutlRoute, OutlStat)" +
                        " VALUES " +
                        "(@outlCode, @outlName, @outlAddress, @outlSlsm, @outlRoute, @OutlStat)";
                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }
            return result;
        }

        public int Update(Outlet obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"UPDATE OUTLET SET " +
                        "OutlName = @outlName, " +
                        "OutlAddress = @outlAddress, " +
                        "OutlSlsm = @outlSlsm, " +
                        "OutlRoute = @outlRoute, " +
                        "OutlStat = @outlStat " +
                        "WHERE OutlCode = @outlCode";
                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }
            return result;
        }
        #endregion
    }
}
