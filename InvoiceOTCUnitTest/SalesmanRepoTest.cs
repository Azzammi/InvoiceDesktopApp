using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using NUnit.Framework;

namespace InvoiceOTCUnitTest
{
    [TestFixture]
    class SalesmanRepoTest
    {
        #region Declaration
        private ISalesmanRepository salesmanRepo;
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            salesmanRepo = new SalesmanRepository();
        }
        #endregion

        #region Methods
        [Test]
        public void AddTest()
        {
            var salesman = new Salesman
            {
                slsmCode = "20180001",
                slsmName = "Mamet",
                slsmAddress = "Perum Telaga Murni No.22",
                slsmIdNumber = "31274000001",
                slsmSupv = "Munadi",
                slsmPhoto = "Pgoto",
                slsmTelp = "0882332323"
            };

            var result = salesmanRepo.Save(salesman);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void EditTest()
        {
            var salesman = new Salesman
            {
                slsmCode = "20180001",
                slsmName = "RAHMAT HIDAYAT",
                slsmAddress = "Perum Telaga Murni No.22 rt.2 rW. 69",
                slsmIdNumber = "31274000001",
                slsmSupv = "Munadi",
                slsmPhoto = "tURURURURUR",
                slsmTelp = "888921212"
            };

            var result = salesmanRepo.Update(salesman);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void RemoveTest()
        {
            var salesman = new Salesman
            {
                slsmCode = "20180001"
            };

            var result = salesmanRepo.Delete(salesman);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void GetAll()
        {
            var list = salesmanRepo.GetAll();
            Assert.IsNotNull(list);
        }

        [Test]
        public void Find()
        {
            var listSearch = salesmanRepo.Search("slsmName", "RAHMAT HIDAYAT");
            Assert.IsNotNull(listSearch);
        }

        [TearDown]
        public void Dispose()
        {

        }
        #endregion
    }
}
