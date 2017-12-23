using System;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

namespace InvoiceOTCNew
{
    public partial class FrmListBoundGrid : TemplateListForm
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
            frm.ShowDialog();
        }
      
        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmInvoice(false);
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
    }
}
