using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;
using log4net.Appender;
using log4net.Core;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.Service
{
    class Log4NetAppender : AppenderSkeleton
    {
        #region Declaration
        SortableBindingList<Logs> m_Log;
        #endregion
        
        protected override void Append(LoggingEvent loggingEvent)
        {
           Log4NetRepository repository = new Log4NetRepository();
           m_Log = repository.GetSortedList();

            // cek nilai custom properties
            var newValue = (loggingEvent.LookupProperty("NewValue") != null) ? loggingEvent.LookupProperty("NewValue").ToString() : string.Empty;
            var oldValue = (loggingEvent.LookupProperty("OldValue") != null) ? loggingEvent.LookupProperty("OldValue").ToString() : string.Empty;
            var createdBy = (loggingEvent.LookupProperty("UserName") != null) ? loggingEvent.LookupProperty("UserName").ToString() : string.Empty;

            var log = new Logs
            {
                Level = loggingEvent.Level.ToString(),
                ClassName = loggingEvent.LocationInformation.ClassName,
                MethodName = loggingEvent.LocationInformation.MethodName,
                Message = loggingEvent.RenderedMessage,
                NewValue = newValue,
                OldValue = oldValue,
                Exception = loggingEvent.GetExceptionString(),
                CreatedBy = createdBy
            };

            // reset nilai property NewValue dan OldValue
            LogicalThreadContext.Properties.Clear();

            // simpan hasil log ke database
            m_Log.Add(log);
            repository.Save(m_Log);
        }
    }
}
