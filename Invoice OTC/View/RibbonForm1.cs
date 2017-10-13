#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Invoice_OTC.View
{
    public enum NamaForm
    {
        Outlet,
        Item,
        GridInvoice,
        DetailInvoice,
        CetakInvoice,
        LinqShowCase
    }

    public partial class RibbonForm1 : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        #region Declaration
        Form frm;

        private string periode;
        private string user;
        private string level;
        #endregion
        public RibbonForm1()
        {
            InitializeComponent();
        }

        public RibbonForm1(string users, string levels)
        {
            InitializeComponent();

            user = users;
            level = levels;

            userNameStripBtn.Text = User;
            levelStripBtn.Text = Level;
        }        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ShowForm(NamaForm.Outlet);
        }
       
        private void detailedViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(NamaForm.DetailInvoice);
        }

        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(NamaForm.GridInvoice);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ShowForm(NamaForm.Item);
        }

        private void invoicePrintBtn_Click(object sender, EventArgs e)
        {
            ShowForm(NamaForm.CetakInvoice);
        }

        //This is the function to call form
        //If there is new form just write it in the enum above and this add the switch
        protected void ShowForm(NamaForm form)
        {
            switch (form)
            {
                case NamaForm.Outlet:
                    frm = new FrmOutlet();
                    break;
                case NamaForm.Item:
                    frm = new itemFrm();
                    break;
                case NamaForm.GridInvoice:
                    frm = new dgBindingFrm();
                    break;
                case NamaForm.DetailInvoice:
                    frm = new detailedBindingForm(FormStatus.Ready);
                    break;
                case NamaForm.CetakInvoice:
                    frm = new FrmInvoicePrint();
                    break;
                case NamaForm.LinqShowCase:
                    frm = new FrmShowCaseLinq();
                    break;
                default:
                    break;
            }

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
            frm.Text = frm.Text;
            frm.Show();            
        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        #region Properties
        public string Periode
        {
            get { return periode; }
            set { periode = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        #endregion

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ShowForm(NamaForm.LinqShowCase);
        }
    }
}

