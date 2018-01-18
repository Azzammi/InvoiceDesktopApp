using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSCollections;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    public class Log4NetRepository : ILog4NetRepository
    {
        #region Declaration
        private FSBindingList<Logs> m_LogList;
        #endregion

        #region Constructor
        public Log4NetRepository()
        {
            
        }
        #endregion

        #region  methods
        public FSBindingList<Logs> GetAll()
        {
            FSBindingList<Logs> log = new FSBindingList<Logs>();
            log.Load(System.IO.Directory.GetCurrentDirectory() + "\\Logs.log");
            return log;
        }
        public void Save(Logs data)
        {
            m_LogList = GetAll();
            m_LogList.Add(data);
            m_LogList.Save(System.IO.Directory.GetCurrentDirectory() + "\\Logs.log");
        }
        #endregion
    }
}
