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
            invoiceBindingSource.DataSource = invoiceRepo.GetAll();
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
        }
        #endregion
    }
}
