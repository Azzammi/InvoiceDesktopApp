using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using NUnit.Framework;

namespace InvoiceOTCUnitTest
{
    [TestFixture]
    public class OutletRepoTest
    {
        #region Declaration
        private IOutletRepository m_outlet;
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            m_outlet = new OutletRepository();
        }
        #endregion

        #region TestMethod
        [Test]
        public void AddTest()
        {
            var outlet = new Outlet
            {
                outlSlsm = "slsmtest",
                outlCode = "outlet001",
                outlName = "outletTestName",
                outlAddress = "outlAddressNo.002020",
                outlRoute = "F01",
                outlStat = true
                //outletType = "P & D"
            };

            var result = m_outlet.Save(outlet);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void EditTest()
        {
            var outlet = new Outlet
            {
                outlSlsm = "slsmtest",
                outlCode = "outlet001",
                outlName = "LenovoMart",
                outlAddress = "Griya Asri 2",
                outlRoute = "F33",
                outlStat = false
               // outletType = "Retailer"
            };

            var result = m_outlet.Update(outlet);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void GetAll()
        {
            var outlets = m_outlet.GetAll();
            Assert.IsNotNull(outlets);            
        }

        [Test]
        public void GetBySearch()
        {
            var outlets = m_outlet.Search("OutlCode", "outlet001");

            var index = 0;
            var outlet = outlets[index];

            Assert.IsNotNull(outlets);
            Assert.AreEqual("slsmtest", outlet.outlSlsm);
        }

        [Test]
        public void GetActiveOutlet()
        {
            var outlets = m_outlet.GetActiveOutlet();
            Assert.IsNotNull(outlets);
        }

        [Test]
        public void AddTestGetOutletByCode()
        {
            var outlet= m_outlet.GetOutletByCode("outlet001");

            Assert.AreEqual("outlet001", outlet.outlCode);
            Assert.AreEqual("slsmtest", outlet.outlSlsm);
            Assert.AreEqual("outletTestName", outlet.outlName);
            Assert.AreEqual("outlAddressNo.002020", outlet.outlAddress);
            Assert.AreEqual("F01", outlet.outlRoute);
            Assert.AreEqual(true, outlet.outlStat);
            //Assert.AreEqual("P & D", outlet.outletType);
        }

        [Test]
        public void GetOutletByName()
        {
            var outlet = m_outlet.GetOutletByName("LenovoMart");

            Assert.AreEqual("outlet001", outlet.outlCode);
            Assert.AreEqual("slsmtest", outlet.outlSlsm);
            Assert.AreEqual("LenovoMart", outlet.outlName);
            Assert.AreEqual("Griya Asri 2", outlet.outlAddress);
            Assert.AreEqual("F33", outlet.outlRoute);
            Assert.AreEqual(false, outlet.outlStat);
            //Assert.AreEqual("Retailer", outlet.outletType);
        }

        [Test]
        public void GetOutletBySalesmanId()
        {
            var outlet = m_outlet.GetOutletBySalesmanID("slsmtest");

            Assert.AreEqual("outlet001", outlet.outlCode);
            Assert.AreEqual("slsmtest", outlet.outlSlsm);
            Assert.AreEqual("LenovoMart", outlet.outlName);
            Assert.AreEqual("Griya Asri 2", outlet.outlAddress);
            Assert.AreEqual("F33", outlet.outlRoute);
            Assert.AreEqual(false, outlet.outlStat);
            //Assert.AreEqual("Retailer", outlet.outletType);
        }

        [Test]
        public void RemoveTest()
        {
            var outlCode = "outlet001";
            var outlet = m_outlet.GetOutletByCode(outlCode);

            var result = m_outlet.Delete(outlet);
            Assert.IsTrue(result != 0);

            var outletDeleted= m_outlet.GetOutletByCode(outlCode);
            Assert.IsNull(outletDeleted);
        }

        [TearDown]
        public void Dispose()
        {
            //var outlCode = new Outlet
            //{
            //    outlCode = "outlet001"
            //};

            //var result = m_outlet.Delete(outlCode);
            //Assert.IsTrue(result != 0);
        }
        #endregion
    }
}
