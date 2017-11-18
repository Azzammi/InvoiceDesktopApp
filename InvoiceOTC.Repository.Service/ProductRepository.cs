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
    class ProductRepository : IProductRepository
    {
        #region Declaration
        protected ILog m_Log;
        protected static string m_Sql;
        #endregion

        #region Constructor
        public ProductRepository(ILog log)
        {
            m_Log = log;
        }
        #endregion

        public int Delete(Product obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From ITEM Where ITEMCODE = @itemCode";

                using(IDapperContext context = new DapperContext())
                {
                    result = context.db.Execute(m_Sql, obj);
                }
            }
            catch
            {

            }

            return result;
        }

        public IList<Product> GetAll()
        {
            IList<Product> listOfProduct = new List<Product>();

            try
            {
                m_Sql = @"SELECT ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat FROM [ITEM]";

                using (IDapperContext context = new DapperContext())
                {
                    listOfProduct = context.db.Query<Product>(m_Sql).ToList();
                }
            }
            catch 
            {

            }

            return listOfProduct;
        }

        public Product GetItemByID(string itemCode)
        {
            throw new NotImplementedException();
        }

        public int Save(Product obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO ITEM " +
                        "(ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat)" +
                        " VALUES " +
                        "(@itemCode, @itemName, @itemSort, @brand, @jenis, @category, @subCategory, @price, @stat)";

                using (IDapperContext context = new DapperContext())
                {
                    result = context.db.Execute(m_Sql, obj);
                }

            }
            catch
            {

            }

            return result;
        }

        public int Update(Product obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"UPDATE ITEM SET " +
                        "ITEMNAME = @itemName, " +
                        "ITEMSORT = @itemSort, " +
                        "Brand = @brand, " +
                        "Jenis = @jenis, " +
                        "category = @category, " +
                        "subcategory = @subCategory, " +
                        "price = @price, " +
                        "Stat = @stat " +
                        "WHERE ITEMCODE = @itemCode";
                using (IDapperContext context = new DapperContext())
                {
                    result = context.db.Execute(m_Sql, obj);
                }
            }
            catch
            {

            }

            return result;
        }
    }
}
