using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    public class InvoiceDetailRepository : IInvoiceDetailRepository
    {
        #region Declaration
        protected string m_Sql;
        protected ILog m_Log;
        protected IDapperContext context;
        #endregion

        #region Constructor
        public InvoiceDetailRepository()
        {
            context = new DapperContext();
        }
        public InvoiceDetailRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
        }
        #endregion


        #region Methods

        #endregion
        public int Delete(InvoiceDetail obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From InvoiceDetail Where rotiID = @p_ID";

                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }

            return result;
        }

        public IList<InvoiceDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Save(InvoiceDetail obj)
        {
            throw new NotImplementedException();
        }

        public int Update(InvoiceDetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
