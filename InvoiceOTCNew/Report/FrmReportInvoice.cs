using System;

using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Report;
using InvoiceOTCNew.Report.CrFiles;

namespace InvoiceOTCNew
{
    public partial class FrmReportInvoice : TemplateReportFrm
    {
        #region Declaration
        private IInvoiceRepository invoiceRepo;
        private IOutletRepository outletRepo;
        private IProductRepository productRepo;
        private IInvoiceDetailRepository invoiceDetailRepo;

        private object _param;
        #endregion

        public FrmReportInvoice(object param = null)
        {
            InitializeComponent();

            invoiceRepo = new InvoiceRepository();
            outletRepo = new OutletRepository();
            productRepo = new ProductRepository();
            invoiceDetailRepo = new InvoiceDetailRepository();

            _param = param;
            LoadReport();
        }

        private void FrmReportInvoice_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        protected override void LoadReport()
        {
            //ReportDocument invoiceObjectReport = new ReportDocument(); ;
            //invoiceObjectReport.Load(Application.StartupPath + "\\rptInvoice.rpt");
            
            //FieldingRw crInvoice = new FieldingRw();
            rptInvoiceWODiscDevHendra crInvoice = new rptInvoiceWODiscDevHendra();
            //rptSubReportInvoice crInvoice = new rptSubReportInvoice();

            //Set DataSource First            
            crInvoice.Database.Tables["InvoiceOTC_Model_Invoice"].SetDataSource(invoiceRepo.GetAll());
            crInvoice.Subreports[0].Database.Tables["InvoiceOTC_Model_Product"].SetDataSource(productRepo.GetAll());
            crInvoice.Subreports[0].Database.Tables["InvoiceOTC_Model_InvoiceDetail"].SetDataSource(invoiceDetailRepo.GetAll());
            crInvoice.Database.Tables["InvoiceOTC_Model_Outlet"].SetDataSource(outletRepo.GetAll());

            //Set the parameter value
            crInvoice.SetParameterValue("invoiceID", _param);

            crViewer.ReportSource = crInvoice;
            crViewer.Refresh();
        }
    }
}
