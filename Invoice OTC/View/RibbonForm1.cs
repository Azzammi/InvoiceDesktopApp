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
        CetakInvoice
    }

    public partial class RibbonForm1 : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        #region Declaration
        Form frm;
        #endregion

        public RibbonForm1()
        {
            InitializeComponent();
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
                default:
                    break;
            }

            frm.MdiParent = this;
            frm.Text = form.ToString();
            frm.Show();
        }
    }
}
