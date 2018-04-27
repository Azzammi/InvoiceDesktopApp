using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.API
{
    public interface ISalesmanRepository : IBaseRepository<Salesman>
    {
        /// <summary>
        /// Get Salesman by salesman id
        /// </summary>
        /// <param name="salesmanID"></param>
        /// <returns></returns>
        Salesman GetSalesmanByID(int salesmanID);

        /// <summary>
        /// Get Salesman by sales name
        /// </summary>
        /// <param name="salesmanCode"></param>
        /// <returns></returns>
        Salesman GetSalesmanByCode(string salesmanCode);
    }
}
