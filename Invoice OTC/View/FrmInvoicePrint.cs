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
        CustomerList m_CustomerList;
        RotiToChooseList m_RotiToChooseList;
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

            CommandGetCustomer getCustomers = new CommandGetCustomer();
            m_CustomerList = (CustomerList)m_AppController.ExecuteCommand(getCustomers);

            CommandGetRoti getRotis = new CommandGetRoti();
            m_RotiToChooseList = (RotiToChooseList)m_AppController.ExecuteCommand(getRotis);

            invoiceItemBindingSource.DataSource = m_InvoiceList;
            rotiItemBindingSource.DataSource = invoiceItemBindingSource;
            rotiItemBindingSource.DataMember = "Items";

            customerListBindingSource.DataSource = m_CustomerList;

            rptInvoice crInvoice = new rptInvoice();

            crInvoice.Database.Tables["Invoice_OTC_Model_InvoiceItem"].SetDataSource(invoiceItemBindingSource);
            crInvoice.Database.Tables["Invoice_OTC_Model_RotiItem"].SetDataSource(rotiItemBindingSource);
            crInvoice.Database.Tables["Invoice_OTC_Model_CustomerItem"].SetDataSource(m_CustomerList);
            crInvoice.Database.Tables["Invoice_OTC_Model_RotiToChooseItem"].SetDataSource(m_RotiToChooseList);
            
            crystalReportViewer1.ReportSource = crInvoice;
            crystalReportViewer1.Refresh();
        }
    }
}
