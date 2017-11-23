using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

namespace InvoiceOTCUnitTest
{
    [TestFixture]
    public class DapperContextTest
    {
        #region Declaration
        private IDapperContext context;
        #endregion

        #region Declaration
        [SetUp]
        public void Init()
        {
            
        }
        #endregion

        #region Method Test
        [Test]
        public void OpenConnection()
        {
            context = new DapperContext();
            
            Assert.IsNotNull(context);
            Assert.AreEqual(System.Data.ConnectionState.Open, context.db.State);
        }

        [Test]
        public void LogConnection()
        {
            context = new DapperContext(true);

            Assert.IsNotNull(context);
            Assert.AreEqual(System.Data.ConnectionState.Open, context.db.State);
        }
        #endregion
    }
}
