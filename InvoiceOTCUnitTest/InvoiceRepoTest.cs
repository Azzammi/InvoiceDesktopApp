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
    class InvoiceRepoTest
    {
        #region Declaration
        private IInvoiceRepository invoice;
        private IInvoiceDetailRepository invoiceDetail;
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            invoice = new InvoiceRepository();
            invoiceDetail = new InvoiceDetailRepository();
        }
        #endregion

        #region Methods
        [Test]
        public void AddTest()
        {
            var newInvoice = new Invoice
            {
                nomorInvoice = "9000",
                dueDate = DateTime.Now,
                outletCode = "71390002",
                issuedDate = DateTime.Now,
                subTotal = 2400000232300,
                ppn = 423232323,
                nomorPO = "PS02221",
                isPPN = true,
                pengguna = "admin",
            };

            var result = invoice.Save(newInvoice);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void EditTest()
        {
            //var existingInvoice = invoice.GetInvoiceByNomor("9000");
            var newInvoice = new Invoice
            {
                nomorInvoice = "9077",
                dueDate = DateTime.Now,
                outletCode = "71390002",
                issuedDate = DateTime.Now,
                subTotal = 98092384093444,
                ppn = 0,
                nomorPO = "PS02221",
                isPPN = false,
                pengguna = "System",
            };

            var result = invoice.Update(newInvoice);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void RemoveTest()
        {

        }
        #endregion
    }
}
