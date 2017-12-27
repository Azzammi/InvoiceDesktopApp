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
    public partial class FrmInvoice : templateEntryFrm
    {
        #region Declaration
        private IInvoiceRepository invoiceRepository;
        private IOutletRepository outletRepository;
        private IProductRepository productRepository;        
        #endregion

        public FrmInvoice(bool isAddNew)
        {
            InitializeComponent();

            invoiceRepository = new InvoiceRepository();
            outletRepository = new OutletRepository();
            productRepository = new ProductRepository();

            SetHeader("Invoice");
            this.isAddNew = isAddNew;

            if(isAddNew == true)
            {
                invoiceBindingSource.AddNew();
            }
        }
        
        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            //IList<Invoice> listInvoice = invoiceRepository.GetAll();
            
           invoiceBindingSource.DataSource = invoiceRepository.GetAll();
            outletBindingSource.DataSource = outletRepository.GetAll();
            productBindingSource.DataSource = productRepository.GetAll();

            //pItemsBindingSource.DataSource = listInvoice.SelectMany(x => x.detail).ToList();      
            //bindingSource.DataSource = invoiceRepository ;      
        }

        protected override void button2_Click(object sender, EventArgs e)
        {            
            Invoice dataInvoice = (Invoice)invoiceBindingSource.Current;
            if (dataInvoice == null) return;

            switch (isAddNew)
            {
                case true:
                    invoiceRepository.Save(dataInvoice);
                    break;
                case false:
                    invoiceRepository.Update(dataInvoice);
                    break;
                default:
                    MessageBox.Show("Condition not set !!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            isAddNew = true;
            CekKondisi(FormCondition.Ready);
            invoiceBindingSource.AddNew();
        }
        
    }
}
