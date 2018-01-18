﻿using System;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System.Collections.Generic;

namespace InvoiceOTCNew
{
    public partial class FrmReportInvoice : Form
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

       private void LoadReport()
        {
            //ReportDocument invoiceObjectReport = new ReportDocument(); ;
            //invoiceObjectReport.Load(Application.StartupPath + "\\rptInvoice.rpt");
            
            //FieldingRw crInvoice = new FieldingRw();
            rptInvoiceWODisc crInvoice = new rptInvoiceWODisc();
            //rptSubReportInvoice crInvoice = new rptSubReportInvoice();

            //Set DataSource First            
            crInvoice.Database.Tables["InvoiceOTC_Model_Invoice"].SetDataSource(invoiceRepo.GetAll());
            crInvoice.Subreports[0].Database.Tables["InvoiceOTC_Model_Product"].SetDataSource(productRepo.GetAll());
            crInvoice.Subreports[0].Database.Tables["InvoiceOTC_Model_InvoiceDetail"].SetDataSource(invoiceDetailRepo.GetAll());
            crInvoice.Database.Tables["InvoiceOTC_Model_Outlet"].SetDataSource(outletRepo.GetAll());

            //Set the parameter value
            crInvoice.SetParameterValue("nomorInvoice", _param);

            crystalReportViewer1.ReportSource = crInvoice;
            crystalReportViewer1.Refresh();
        }
    }
}
