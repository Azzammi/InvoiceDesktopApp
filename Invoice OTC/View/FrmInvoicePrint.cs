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
using CrystalDecisions.Shared;

namespace Invoice_OTC.View
{
    public partial class FrmInvoicePrint : Form
    {
        #region Declaration
        AppController m_AppController;
        InvoiceList m_InvoiceList;
        CustomerList m_CustomerList;
        #endregion
        public FrmInvoicePrint()
        {
            InitializeComponent();
        }

        private void FrmInvoicePrint_Load(object sender, EventArgs e)
        {
            //This section of code need to be cleaned and be effective
            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_InvoiceList = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGetCustomer getCustomers = new CommandGetCustomer();
            m_CustomerList = (CustomerList)m_AppController.ExecuteCommand(getCustomers);

            invoiceItemBindingSource.DataSource = m_InvoiceList;
            rotiItemBindingSource.DataSource = invoiceItemBindingSource;
            rotiItemBindingSource.DataMember = "Items";

            customerListBindingSource.DataSource = m_CustomerList;

            CrystalReport2 crInvoice = new CrystalReport2();
            crInvoice.Database.Tables["Invoice_OTC_Model_InvoiceItem"].SetDataSource(invoiceItemBindingSource);
            crInvoice.Database.Tables["Invoice_OTC_Model_RotiItem"].SetDataSource(rotiItemBindingSource);
            crInvoice.Database.Tables["Invoice_OTC_Model_CustomerList"].SetDataSource(customerListBindingSource);

            crystalReportViewer1.ReportSource = crInvoice;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument invoiceObjectReport = new ReportDocument(); ;
            //invoiceObjectReport.Load(Application.StartupPath + "\\CrystalReport2.rpt");

            m_AppController = new AppController();

            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_InvoiceList = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGetCustomer getCustomers = new CommandGetCustomer();
            m_CustomerList = (CustomerList)m_AppController.ExecuteCommand(getCustomers);

            invoiceItemBindingSource.DataSource = m_InvoiceList;
            rotiItemBindingSource.DataSource = invoiceItemBindingSource;
            rotiItemBindingSource.DataMember = "Items";

            customerListBindingSource.DataSource = m_CustomerList;

            CrystalReport2 crInvoice = new CrystalReport2();

            invoiceObjectReport = (ReportDocument)crInvoice;
            invoiceObjectReport.Database.Tables["Invoice_OTC_Model_InvoiceItem"].SetDataSource(invoiceItemBindingSource);
            invoiceObjectReport.Database.Tables["Invoice_OTC_Model_RotiItem"].SetDataSource(rotiItemBindingSource);
            invoiceObjectReport.Database.Tables["Invoice_OTC_Model_CustomerItem"].SetDataSource(customerListBindingSource);
            
            crystalReportViewer1.ReportSource = invoiceObjectReport;
            crystalReportViewer1.Refresh();
        }
    }
}
