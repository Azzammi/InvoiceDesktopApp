﻿using System;
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
        
        IList<Invoice> GetInvoicesByNomor(string nomorInvoice);
    }
}
