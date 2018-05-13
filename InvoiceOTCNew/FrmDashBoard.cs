using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using FSCollections;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using log4net;
using System.Collections.Generic;

namespace InvoiceOTCNew
{
    public partial class FrmDashBoard : Form
    {
        #region Declaration
        private IInvoiceRepository invoiceRepo;
        private IOutletRepository outletRepo;        

        private IList<Invoice> invoiceData;
        private IList<Outlet> outletData;
        #endregion

        #region Constructor
        public FrmDashBoard()
        {
            InitializeComponent();
            DataGridViewHelper.SetDataGridTheme(invoiceDataGridView);
                        
            invoiceRepo = new InvoiceRepository(Program.log);
            outletRepo = new OutletRepository(Program.log);

            RefreshData();
        }
        #endregion

        #region Method
        public void RefreshData()
        {
            //Get All data and assign to variable
            invoiceData = invoiceRepo.GetExpiredInvoices();
            outletData = outletRepo.GetActiveOutlet();

            //set the datagrid datasource
            invoiceBindingSource.DataSource = invoiceData;
            outletBindingSource.DataSource = outletData;
            //Set display label
            invoiceCountLabel.Text = invoiceData.Count.ToString();
            outletCountLabel.Text = outletData.Count.ToString();
        }
        #endregion
    }
}
