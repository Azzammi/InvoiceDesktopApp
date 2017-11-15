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
using System.Windows.Forms;
using Invoice_OTC.Controller;
using Invoice_OTC.Model;
using Syncfusion.Windows.Forms.Grid;
using Invoice_OTC.Controller.Outlet;

namespace Invoice_OTC.View
{
    public partial class FrmViewInvoice : Syncfusion.Windows.Forms.MetroForm
    {
        #region Declaration
        AppController m_AppController;
        InvoiceList m_Invoices;
        outletList m_Outlet;

        
        #endregion

        public FrmViewInvoice()
        {
            InitializeComponent();
        }

        private void FrmViewInvoice_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Customer List
            CommandGettingOutlet getOutlets = new CommandGettingOutlet();
            m_Outlet = (outletList)m_AppController.ExecuteCommand(getOutlets);

            // Get invoices List
            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_Invoices = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);


            invoiceItemBindingSource.DataSource = m_Invoices;
            

            #region [ CardView... ]

            //card.CaptionField = "OUTLETCODE";
            //card.CardSpacingWidth = 10;
            //card.CardSpacingHeight = 10;
            //card.MaxCardCols = 5;
            //card.CaptionHeight = 35;
            //card.CardBackColor = Color.Lavender;
            //card.WireGrid(this.gridDataBoundGrid1);

            #endregion

            //Assumes this.dataTable is a DataTable object with at least 2 columns named "id" and "display".



            //Sets the style properties.

            GridStyleInfo style = this.gridDataBoundGrid1.GridBoundColumns[3].StyleInfo;

            style.CellType = "ComboBox";

            style.DataSource = m_Outlet;

            //Displays in the grid cell.
            style.DisplayMember = "OutletName";

            //Values in the grid cell.
            style.ValueMember = "OutletCode";

            style.DropDownStyle = GridDropDownStyle.AutoComplete;

        }

        private void invoiceItemBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            MessageBox.Show("Adding New");
        }

        private void invoiceItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            
        }
    }
}
