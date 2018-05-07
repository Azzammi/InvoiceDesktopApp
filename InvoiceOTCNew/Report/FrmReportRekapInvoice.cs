using System;
using CrystalDecisions.Windows.Forms;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Report;
using InvoiceOTCNew.Report.CrFiles;

namespace InvoiceOTCNew
{
    public partial class FrmReportRekapInvoice : TemplateReportFrm
    {
        #region Declaration
        private IInvoiceRepository invoiceRepo;
        private IOutletRepository outletRepo;
        private rptRekapInvoice crInvoice;
        private DateTime fromDate, toDate;
        private string outletCode = "";
        #endregion

        #region Constructor
        public FrmReportRekapInvoice()
        {
            InitializeComponent();

            invoiceRepo = new InvoiceRepository();
            outletRepo = new OutletRepository();
            crInvoice = new rptRekapInvoice();

            LoadReport();         
        }
        #endregion

        #region LoadMethod
        protected override void LoadReport()
        {        
            using (FrmReportRekapInvoiceDialog dialog = new FrmReportRekapInvoiceDialog())
            {
                dialog.ShowDialog();

                fromDate = dialog.dateTimePicker1.Value;
                toDate = dialog.dateTimePicker2.Value;
                if(dialog.comboBoxAdv1.SelectedValue != null) outletCode = dialog.comboBoxAdv1.SelectedValue.ToString();
            }            

            //Set DataSource First            
            crInvoice.Database.Tables["InvoiceOTC_Model_Invoice"].SetDataSource(invoiceRepo.GetAll());            
            crInvoice.Database.Tables["InvoiceOTC_Model_Outlet"].SetDataSource(outletRepo.GetAll());

            //Set the parameter value
            crInvoice.SetParameterValue("tanggal1",fromDate);
            crInvoice.SetParameterValue("tanggal2", toDate);
            crInvoice.SetParameterValue("outletCode", outletCode);

            crViewer.ReportSource = crInvoice;            
        }        
        #endregion
        
        private void FrmReportRekapInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
