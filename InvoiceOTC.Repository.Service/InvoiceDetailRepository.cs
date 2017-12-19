using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

namespace InvoiceOTC.Repository.Service
{
    public class InvoiceDetailRepository : IInvoiceDetailRepository
    {
        #region Declaration
        protected string m_Sql;
        protected ILog m_Log;
        protected IDapperContext context;
        #endregion

        #region Constructor
        public InvoiceDetailRepository()
        {
            context = new DapperContext();
        }
        public InvoiceDetailRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
        }
        #endregion


        #region Methods

        #endregion
        public int Delete(InvoiceDetail obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From InvoiceDetail Where detailID = @detailID";

                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }

            return result;
        }

        public IList<InvoiceDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Save(InvoiceDetail obj)
        {
            var result = 0;         
            try
            {
                m_Sql = @"INSERT INTO invoicedetail(
                         invoiceid, itemcode, itemqty, discount, itemprice, subtotal)
                         VALUES (@invoiceID, @itemCode, @itemQty, @discount, @itemPrice, @subTotal);";
                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }

            return result;
        }

        public int Update(InvoiceDetail obj)
        {
            var result = 0;   

            try
            {
                m_Sql = @"UPDATE invoicedetail SET 
                        detailID = @detailID,                          
                        itemcode = @itemCode, 
                        itemqty = @itemQty, 
                        discount = @discount, 
                        itemprice= @itemPrice, 
                        subtotal= @subTotal
                        WHERE invoiceID = @invoiceID;";
                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }

            return result;
        }

        public int Save(int invoiceID, InvoiceDetail obj)
        {
            var result = 0;
            obj.invoiceID = invoiceID;

            try
            {
                m_Sql = @"INSERT INTO invoicedetail(
                        detailID, invoiceid, itemcode, itemqty, discount, itemprice, subtotal)
                         VALUES (@invoiceID, @itemCode, @itemQty, @discount, @itemPrice, @subTotal);";
                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }

            return result;
        }

        public int Delete(int invoiceID)
        {
            var result = 0;           

            try
            {
                m_Sql = @"DELETE FROM InvoiceDetail WHERE invoiceID = @invoiceID;";
                result = context.db.Execute(m_Sql, new { invoiceID });
            }
            catch
            {

            }

            return result;
        }

        //public InvoiceDetail GetInvoiceDetailByItemCode(int invoiceID, string itemCode)
        //{
        //    InvoiceDetail detail = null;
        //    try
        //    {
        //        m_Sql = "SELECT * FRO"
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
