using InvoiceOTC.Model;
using System.Collections.Generic;

namespace InvoiceOTC.Repository.API
{
    public interface ISalesOrderRepository : IBaseRepository<SalesOrder>
    {      

        /// <summary>
        /// Get SalesOrder by nomorSO
        /// </summary>
        /// <param name="nomorSO"></param>
        /// <returns></returns>
        SalesOrder GetSOByNomor(string nomorSO);

        /// <summary>
        /// Get List with sorting ability
        /// </summary>
        /// <returns></returns>
        IList<SalesOrder> GetAllSorted();       

        /// <summary>
        /// Get List Of Product to salesorderdetail
        /// </summary>
        /// <param name="listOfSalesOrderDetail"></param>
        /// <returns></returns>
        IList<SalesOrderDetail> GetProducts(IList<SalesOrderDetail> listOfSalesOrderDetail);

        /// <summary>
        /// Get amount for each item ordered
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        decimal GetAmount(SalesOrderDetail obj);

        /// <summary>
        /// Get Total Item Qty
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int GetTotalQty(SalesOrder obj);

        /// <summary>
        /// Get total amount of each item amount
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        decimal GetTotalAmount(SalesOrder obj);
    }
}
