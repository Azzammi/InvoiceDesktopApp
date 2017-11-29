using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using FSCollections;
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
                slsmCode = "slsmtest",
                outletCode = "outlet001",
                outletName = "outletTestName",
                outletAddress = "outletAddressNo.002020",
                outletRoute = "F01",
                outletStatus = true
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
                slsmCode = "slsmtest",
                outletCode = "outlet001",
                outletName = "LenovoMart",
                outletAddress = "Griya Asri 2",
                outletRoute = "F33",
                outletStatus = false
               // outletType = "Retailer"
            };

            var result = m_outlet.Update(outlet);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void GetAll()
        {
            var outlets = m_outlet.GetAll();

            var index = 0;
            var outlet = outlets[index];

            Assert.IsNotNull(outlets);
            Assert.AreEqual("outlet001", outlet.outletCode);
            Assert.AreEqual("slsmtest", outlet.slsmCode);
            Assert.AreEqual("LenovoMart", outlet.outletName);
            Assert.AreEqual("Griya Asri 2", outlet.outletAddress);
            Assert.AreEqual("F33", outlet.outletRoute);
            Assert.AreEqual(false, outlet.outletStatus);
            //Assert.AreEqual("Retailer", outlet.outletType);
        }

        [Test]
        public void AddTestGetOutletByCode()
        {
            var outlet= m_outlet.GetOutletByCode("outlet001");

            Assert.AreEqual("outlet001", outlet.outletCode);
            Assert.AreEqual("slsmtest", outlet.slsmCode);
            Assert.AreEqual("outletTestName", outlet.outletName);
            Assert.AreEqual("outletAddressNo.002020", outlet.outletAddress);
            Assert.AreEqual("F01", outlet.outletRoute);
            Assert.AreEqual(true, outlet.outletStatus);
            //Assert.AreEqual("P & D", outlet.outletType);
        }

        [Test]
        public void EditTestGetOutletByName()
        {
            var outlet = m_outlet.GetOutletByName("LenovoMart");

            Assert.AreEqual("outlet001", outlet.outletCode);
            Assert.AreEqual("slsmtest", outlet.slsmCode);
            Assert.AreEqual("LenovoMart", outlet.outletName);
            Assert.AreEqual("Griya Asri 2", outlet.outletAddress);
            Assert.AreEqual("F33", outlet.outletRoute);
            Assert.AreEqual(false, outlet.outletStatus);
            //Assert.AreEqual("Retailer", outlet.outletType);
        }

        [Test]
        public void EditTestGetOutletBySalesmanId()
        {
            var outlet = m_outlet.GetOutletBySalesmanID("slsmtest");

            Assert.AreEqual("outlet001", outlet.outletCode);
            Assert.AreEqual("slsmtest", outlet.slsmCode);
            Assert.AreEqual("LenovoMart", outlet.outletName);
            Assert.AreEqual("Griya Asri 2", outlet.outletAddress);
            Assert.AreEqual("F33", outlet.outletRoute);
            Assert.AreEqual(false, outlet.outletStatus);
            //Assert.AreEqual("Retailer", outlet.outletType);
        }

        [Test]
        public void RemoveTest()
        {
            var outletCode = "outlet001";
            var outlet = m_outlet.GetOutletByCode(outletCode);

            var result = m_outlet.Delete(outlet);
            Assert.IsTrue(result != 0);

            var outletDeleted= m_outlet.GetOutletByCode(outletCode);
            Assert.IsNull(outletDeleted);
        }

        [TearDown]
        public void Dispose()
        {

        }
        #endregion
    }
}
