using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using FSCollections;
using System.Windows.Forms;

namespace InvoiceOTC.Repository.Service
{
    public class ProductRepository : IProductRepository
    {
        #region Declaration
        protected ILog m_Log;
        protected string m_Sql;
        protected IDapperContext context;
        #endregion

        #region Constructor
        public ProductRepository()
        {
            context = new DapperContext();
        }
        public ProductRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
        }
        #endregion

        #region Select Methods
        public IList<Product> GetAll()
        {
            IList<Product> listOfProduct = new List<Product>();

            try
            {
                m_Sql = @"SELECT ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat FROM Product";
                listOfProduct = context.db.Query<Product>(m_Sql).ToListSorted();
            }
            catch(Exception ex)
            {
                m_Log.Error("Get Data Failed", ex);
            }

            return listOfProduct;
        }

        public IList<Product> Search(string key, string value)
        {
            IList<Product> listOfProduct = new List<Product>();
            //Little modification to accept value
            string newValue = "%" + value + "%";

            //Set default value if Key isEmpty
            if (string.IsNullOrEmpty(key)) key = "ITEMNAME";

            try
            {
                m_Sql = @"SELECT ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat FROM Product WHERE " + key + " ILIKE @newValue ";
                listOfProduct = context.db.Query<Product>(m_Sql, new { newValue }).ToListSorted();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return listOfProduct;
        }

        public IList<Product> GetActiveProduct()
        {
            IList<Product> listOfProduct = new List<Product>();

            try
            {
                m_Sql = @"SELECT ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat FROM Product WHERE Stat = 't'";
                listOfProduct = context.db.Query<Product>(m_Sql).ToListSorted();
            }
            catch (Exception ex)
            {
                m_Log.Error("Get Data Failed", ex);
            }

            return listOfProduct;
        }

        public Product GetItemByID(string itemCode)
        {
            Product product = null;

            try
            {
                m_Sql = @"SELECT ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat FROM Product " +
                         "WHERE ITEMCODE = @value";
                product = context.db.Query<Product>(m_Sql, new { itemCode }).SingleOrDefault();
            }
            catch
            {

            }

            return product;
        }
        #endregion

        #region CRUD Methods
        public int Delete(Product obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From Product Where ITEMCODE = @itemCode";

                result = context.db.Execute(m_Sql, obj);
            }
            catch(Exception ex)
            {
                m_Log.Error("Delete Error", ex);
            }

            return result;
        }

        public int Save(Product obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO Product " +
                        "(ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat)" +
                        " VALUES " +
                        "(@itemCode, @itemName, @itemSort, @brand, @jenis, @category, @subCategory, @price, @stat)";
                result = context.db.Execute(m_Sql, obj);
            }
            catch(Exception ex)
            {
                m_Log.Error("INSERT ERROR", ex);
            }

            return result;
        }

        public int Update(Product obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"UPDATE Product SET " +
                        "ITEMNAME = @itemName, " +
                        "ITEMSORT = @itemSort, " +
                        "Brand = @brand, " +
                        "Jenis = @jenis, " +
                        "category = @category, " +
                        "subcategory = @subCategory, " +
                        "price = @price, " +
                        "Stat = @stat " +
                        "WHERE ITEMCODE = @itemCode";
                result = context.db.Execute(m_Sql, obj);
            }
            catch(Exception ex)
            {
                m_Log.Error("Update Error", ex);
            }

            return result;
        }
        #endregion
    }
}
