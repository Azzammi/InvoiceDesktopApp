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
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            invoice = new InvoiceRepository();            
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
            var existingInvoice = invoice.GetInvoiceByNomor("9000");
            existingInvoice.nomorInvoice = "9077";
            existingInvoice.dueDate = DateTime.Now;
            existingInvoice.outletCode = "71390002";
            existingInvoice.issuedDate = DateTime.Now;
            existingInvoice.subTotal = 98092384093444;
            existingInvoice.ppn = 0;
            existingInvoice.nomorPO = "PS02221";
            existingInvoice.isPPN = false;
            existingInvoice.pengguna = "System";
            existingInvoice.isPayed = true;
            

            var result = invoice.Update(existingInvoice);
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void GetAll()
        {
            var invoices = invoice.GetAll();
            Assert.IsNotNull(invoice);
        }        

        [Test]
        public void RemoveTest()
        {
            Invoice removeInvoice = invoice.GetInvoiceByNomor("9077");

            var result = invoice.Delete(removeInvoice);
            Assert.IsTrue(result != 0);
        }
        #endregion
    }
}
