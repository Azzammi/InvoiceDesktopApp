using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Report;
using InvoiceOTCNew.Report.CrFiles;

namespace InvoiceOTCNew
{
    public partial class FrmReportListProduct : TemplateReportFrm
    {
        #region Declaration
        private IProductRepository productRepo;
        #endregion

        #region Constructor
        public FrmReportListProduct()
        {
            InitializeComponent();

            productRepo = new ProductRepository(Program.log);
            LoadReport();
        }
        #endregion

        #region Load Report Method
        protected override void LoadReport()
        {
            RptListProduct crInvoice = new RptListProduct();
            
            //Set DataSource First
            crInvoice.Database.Tables["InvoiceOTC_Model_Product"].SetDataSource(productRepo.GetAll());

            crViewer.ReportSource = crInvoice;
            crViewer.Refresh();
        }
        #endregion
    }
}
