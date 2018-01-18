using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using NUnit.Framework;
using System;

namespace InvoiceOTCUnitTest
{
    [TestFixture]
    public class Log4NetRepoTest
    {
        #region Declaration
        private ILog4NetRepository logRepository;
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            logRepository = new Log4NetRepository();
        }
        #endregion

        #region Methods
        [Test]
        public void SaveLog()
        {
            var logDummy = new Logs
            {
                ClassName = "log4netRepoTest",
                Exception = "Exception",
                LogID = 401,
                Message = "Message",
                MethodName = "SaveLog",
                LogDate = DateTime.Now,
                CreatedBy = "Luthfi",
                Level = "Warning",
                NewValue = "NewValue",
                OldValue = "OldValue"
            };

            Assert.IsNotNull(logDummy);
            logRepository.Save(logDummy);
        }

        [Test]
        public void GetAll()
        {
            var list = logRepository.GetAll();
            Assert.IsNotNull(list);
        }

        [TearDown]
        public void Dispose()
        {

        }
        #endregion
    }
}
