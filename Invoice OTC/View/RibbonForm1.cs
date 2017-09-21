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
    public partial class RibbonForm1 : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmOutlet form = new FrmOutlet();
            form.MdiParent = this;
            form.Text = "Outlet";
            form.Show();
        }

        private void toolStripSplitButtonEx1_Click(object sender, EventArgs e)
        {
            
        }

        private void detailedViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailedBindingForm form = new detailedBindingForm(FormStatus.Ready);
            form.MdiParent = this;
            form.Text = "Invoice Detailed View";
            form.Show();
        }

        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgBindingFrm form = new dgBindingFrm();
            form.MdiParent = this;
            form.Text = "Invoice Grid View";
            form.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            itemFrm form = new itemFrm();
            form.MdiParent = this;
            form.Text = "Barang";
            form.Show();
        }
    }
}
