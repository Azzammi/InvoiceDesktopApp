using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using NUnit.Framework;

namespace InvoiceOTCUnitTest
{
    [TestFixture]
    public class ProductRepoTest
    {
        /* The method name still random cause of Nunit Bug */

        #region Declaration
        private IProductRepository m_product;
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            m_product = new ProductRepository();
        }
        #endregion

        #region TestMethod
        [Test]
        public void GetAll()
        {
            var products = m_product.GetAll();

            var index = 0;
            var product = products[index];

            Assert.IsNotNull(products);
            //Assert.AreEqual("TST00001", product.itemCode.Trim());
            //Assert.AreEqual("ROTI TAWAR SPESIAL", product.itemName.Trim());
            //Assert.AreEqual("RTS", product.itemSort.Trim());
            //Assert.AreEqual("SARI ROTI", product.brand.Trim());
            //Assert.AreEqual("BREAD", product.jenis.Trim());
            //Assert.AreEqual("WHITE BREAD", product.category.Trim());
            //Assert.AreEqual("TAWAR SERIES", product.subCategory.Trim());
            //Assert.AreEqual(12000, product.price);
            //Assert.AreEqual(false, product.stat);
        }

        [Test]
        public void AddTest()
        {
            var product = new Product
            {
                itemCode = "TST00001",
                itemName = "TEST UNIT",
                itemSort = "TST",
                brand = "Tester",
                category = "Testing",
                subCategory = "UnitTest",
                price = 199999999999,
                stat = true
            };

            var result = m_product.Save(product);
            Assert.IsTrue(result != 0);

            var productBaru = m_product.GetItemByID(product.itemCode);
            Assert.AreEqual("TST00001", productBaru.itemCode);
            Assert.AreEqual("TEST UNIT", productBaru.itemName);
            Assert.AreEqual("TST", productBaru.itemSort.Trim());
            Assert.AreEqual("Tester", productBaru.brand);
            Assert.AreEqual("Testing", productBaru.category);
            Assert.AreEqual("UnitTest", productBaru.subCategory);
            Assert.AreEqual(199999999999, productBaru.price);
            Assert.AreEqual(true, productBaru.stat);
        }

        [Test]
        public void EditTest()
        {
            var product = new Product
            {
                itemCode = "TST00001",
                itemName = "TEST UNIT UPDATE",
                itemSort = "UPD",
                brand = "Tester Update",
                category = "Testing Update",
                subCategory = "UnitTest Update",
                price = 242409290829048,
                stat = false
            };

            var result = m_product.Update(product);
            Assert.IsTrue(result != 0);

            var productBaru = m_product.GetItemByID(product.itemCode);
            Assert.AreEqual("TST00001", productBaru.itemCode);
            Assert.AreEqual("TEST UNIT UPDATE", productBaru.itemName);
            Assert.AreEqual("UPD", productBaru.itemSort.Trim());
            Assert.AreEqual("Tester Update", productBaru.brand);
            Assert.AreEqual("Testing Update", productBaru.category);
            Assert.AreEqual("UnitTest Update", productBaru.subCategory);
            Assert.AreEqual(242409290829048, productBaru.price);
            Assert.AreEqual(false, productBaru.stat);
        }

        [Test]
        public void RemoveTest()
        {
            var itemCode = "TST00001";
            var product = m_product.GetItemByID(itemCode);

            var result = m_product.Delete(product);
            Assert.IsTrue(result != 0);

            var productDeleted = m_product.GetItemByID(itemCode);
            Assert.IsNull(productDeleted);
        }

        [TearDown]
        public void Dispose()
        {
           
        }
        #endregion

    }
}
