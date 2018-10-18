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

            productBindingSource.DataSource = productRepository.GetActiveProduct();
            outletBindingSource.DataSource = outletRepository.GetActiveOutlet();

            DataGridViewHelper.SetDataGridTheme(dataGridView1);

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

            productBindingSource.DataSource = productRepository.GetActiveProduct();
            outletBindingSource.DataSource = outletRepository.GetActiveOutlet();

            DataGridViewHelper.SetDataGridTheme(dataGridView1);

            CekKondisi(FormCondition.Inputting);
            invoiceBindingSource.Add(data);

            isAddNew = false;
            countBtn.PerformClick();
        }
        #endregion

        #region Overrided Methods
        protected override void button1_Click(object sender, EventArgs e)
        {
            invoiceBindingSource.AddNew();

            isAddNew = true;            
            CekKondisi(FormCondition.Inputting);
        }

        protected override void button2_Click(object sender, EventArgs e)
        {
            Invoice dataInvoice = (Invoice)invoiceBindingSource.Current;

            if (dataInvoice == null || dataInvoice.p_Items == null || dataInvoice.nomorInvoice == null) return;
            dataInvoice.issuedDate = issuedDateDateTimePicker.Value;
            dataInvoice.dueDate = dueDateDateTimePicker.Value;
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

            switch (e.ColumnIndex)
            {
                case 0:
                    row.Cells[1].Value = currentProduct.itemSort;
                    row.Cells[4].Value = currentProduct.price;
                    break;                
                case 1:
                    currentProduct = productRepository.GetItemBySort(row.Cells[1].Value.ToString().ToUpper());
                    row.Cells[0].Value = currentProduct.itemCode;                    
                    row.Cells[1].Value = currentProduct.itemSort;
                    row.Cells[4].Value = currentProduct.price;
                    break;
                case 5:
                    
                    break;
                default:
                    countBtn.PerformClick();
                    break;
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

            decimal total = invoiceRepository.GetInvoiceNett(dataInvoice);
            invoiceBindingSource.ResetCurrentItem();

            qtyLabel.Text = invoiceRepository.GetTotalQty(dataInvoice).ToString();
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
        
        private void outletBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Outlet outlet = (Outlet)outletBindingSource.Current;
            Invoice currentInvoice = (Invoice)invoiceBindingSource.Current;

            if (outlet == null || currentInvoice == null) return;
            currentInvoice.isPPN = outlet.isppn;
        }
        #endregion
    }
}
