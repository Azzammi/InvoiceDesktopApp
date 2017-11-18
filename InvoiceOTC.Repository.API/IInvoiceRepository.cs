using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.API
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
        /// <summary>
        /// Get Invoice by invoice ID
        /// </summary>
        /// <param name="idInvoice"></param>
        /// <returns></returns>
        Invoice GetInvoiceByID(int idInvoice);

        /// <summary>
        /// Get Invoice by Invoice number
        /// </summary>
        /// <param name="nomorInvoice"></param>
        /// <returns></returns>
        Invoice GetInvoiceByNomor(int nomorInvoice);
    }
}
