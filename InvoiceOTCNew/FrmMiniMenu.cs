using System;
using System.Windows.Forms;

using InvoiceOTCNew.Helper;
using System.Reflection;

namespace InvoiceOTCNew
{
    public partial class FrmMiniMenu : Form, IListener
    {
        #region Declaration
        
        #endregion

        public FrmMiniMenu()
        {
            InitializeComponent();

            this.Text = AssemblyProduct;
            softwareLbl.Text = AssemblyProduct + " " + AssemblyCopyright;
        }

        private void listOutletShow(object sender, EventArgs e)
        {
            var frm = new FrmListOutlet();
            CheckExistingForm(frm);
        }

        private void listProductShow(object sender, EventArgs e)
        {
            var frm = new FrmListProduct();
            CheckExistingForm(frm);
        }

        private void listInvoiceShow(object sender, EventArgs e)
        {
            var frm = new FrmListBoundGrid();            
            CheckExistingForm(frm);
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

        private void timerCtl_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void CheckExistingForm(Form frm)
        {
            /* Function to check for the existing form */
            foreach (Form window in Application.OpenForms)
            {
                if (window.GetType() == frm.GetType())
                {
                    window.Activate();
                    return;
                }                
            }
            /* The code end here */

            frm.MdiParent = this;
            frm.Show();
        }

        #region Application Information Properties
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        #endregion

        private void FrmMiniMenu_Load(object sender, EventArgs e)
        {
            CheckSession();
        }

        /// <summary>
        /// Method to check if user already logged in
        /// </summary>
        private void CheckSession()
        {
            if (string.IsNullOrEmpty(Session.GetCurrentUser()) || Session.GetLoginStatus() != true)
            {
                using (FrmLogin frm = new FrmLogin())
                {
                    frm.ShowDialog();
                }
                userLbl.Text = Session.GetCurrentUser();
            }
        }
    }
}
