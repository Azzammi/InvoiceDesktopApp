using System;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System.Collections.Generic;

namespace InvoiceOTCNew
{
    public partial class FrmReportRekapInvoice : Form
    {
        #region Declaration
        private IInvoiceRepository invoiceRepo;
        private IOutletRepository outletRepo;        
        #endregion

        #region Constructor
        public FrmReportRekapInvoice()
        {
            InitializeComponent();

            invoiceRepo = new InvoiceRepository();
            outletRepo = new OutletRepository();

            LoadReport();         
        }
        #endregion

        #region LoadMethod
        public void LoadReport()
        {            
            rptRekapInvoice crInvoice = new rptRekapInvoice();         

            //Set DataSource First            
            crInvoice.Database.Tables["InvoiceOTC_Model_Invoice"].SetDataSource(invoiceRepo.GetAll());            
            crInvoice.Database.Tables["InvoiceOTC_Model_Outlet"].SetDataSource(outletRepo.GetAll());

            //Set the parameter value
            crInvoice.SetParameterValue("tanggal1",DateTime.Now);
            crInvoice.SetParameterValue("tanggal2", DateTime.Now);

            crystalReportViewer1.ReportSource = crInvoice;
            crystalReportViewer1.Refresh();
        }
        #endregion
    }
}
