using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    class Log4NetRepository : ILog4NetRepository
    {
        public int Delete(Logs obj)
        {
            throw new NotImplementedException();
        }

        public IList<Logs> GetAll()
        {
            SortableBindingList<Logs> log;
            log.Load("")
        }

        public int Save(Logs obj)
        {
            var result = 0;
            SortableBindingList<Logs> log = new SortableBindingList<Logs>(GetAll());
        }

        public int Update(Logs obj)
        {
            throw new NotImplementedException();
        }

        public SortableBindingList<Logs> GetSortedList()
        {
          //  return SortableBindingList<Logs>(GetAll());
        } 
    }
}
