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
    public class InvoiceDetailRepoTest
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

            var getInvoice = invoice.GetInvoiceByNomor("9000");
            var detail = new InvoiceDetail
            {
                invoiceID = getInvoice.invoiceID,
                itemCode = "FG00002",
                itemPrice = 24124124,
                itemQty = 1345345,
                subTotal = 345345,
                discount = 3.3
            };
            var result2 = invoiceDetail.Save(detail);

            Assert.IsTrue(result2 != 0);
        }

        [Test]
        public void EditTest()
        {
            var getInvoice = invoice.GetInvoiceByNomor("9000");
            var detail = getInvoice.detail.First(s => s.invoiceID == getInvoice.invoiceID);
            detail.itemCode = "FG00002";
            detail.itemPrice = 4500;
            detail.itemQty = 100000;
            detail.subTotal = 450000000;
            detail.discount = 2.5;

            var result2 = invoiceDetail.Update(detail);

            Assert.IsTrue(result2 != 0);
        }

        [Test]
        public void RemoveTest()
        {
            var getInvoice = invoice.GetInvoiceByNomor("9000");
            var detail = getInvoice.detail.First(s => s.invoiceID == getInvoice.invoiceID);

            var result = invoiceDetail.Delete(detail);
            Assert.IsTrue(result != 0);

            var result2 = invoice.Delete(getInvoice);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void GetAll()
        {
            var result = invoiceDetail.GetAll();

            Assert.IsNotNull(result);
        }
        #endregion
    }
}
