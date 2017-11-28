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

        }
        public void EditTest()
        {
            
        }
        public void GetAll()
        {

        }
        public void RemoveTest()
        {

        }
        #endregion
    }
}
