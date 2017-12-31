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

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmListOutlet();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new FrmListProduct();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new FrmListBoundGrid();
            frm.ShowDialog();
        }
    }
}
