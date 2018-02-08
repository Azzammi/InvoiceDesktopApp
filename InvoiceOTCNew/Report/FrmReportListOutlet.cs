using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Report;

namespace InvoiceOTCNew
{
    public partial class FrmReportListOutlet : TemplateReportFrm
    {
        #region Declaration
        private IOutletRepository outletRepo;
        #endregion

        #region Constructor
        public FrmReportListOutlet()
        {
            InitializeComponent();

            outletRepo = new OutletRepository();
            LoadReport();
        }
        #endregion

        #region Load Method
        private void LoadReport()
        {
            RptListOutlet crInvoice = new RptListOutlet();

            //Set DataSource First
            crInvoice.Database.Tables["InvoiceOTC_Model_Outlet"].SetDataSource(outletRepo.GetAll());

            crViewer.ReportSource = crInvoice;
            crViewer.Refresh();
        }
        #endregion

    }
}
