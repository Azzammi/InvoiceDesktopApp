using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using NUnit.Framework;
using System;

namespace InvoiceOTCUnitTest
{
    [TestFixture]
    class SalesOrderRepoTest
    {
        /* The method name when running is still by methud name asc, cause of Nunit Bug */

        #region Declaration
        private SalesOrderRepository soRepo;
        private IProductRepository productRepo;    
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            soRepo = new SalesOrderRepository();
            productRepo = new ProductRepository();    
        }
        #endregion

        #region Test Method
        [Test]
        public void GetAll()
        {
            var salesOrders = soRepo.GetAll();

            var index = 0;
            var salesorder = salesOrders[index];

            Assert.IsNotNull(salesOrders);
        }
        [Test]
        public void GetBySearch()
        {

        } 
        [Test]
        public void AddTest()
        {
            //var product = new Product
            //{
            //    itemCode = "TST00001",
            //    itemName = "TEST UNIT",
            //    itemSort = "TST",
            //    brand = "Tester",
            //    category = "Testing",
            //    subCategory = "UnitTest",
            //    price = 199999999999,
            //    stat = true
            //};
            //var result = productRepo.Save(product);
            //Assert.IsTrue(result != 0);

            var salesOrderDetail = new SalesOrderDetail
            {
                nomorSO = "SO3233300222",
                itemCode = "TST00001",
                itemName = "TEST UNIT",
                qtyOrder = 10,
                amount = 120000,
                manualRef = "",               
            };

            var salesOrder = new SalesOrder
            {
                manualRef = "20051233",
                accountRef = "AR1000332",
                nomorSO = "SO3233300222",
                soDate = DateTime.MaxValue,
                soCreated = DateTime.Now,
                qtyOrder = 233,
                totalAmount = 13332323,
                otherRef = "DIRECT SELLING",                
            };

            var salesOrder2 = new SalesOrder
            {
                manualRef = "20051233",
                accountRef = "AR1000332",
                nomorSO = "SO3233300223",
                soDate = DateTime.MaxValue,
                soCreated = DateTime.Now,                
                qtyOrder = 1012,
                totalAmount = 19993000,
                otherRef = "DIRECT SELLING"
            };

            var salesOrder_result = soRepo.Save(salesOrder);
            Assert.IsTrue(salesOrder_result != 0);

            var salesOrder2_result = soRepo.Save(salesOrder2);
            Assert.IsTrue(salesOrder2_result != 0);

            var salesOrderDetail_result = soRepo.Save(salesOrderDetail);
            Assert.IsTrue(salesOrderDetail_result != 0);
        }
        [Test]
        public void EditTest()
        {
            var salesOrder = soRepo.GetSOByNomor("SO3233300222");
            salesOrder.manualRef = "20051233";
            salesOrder.accountRef = "AR1000332";            
            salesOrder.soDate = DateTime.MaxValue;
            salesOrder.soCreated = DateTime.Now;            
            salesOrder.outlCode = "73299300";
            salesOrder.outlName = "SALESMANNAME";
            salesOrder.qtyOrder = 44;
            salesOrder.otherRef = "DIRECT SELLING";


            var salesOrder2 = soRepo.GetSOByNomor("SO3233300223");
            salesOrder2.manualRef = "20051233";
            salesOrder2.accountRef = "AR1000332";            
            salesOrder2.soDate = DateTime.MaxValue;
            salesOrder2.soCreated = DateTime.Now;
            salesOrder2.outlCode = "73299300";
            salesOrder2.outlName = "SALESMANNAME";
            salesOrder2.qtyOrder = 190;
            salesOrder2.otherRef = "DIRECT SELLING";
            

            var result = soRepo.Update(salesOrder);
            Assert.IsTrue(result != 0);

            var result2 = soRepo.Update(salesOrder2);
            Assert.IsTrue(result2 != 0);
        }
        [Test]
        public void RemoveTest()
        {
            var salerOrderDetail = new SalesOrderDetail
            {
                itemCode = "TST00001",
                nomorSO = "SO3233300222"
            };

            var salesOrder = soRepo.GetSOByNomor("SO3233300222");
            var salesOrder2 = soRepo.GetSOByNomor("SO3233300223");

            var result = soRepo.Delete(salesOrder);
            Assert.IsTrue(result != 0);

            var result2 = soRepo.Delete(salesOrder2);
            Assert.IsTrue(result2 != 0);

            var result3 = soRepo.Delete(salerOrderDetail);
            Assert.IsTrue(result3 != 0);
        }
        #endregion
    }
}
