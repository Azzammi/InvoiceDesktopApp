using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;
using FSCollections;

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
        Invoice GetInvoiceByNomor(string nomorInvoice);

        /// <summary>
        /// Using Custom class to achieve sorting ability. Dapper ORM Multi Mapping One to Many
        /// </summary>
        /// <returns></returns>
        FSBindingList<Invoice> GetAllSorted();

        /// <summary>
        /// Get Total Summary of SubTotal in InvoiceDetail
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        decimal GetSubTotalSum(Invoice data);

        /// <summary>
        /// Get Subtotal for each product
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        void GetSubTotal(InvoiceDetail data);

        decimal GetPPN(Invoice data);

        decimal GetInvoiceNett(Invoice data);
        
        //IList<Invoice> GetInvoicesByNomor(string nomorInvoice);
    }
}
