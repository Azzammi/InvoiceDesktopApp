using System;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;

namespace InvoiceOTCNew
{
    public partial class FrmListBoundGrid : TemplateListForm, IListener
    {
        public FrmListBoundGrid()
        {
            InitializeComponent();
            SetHeader("Invoice");
        }

        private void FrmListBoundGrid_Load(object sender, EventArgs e)
        {
            IInvoiceRepository invoiceRepo = new InvoiceRepository();

            invoiceBindingSource.DataSource = invoiceRepo.GetAll();
        }

        protected override void tambahBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmInvoice(true);
            frm.Listener = this;
            frm.ShowDialog();
        }
      
        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmInvoice(false);
            frm.Listener = this;
            frm.ShowDialog();
        }
     
        protected override void DeleteBtn_Click(object sender, EventArgs e)
        {
            Invoice deleteInvoice = (Invoice)invoiceBindingSource.Current;

            if (deleteInvoice == null) return;

            if (DialogHelper.DeleteDialog(deleteInvoice) != 0)
            {

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
            else
            {
                var currentSource = (Invoice)invoiceBindingSource.DataSource;
                currentSource = (Invoice)data;     
            }
        }
        #endregion
    }
}
