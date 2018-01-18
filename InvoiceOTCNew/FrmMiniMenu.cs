using System;
using System.Windows.Forms;

using InvoiceOTCNew.Helper;

namespace InvoiceOTCNew
{
    public partial class FrmMiniMenu : Form, IListener
    {
        #region Declaration
        
        #endregion

        public FrmMiniMenu()
        {
            InitializeComponent();           
        }

        private void listOutletShow(object sender, EventArgs e)
        {
            var frm = new FrmListOutlet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listProductShow(object sender, EventArgs e)
        {
            var frm = new FrmListProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listInvoiceShow(object sender, EventArgs e)
        {
            var frm = new FrmListBoundGrid();
            frm.Listener = this;
            frm.MdiParent = this;
            frm.Show();
        }

        #region IListener
        public void Ok(object sender, object data)
        {
            
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmLog();
            frm.ShowDialog();
        }

        private void rekapInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmReportRekapInvoice();
            frm.ShowDialog();
        }
    }
}
