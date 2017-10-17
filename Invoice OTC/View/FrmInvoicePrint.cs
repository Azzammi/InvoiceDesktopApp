using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_OTC.Controller.Invoice_Detail;
using Invoice_OTC.Controller.Outlet;
using Invoice_OTC.Controller;
using Invoice_OTC.Model;
using CrystalDecisions.CrystalReports.Engine;
using Invoice_OTC.View;

namespace Invoice_OTC.View
{
    public partial class FrmInvoicePrint : Form
    {
        #region Declaration
        AppController m_AppController;
        InvoiceList m_InvoiceList;        
        RotiToChooseList m_RotiToChooseList;
        outletList m_OutletList;
        RotiList m_InvoiceDetailList;

        private string nomorInvoice = "";
        #endregion

        #region Constructor
        public FrmInvoicePrint()
        {
            InitializeComponent();
        }

        public FrmInvoicePrint(string NomorInvoice)
        {
            InitializeComponent();
            this.nomorInvoice = NomorInvoice;
        }
        #endregion

        private void FrmInvoicePrint_Load(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportDocument invoiceObjectReport = new ReportDocument(); ;
            //invoiceObjectReport.Load(Application.StartupPath + "\\rptInvoice.rpt");
            

            m_AppController = new AppController();

            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_InvoiceList = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGettingOutlet getOutlet = new CommandGettingOutlet();
            m_OutletList = (outletList)m_AppController.ExecuteCommand(getOutlet);

            CommandGetRoti getRotis = new CommandGetRoti();
            m_RotiToChooseList = (RotiToChooseList)m_AppController.ExecuteCommand(getRotis);

            CommandGetItem getInvoiceDetai = new CommandGetItem();
            m_InvoiceDetailList = (RotiList)m_AppController.ExecuteCommand(getInvoiceDetai);
            
      
            //FieldingRw crInvoice = new FieldingRw();
            rptInvoice crInvoice = new rptInvoice();
            //rptSubReportInvoice crInvoice = new rptSubReportInvoice();

            //Set DataSource First            
            crInvoice.Database.Tables["Invoice_OTC_Model_InvoiceItem"].SetDataSource(m_InvoiceList);
            crInvoice.Subreports[0].Database.Tables["Invoice_OTC_Model_RotiToChooseItem"].SetDataSource(m_RotiToChooseList);
            crInvoice.Subreports[0].Database.Tables["Invoice_OTC_Model_RotiItem"].SetDataSource(m_InvoiceDetailList); 
            crInvoice.Database.Tables["Invoice_OTC_Model_OutletItem"].SetDataSource(m_OutletList);

            //Set the parameter value
            crInvoice.SetParameterValue("nomorInvoice",nomorInvoice);            

            crystalReportViewer1.ReportSource = crInvoice;
            crystalReportViewer1.Refresh();
        }
    }
}
