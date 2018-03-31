#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows.Forms;
using InvoiceOTCNew.Helper;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System.Reflection;

namespace InvoiceOTCNew
{
    public partial class FrmRibbonMenu : Syncfusion.Windows.Forms.Tools.RibbonForm, IMainMenu
    {
        #region Declaration
        private IUserRepository userRepo;
        #endregion

        public FrmRibbonMenu()
        {
            InitializeComponent();
            userRepo = new UserRepository(Program.log);

            this.Text = AssemblyProduct();
            softwareLbl.Text = AssemblyProduct() + " " + AssemblyCopyright();
        }

        #region Application Properties
        public string AssemblyCopyright()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }
        public string AssemblyProduct()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyProductAttribute)attributes[0]).Product;
        }
        #endregion

        #region User Validation
        public void CheckSession()
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
        #endregion
        
        public void CheckExistingForm(Form frm)
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

        #region Form Show

        #region Master Data
        public void about_Show(object sender, EventArgs e)
        {
            var frm = new FrmAbout();
            frm.ShowDialog();
        }

        public void invoices_Show(object sender, EventArgs e)
        {
            var frm = new FrmListBoundGrid();
            CheckExistingForm(frm);
        }

        public void logs_Show(object sender, EventArgs e)
        {
            var frm = new FrmLog();
            frm.ShowDialog();
        }

        public void outlets_Show(object sender, EventArgs e)
        {
            var frm = new FrmListOutlet();
            CheckExistingForm(frm);
        }

        public void products_Show(object sender, EventArgs e)
        {
            var frm = new FrmListProduct();
            CheckExistingForm(frm);
        }
        #endregion

        #region Report
        public void invoicePrint_Show(object sender, EventArgs e)
        {

        }
        public void productsPrint_Show(object sender, EventArgs e)
        {
            var frm = new FrmReportListProduct();
            frm.ShowDialog();
        }
        public void outletsPrint_Show(object sender, EventArgs e)
        {
            var frm = new FrmReportListOutlet();
            frm.ShowDialog();
        }
        public void rekapInvoice_Show(object sender, EventArgs e)
        {
            var frm = new FrmReportRekapInvoice();
            frm.ShowDialog();
        }
        #endregion
               
        #endregion
        
        public void Form_Closing(object sender, FormClosingEventArgs e)
        {
            //Check if user already logged
            if (Session.GetLoginStatus() != false)
            {
                if (DialogHelper.ExitDialog(this) != 0)
                {
                    userRepo.Logout();
                    Session.LogOut();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        public void Form_Load(object sender, EventArgs e)
        {
            CheckSession();
        }     
        public void timer1_tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString();
        }

        #region Tab AR
        #region Invoice

        private void createInvoiceMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmInvoice();
            frm.ShowDialog();
        }
        #endregion
        #endregion

    }
}
