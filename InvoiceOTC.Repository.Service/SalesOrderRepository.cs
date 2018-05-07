using System;
using System.Collections.Generic;
using System.Linq;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    public class SalesOrderRepository : ISalesOrder
    {
        public int Delete(SalesOrder obj)
        {
            throw new NotImplementedException();
        }

        public IList<SalesOrder> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Save(SalesOrder obj)
        {
            throw new NotImplementedException();
        }

        public IList<SalesOrder> Search(string key, string value)
        {
            throw new NotImplementedException();
        }

        public int Update(SalesOrder obj)
        {
            throw new NotImplementedException();
        }
    }
}
