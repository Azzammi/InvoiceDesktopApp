using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using FSCollections;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using log4net;

namespace InvoiceOTCNew
{
    public partial class FrmInvoice : TemplateEntryFrm
    {
        #region Declaration
        private IInvoiceRepository invoiceRepository;
        private IInvoiceDetailRepository invoiceDetailRepository;
        private IOutletRepository outletRepository;
        private IProductRepository productRepository;
        #endregion

        #region Constructor
        public FrmInvoice()
        {
            InitializeComponent();
            SetHeader("Invoice");

            invoiceRepository = new InvoiceRepository();
            invoiceDetailRepository = new InvoiceDetailRepository();
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

            invoiceRepository = new InvoiceRepository(Program.log);
            invoiceDetailRepository = new InvoiceDetailRepository(Program.log);
            outletRepository = new OutletRepository(Program.log);
            productRepository = new ProductRepository(Program.log);

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

            if (dataInvoice == null || dataInvoice.p_Items == null || dataInvoice.nomorInvoice == null) return;
            dataInvoice.pengguna = Session.GetCurrentUser();
            countBtn.PerformClick();

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

        #region Supporting Methods
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            Product currentProduct = (Product)productBindingSource.Current;
            InvoiceDetail item = row.DataBoundItem as InvoiceDetail;

            if (e.ColumnIndex == 3)
            {
                countBtn.PerformClick();
            }
            else if(e.ColumnIndex == 0)
            {
                row.Cells[3].Value = currentProduct.price;
            }

            invoiceRepository.GetSubTotal(item);
        }

        private void detailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            Invoice dataInvoice = (Invoice)invoiceBindingSource.Current;
            dataInvoice.p_Items = pItemsBindingSource.List.Cast<InvoiceDetail>().ToListSorted();

            invoiceRepository.GetInvoiceNett(dataInvoice);
            invoiceBindingSource.ResetCurrentItem();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Get Item 
            if (pItemsBindingSource.DataSource == null) e.Cancel = true;
            if (dataGridView1.CurrentRow == null) e.Cancel = true;

            DataGridViewRow row = dataGridView1.CurrentRow;
            InvoiceDetail item = row.DataBoundItem as InvoiceDetail;

            //Confirm Delete     
            if (DialogHelper.DeleteDialog(item.itemCode) != 0)
            {
                if (item != null)
                {
                    if (isAddNew != true) invoiceDetailRepository.Delete(item);
                    productBindingSource.Remove(item);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

    }
}
