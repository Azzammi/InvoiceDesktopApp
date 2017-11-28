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
    class InvoiceRepository : IInvoiceRepository
    {
        #region Declaration
        protected string m_Sql;
        protected ILog m_Log;
        protected IDapperContext context;
        #endregion

        #region Constructor
        public InvoiceRepository()
        {
            context = new DapperContext();
        }
        public InvoiceRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
        }
        #endregion

        #region Methods
        public int Delete(Invoice obj)
        {
            throw new NotImplementedException();
        }

        public IList<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoiceByID(int idInvoice)
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoiceByNomor(int nomorInvoice)
        {
            throw new NotImplementedException();
        }

        public IList<InvoiceDetail> GetInvoiceDetail()
        {
            throw new NotImplementedException();
        }

        public int Save(Invoice obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Invoice obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
