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

using FSCollections;

namespace InvoiceOTCNew
{
    public partial class FrmInvoice : Form
    {
        #region Declaration
        private IInvoiceRepository invoiceRepository;
        #endregion

        public FrmInvoice()
        {
            InitializeComponent();

            invoiceRepository = new InvoiceRepository();
        }

        private void invoiceBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            IList<Invoice> listInvoice = invoiceRepository.GetAll();
            invoiceBindingSource.DataSource = listInvoice;
            pItemsBindingSource.DataSource = listInvoice.SelectMany(x => x.detail).ToList();
            
        }
    }
}
