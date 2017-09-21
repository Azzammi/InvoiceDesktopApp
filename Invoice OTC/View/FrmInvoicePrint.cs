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
        #endregion
        public FrmInvoicePrint()
        {
            InitializeComponent();
        }

        private void FrmInvoicePrint_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportDocument invoiceObjectReport = new ReportDocument(); ;
            //invoiceObjectReport.Load(Application.StartupPath + "\\CrystalReport2.rpt");

            m_AppController = new AppController();

            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_InvoiceList = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGettingOutlet getOutlet = new CommandGettingOutlet();
            m_OutletList = (outletList)m_AppController.ExecuteCommand(getOutlet);

            CommandGetRoti getRotis = new CommandGetRoti();
            m_RotiToChooseList = (RotiToChooseList)m_AppController.ExecuteCommand(getRotis);

            invoiceItemBindingSource.DataSource = m_InvoiceList;
            rotiItemBindingSource.DataSource = invoiceItemBindingSource;
            rotiItemBindingSource.DataMember = "Items";

            rptInvoice crInvoice = new rptInvoice();
            //rptInvoiceFix crInvoice = new rptInvoiceFix();

            crInvoice.Database.Tables["Invoice_OTC_Model_InvoiceItem"].SetDataSource(invoiceItemBindingSource);
            crInvoice.Database.Tables["Invoice_OTC_Model_RotiItem"].SetDataSource(rotiItemBindingSource);            
            crInvoice.Database.Tables["Invoice_OTC_Model_RotiToChooseItem"].SetDataSource(m_RotiToChooseList);
            crInvoice.Database.Tables["Invoice_OTC_Model_OutletItem"].SetDataSource(m_OutletList);
            
            crystalReportViewer1.ReportSource = crInvoice;
            crystalReportViewer1.Refresh();
        }
    }
}
