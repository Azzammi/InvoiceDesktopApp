using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

namespace InvoiceOTCNew
{
    public partial class FrmInvoice : Form
    {
        #region Declaration
        private IInvoiceRepository invoiceRepository;
        private IOutletRepository outletRepository;
        private IProductRepository productRepository;
        #endregion

        public FrmInvoice()
        {
            InitializeComponent();

            invoiceRepository = new InvoiceRepository();
            outletRepository = new OutletRepository();
            productRepository = new ProductRepository();
        }

        private void invoiceBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            //IList<Invoice> listInvoice = invoiceRepository.GetAll();
            
            invoiceBindingSource.DataSource = invoiceRepository.GetAllSorted();
            outletBindingSource.DataSource = outletRepository.GetAll();
            productBindingSource.DataSource = productRepository.GetAllSorted();
        
            //pItemsBindingSource.DataSource = listInvoice.SelectMany(x => x.detail).ToList();            
        }
    }
}
