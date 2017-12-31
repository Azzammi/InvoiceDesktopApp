using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.API
{
    public interface IInvoiceDetailRepository : IBaseRepository<InvoiceDetail>
    {        
        /// <summary>
        /// Delete all invoice detail based on invoiceID
        /// </summary>
        /// <param name="invoiceID"></param>
        /// <returns></returns>
        int DeleteAll(int invoiceID);        
    }
}
