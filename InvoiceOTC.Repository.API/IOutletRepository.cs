using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.API
{
    public interface IOutletRepository : IBaseRepository<Outlet>
    {
        /// <summary>
        /// Get Outlet By Outlet Code
        /// </summary>
        /// <param name="outletCode"></param>
        /// <returns></returns>
        Outlet GetOutletByCode(int outletCode);

        /// <summary>
        /// Get Outlet by Salesman
        /// </summary>
        /// <param name="salesmanCode"></param>
        /// <returns></returns>
        Outlet GetOutletBySalesmanID(int salesmanCode);

        /// <summary>
        /// Get Outlet by outlet name
        /// </summary>
        /// <param name="outletName"></param>
        /// <returns></returns>
        Outlet GetOutletByName(string outletName);
    }
}
