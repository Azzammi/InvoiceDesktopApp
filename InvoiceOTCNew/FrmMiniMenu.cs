using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceOTCNew
{
    public partial class FrmMiniMenu : Form
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
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
