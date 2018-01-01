using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using System.Windows.Forms;

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

        #region Select Methods
        public IList<InvoiceDetail> Search(string key, string value)
        {
            throw new NotImplementedException();
        }
        public IList<InvoiceDetail> GetAll()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CRUD Methods
        public int Delete(InvoiceDetail obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From InvoiceDetail Where invoiceID = @invoiceID and itemCode = @itemCode";

                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }

            return result;
        }

        public int Save(InvoiceDetail obj)
        {
            if (obj.itemCode == null) return 0;

            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO invoicedetail(
                         invoiceid, itemcode, itemqty, discount, itemprice, subtotal)
                         VALUES (@invoiceID, @itemCode, @itemQty, @discount, @itemPrice, @subTotal);";
                result = context.db.Execute(m_Sql, obj);
                if (result == 0) result = Update(obj);
            }
            catch
            {
                result = Update(obj);
            }

            return result;
        }

        public int Update(InvoiceDetail obj)
        {
            var result = 0;

            try
            {
                m_Sql = @"UPDATE invoicedetail SET                                                                   
                        itemqty = @itemQty, 
                        discount = @discount, 
                        itemprice= @itemPrice, 
                        subtotal= @subTotal
                        WHERE invoiceID = @invoiceID and itemCode = @itemCode;";
                result = context.db.Execute(m_Sql, obj);
            }
            catch
            {

            }

            return result;
        }

        public int DeleteAll(int invoiceID)
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
        #endregion

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
