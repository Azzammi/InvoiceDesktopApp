#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Invoice_OTC.Controller;
using Invoice_OTC.Controller.Outlet;
using Invoice_OTC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Invoice_OTC.View
{
    public partial class invoiceFrm : Syncfusion.Windows.Forms.MetroForm
    {
        #region Declaration
        AppController m_AppController;
        InvoiceList m_Invoices;
        outletList m_OutletList;
        RotiToChooseList m_RotiList;
        #endregion

        public invoiceFrm()
        {
            InitializeComponent();
        }

        private void invoiceFrm_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Customer List
            //CommandGettingOutlet getOutlets = new CommandGettingOutlet();
            //m_OutletList = (outletList)m_AppController.ExecuteCommand(getOutlets);

            // Get invoices List
            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_Invoices = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGetRoti getRoti = new CommandGetRoti();
            m_RotiList = (RotiToChooseList)m_AppController.ExecuteCommand(getRoti);

            //Bind Grids            
            //outletItemBindingSource.DataSource = m_OutletList;
            rotiToChooseItemBindingSource.DataSource = m_RotiList;

            invoiceItemBindingSource.DataSource = m_Invoices;
            itemsBindingSource.DataSource = invoiceItemBindingSource;
            itemsBindingSource.DataMember = "Items";
        }
    }
}
