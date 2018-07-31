using System;
using System.Collections.Generic;
using System.Linq;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using System.Data.SqlClient;
using FSCollections;
using System.Windows.Forms;

using Npgsql;

namespace InvoiceOTC.Repository.Service
{
    public class SalesOrderRepository : ISalesOrderRepository, ISalesOrderDetailRepository
    {
        #region Declaration
        protected ILog m_Log;
        protected string m_Sql;
        protected IDapperContext context;
        #endregion

        #region Constructor
        public SalesOrderRepository()
        {
            context = new DapperContext();
        }
        public SalesOrderRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
        }
        #endregion

        #region Select Method
        public IEnumerable<SalesOrder> MappingRecordToObj(string sql, object param = null)
        {
            IEnumerable<SalesOrder> listOfSalesOrder = null;
            try
            {
                var salesOrder = new Dictionary<int, SalesOrder>();

                listOfSalesOrder = context.db.Query<SalesOrder, SalesOrderDetail, SalesOrder>(
                        sql,
                        (SalesOrder, SalesOrderDetail) =>
                        {
                            SalesOrder salesOrderEntry;

                            if (!salesOrder.TryGetValue(SalesOrder.salesorderId, out salesOrderEntry))
                            {
                                salesOrderEntry = SalesOrder;
                                salesOrderEntry.detail = new List<SalesOrderDetail>();                                
                                salesOrder.Add(salesOrderEntry.salesorderId, salesOrderEntry);
                            }

                            salesOrderEntry.detail.Add(SalesOrderDetail);
                            return salesOrderEntry;
                        }, param,
                        splitOn: "nomorSO")
                    .Distinct();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listOfSalesOrder;
        }

        public IEnumerable<SalesOrder> MappingRecordToObjSorted(string sql, object param = null)
        {
            IEnumerable<SalesOrder> listOfSalesOrder = null;
            try
            {
                var salesOrderDictionary = new Dictionary<int, SalesOrder>();

                listOfSalesOrder = context.db.Query<SalesOrder, SalesOrderDetail, SalesOrder>(
                        sql,
                        (SalesOrder, SalesOrderDetail) =>
                        {
                            SalesOrder salesOrderEntry;

                            if (!salesOrderDictionary.TryGetValue(SalesOrder.salesorderId, out salesOrderEntry))
                            {
                                salesOrderEntry = SalesOrder;                               
                                salesOrderEntry.detail = new List<SalesOrderDetail>();
                                salesOrderEntry.p_Items = new FSBindingList<SalesOrderDetail>(salesOrderEntry.detail);
                                salesOrderDictionary.Add(salesOrderEntry.salesorderId, salesOrderEntry);
                            }

                            salesOrderEntry.detail.Add(SalesOrderDetail);
                            return salesOrderEntry;
                        }, param,
                        splitOn: "salesOrderID")
                    .Distinct();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listOfSalesOrder;
        }

        public IList<SalesOrder> Search(string key, string value)
        {
            IList<SalesOrder> listOfSalesOrder = new List<SalesOrder>();
            //Search Value
            string newValue = "%" + value + "%";

            //Set default paramater if empty
            if (string.IsNullOrEmpty(key)) key = "nomorso";

            try
            {
                m_Sql = @"SELECT * FROM salesorder AS A LEFT OUTER JOIN salesorderdetail AS B ON A.nomorSO = B.NomorSO ORDER BY A.nomorSO ASC
                            WHERE " + key + " ILIKE @newValue;";
                listOfSalesOrder = MappingRecordToObj(m_Sql,new { newValue }).ToList();
            }
            catch (SqlException ex)
            {
                m_Log.Error("Get Data Failed", ex);
            }
            return listOfSalesOrder;
        }

        public IList<SalesOrder> GetAll()
        {
            IList<SalesOrder> listOfSalesOrder = new List<SalesOrder>();
            try
            {
                m_Sql = @"SELECT * FROM salesorder AS A LEFT OUTER JOIN salesorderdetail AS B ON A.nomorSO = B.NomorSO ORDER BY A.nomorSO ASC;";
                listOfSalesOrder = MappingRecordToObj(m_Sql).ToList();
            }
            catch (NpgsqlException ex)
            {
                m_Log.Error("Get Data Failed", ex);
            }
            return listOfSalesOrder;
        }

        public IList<SalesOrder> GetAllSorted()
        {
            IList<SalesOrder> listOfSalesOrder = new List<SalesOrder>();
            try
            {
                m_Sql = @"SELECT * FROM salesorder AS A LEFT OUTER JOIN salesorderdetail AS B ON A.nomorSO = B.NomorSO ORDER BY A.nomorSO ASC;";
                listOfSalesOrder = MappingRecordToObj(m_Sql).ToList();
            }
            catch (NpgsqlException ex)
            {
                m_Log.Error("Get Data Failed", ex);
            }
            return listOfSalesOrder;
        }

        public SalesOrder GetSOByNomor(string nomorSO)
        {
            SalesOrder salesOrder = null;
            try
            {
                m_Sql = @"SELECT salesorderid, manualref, accountref, socreated, sodate, outlCode, 
                            outlName, qtyorder, totalamount, otherref, nomorso
                            FROM public.salesorder WHERE nomorso = @nomorSO;";
                salesOrder = context.db.Query<SalesOrder>(m_Sql, new { nomorSO }).SingleOrDefault();
            }
            catch(NpgsqlException ex)
            {
                m_Log.Error("Get Salerorder Error !", ex);
            }
            return salesOrder;
        }
        #endregion

        #region Other Methods
        public IList<SalesOrderDetail>GetProducts(IList<SalesOrderDetail> listOfSalesOrderDetail)
        {            
            IList<Product> listOfProduct = new List<Product>();
            IList<SalesOrderDetail> newSalesOrderDetail = new List<SalesOrderDetail>();

            try
            {
                m_Sql = @"SELECT ITEMCODE, ITEMNAME, Price FROM Products";
                listOfProduct = context.db.Query<Product>(m_Sql).ToListSorted();

                foreach(Product product in listOfProduct)
                {
                    var emptySODetail = new SalesOrderDetail
                    {   
                        itemCode = product.itemCode,
                        itemName = product.itemName,
                        itemPrice = product.price
                    };                    

                    if (listOfSalesOrderDetail != null)
                    {                        
                        var existingSODetail = listOfSalesOrderDetail.SingleOrDefault(soDetail => soDetail.itemCode == emptySODetail.itemCode);
                        if (existingSODetail != null) 
                        {
                            // Jika item sudah ada, maka biarkan apa adanya
                            newSalesOrderDetail.Add(existingSODetail);
                        }
                        else
                        {
                            newSalesOrderDetail.Add(emptySODetail);
                        }                        
                    }
                    else
                    { 
                        newSalesOrderDetail.Add(emptySODetail);                        
                    }                    
                }
                listOfSalesOrderDetail = newSalesOrderDetail;
            }
            catch (NpgsqlException ex)
            {
                m_Log.Error("Get Data Failed", ex);
            }

            return listOfSalesOrderDetail;
        }
        #endregion

        #region CRUD Method
        public int Delete(SalesOrder obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From SalesOrder WHERE salesorderID = @salesorderID";
                result = context.db.Execute(m_Sql, obj);
            }
            catch (NpgsqlException ex)
            {
                m_Log.Error("Delete Sales Order Error",ex);
            }
            return result;
        }
        public int Save(SalesOrder obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO salesorder(manualref, accountref, socreated, sodate, outlCode, outlName, qtyorder, totalamount, otherref, nomorso)
                          VALUES
                          (@manualRef, @accountRef, @soCreated, @soDate, @outlCode, @outlName, @qtyOrder, @totalAmount, @otherRef, @nomorSO);";
                result = context.db.Execute(m_Sql, obj);

                foreach(SalesOrderDetail item in obj.p_Items)
                {
                    if(item.qtyOrder != 0)
                    {
                        item.manualRef = obj.manualRef;
                        item.nomorSO = obj.nomorSO;                        
                        Save(item);
                    }
                    else
                    {
                        obj.p_Items.Remove(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                m_Log.Error("Insert new SalesOrder Error", ex);
            }
            return result;
        }
        public int Update(SalesOrder obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"UPDATE public.salesorder
                        SET manualref = @manualRef, 
                            accountref= @accountRef, 
                            socreated = @soCreated, 
                            sodate    = @soDate,    
                            outlCode  = @outlCode,
                            outlName  = @outlName,                         
                            qtyorder  = @qtyOrder, 
                            totalAmount = @totalAmount,
                            otherref  = @otherref, 
                            nomorso   = @nomorSO
                            WHERE salesOrderID = @salesorderID;";
                result = context.db.Execute(m_Sql, obj);

                foreach(SalesOrderDetail item in obj.p_Items)
                {
                    if (item.qtyOrder != 0)
                    {
                        item.manualRef = obj.manualRef;
                        item.nomorSO = obj.nomorSO;
                        Save(item);
                    }
                    else
                    {
                        obj.p_Items.Remove(item);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                m_Log.Error("Update Sales Order Error", ex);
            }
            return result;
        }

        public int Delete(SalesOrderDetail obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From SalesOrderDetail WHERE soDetailID = @soDetailID";
                result = context.db.Execute(m_Sql, obj);
            }
            catch (SqlException ex)
            {
                m_Log.Error("Delete Sales Order Error", ex);
            }
            return result;
        }
        public int Save(SalesOrderDetail obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO public.salesorderdetail(soDetailid, manualref,itemcode, itemname, qtyorder, amount, nomorso)
                          VALUES
                          (@soDetailid, @manualRef, @itemCode, @itemName, @qtyOrder, @amount, @nomorSO);";
                result = context.db.Execute(m_Sql, obj);
                //If data already exist then update
                if (result == 0) result = Update(obj);
            }
            catch (SqlException ex)
            {
                m_Log.Error("Insert new SalesOrder Error", ex);
            }
            return result;
        }
        public int Update(SalesOrderDetail obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"UPDATE public.salesorderdetail
                        SET manualref = @manualRef,                                                        
                            itemcode  = @itemCode, 
                            itemname  = @itemName, 
                            qtyorder  = @qtyOrder, 
                            amount    = @amount, 
                            nomorso   = @nomorSO
                            WHERE soDetailID = @soDetailID;";
                result = context.db.Execute(m_Sql, obj);
            }
            catch (SqlException ex)
            {
                m_Log.Error("Update Sales Order Error", ex);
            }
            return result;
        }
        #endregion

        #region Count Method
        public decimal GetAmount(SalesOrderDetail obj)
        {
            decimal result = 0;
            if(obj != null)
            {
                result += obj.qtyOrder * obj.itemPrice;
            }
            obj.amount = result;
            return result;
        }
        public int GetTotalQty(SalesOrder obj)
        {
            int result = 0;
            foreach(SalesOrderDetail detail in obj.p_Items)
            {
                result += detail.qtyOrder;
            }
            obj.qtyOrder = result;
            return result;
        }
        public decimal GetTotalAmount(SalesOrder obj)
        {
            decimal result = 0;
            foreach (SalesOrderDetail detail in obj.p_Items)
            {                
                result += GetAmount(detail);
            }
            obj.totalAmount = result;
            return result;
        }
        #endregion
    }
}
