using System;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using System.Windows.Forms;

namespace InvoiceOTCNew
{
    public partial class FrmListBoundGrid : TemplateListForm, IListener
    {
        #region Declaration
        private IInvoiceRepository invoiceRepo;
        private IProductRepository productRepo;
        #endregion

        public FrmListBoundGrid()
        {
            InitializeComponent();
            SetHeader("Invoice");

            productRepo = new ProductRepository();
            invoiceRepo = new InvoiceRepository();            
            invoiceBindingSource.DataSource = invoiceRepo.GetAllSorted();
            productBindingSource.DataSource = productRepo.GetAll();
        }

        private void FrmListBoundGrid_Load(object sender, EventArgs e)
        {
           
        }

        protected override void tambahBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmInvoice();
            frm.Listener = this;
            frm.ShowDialog();
        }
      
        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            Invoice currentInvoice = (Invoice)invoiceBindingSource.Current;
            if (currentInvoice == null) return;

            var frm = new FrmInvoice(currentInvoice);
            frm.Listener = this;
            frm.ShowDialog();
        }
     
        protected override void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Remove the event first - to prevent executing the other method
            dataGridView1.UserDeletingRow -= dataGridView1_UserDeletingRow;

            //Get Item Roti
            if (invoiceBindingSource.DataSource == null) return;
            if (dataGridView1.SelectedRows.Count == 0) return;

            //Confirm Delete     
            if (DialogHelper.DeleteDialog(dataGridView1.SelectedRows.Count + " record(s)") != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Invoice item = row.DataBoundItem as Invoice;
                    if (item != null)
                    {
                        invoiceRepo.Delete(item);
                        invoiceBindingSource.Remove(item);
                    }
                }
            }

            //Assign the method again
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
        }

        #region IListener Method
        public void Ok(object sender, object data)
        {
            throw new NotImplementedException();
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            if (isNewData)
            {
                invoiceBindingSource.ResetBindings(true);
                invoiceBindingSource.Add(data);
            }
            else
            {
                invoiceBindingSource.ResetCurrentItem();
            }
        }
        #endregion

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Get Item 
            if (invoiceBindingSource.DataSource == null) e.Cancel = true;
            if (dataGridView1.CurrentRow == null) e.Cancel = true;

            DataGridViewRow row = dataGridView1.CurrentRow;
            Invoice item = row.DataBoundItem as Invoice;

            //Confirm Delete     
            if (DialogHelper.DeleteDialog(item.nomorInvoice) != 0)
            {
                if (item != null)
                {
                    invoiceRepo.Delete(item);
                    invoiceBindingSource.Remove(item);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
