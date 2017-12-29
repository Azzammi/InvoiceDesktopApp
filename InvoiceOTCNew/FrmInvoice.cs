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

        #region Constructor
        public FrmInvoice()
        {
            InitializeComponent();
            SetHeader("Invoice");

            invoiceRepository = new InvoiceRepository();
            outletRepository = new OutletRepository();
            productRepository = new ProductRepository();

            productBindingSource.DataSource = productRepository.GetAll();
            outletBindingSource.DataSource = outletRepository.GetAll();

            CekKondisi(FormCondition.Ready);
            isAddNew = false;
        }

        /// <summary>
        /// Passing data for edit
        /// </summary>
        /// <param name="data"></param>
        public FrmInvoice(object data)
        {
            InitializeComponent();
            SetHeader("Invoice");

            invoiceRepository = new InvoiceRepository();
            outletRepository = new OutletRepository();
            productRepository = new ProductRepository();

            productBindingSource.DataSource = productRepository.GetAll();
            outletBindingSource.DataSource = outletRepository.GetAll();

            CekKondisi(FormCondition.Inputting);
            invoiceBindingSource.Add(data);
            isAddNew = false;
           
        }
        #endregion
        
        #region Overrided Methods
        protected override void button1_Click(object sender, EventArgs e)
        {
            isAddNew = true;
            invoiceBindingSource.AddNew();
            CekKondisi(FormCondition.Inputting);
        }

        protected override void button2_Click(object sender, EventArgs e)
        {
            Invoice dataInvoice = (Invoice)invoiceBindingSource.Current;
            //List<object> lik = ((List<InvoiceDetail>)detailBindingSource.DataSource).Cast<object>().ToList();
            if (dataInvoice == null) return;
            dataInvoice.detail = detailBindingSource.List.Cast<InvoiceDetail>().ToList();

            switch (isAddNew)
            {
                case true:
                    invoiceRepository.Save(dataInvoice);
                    Listener.Ok(this, true, dataInvoice);
                    break;
                case false:
                    invoiceRepository.Update(dataInvoice);
                    break;
                default:
                    MessageBox.Show("Condition not set !!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            isAddNew = false;
            CekKondisi(FormCondition.Ready);            
        }
        #endregion


    }
}
