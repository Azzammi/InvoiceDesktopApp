﻿using System;
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
            throw new NotImplementedException();
        }

        public int Save(Logs obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Logs obj)
        {
            throw new NotImplementedException();
        }

        public void Save(SortableBindingList<Logs> log)
        {
            log.Save(System.IO.Directory.GetCurrentDirectory() + "\\Logs.log");            
        }

        public SortableBindingList<Logs> GetSortedList()
        {
            //  return SortableBindingList<Logs>(GetAll());
            SortableBindingList<Logs> log = new SortableBindingList<Logs>();
            log.Load(System.IO.Directory.GetCurrentDirectory() + "\\Logs.log");
            return log;
        } 
    }
}