using System;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
using System.Windows.Forms;
using System.Collections.Generic;

namespace InvoiceOTCNew
{
    public partial class FrmSalesOrder : Form
    {
        #region Declaration
        private ISalesOrderRepository salesOrderRepo;
        private IList<SalesOrder> listSO;
        #endregion

        #region Constructor
        public FrmSalesOrder()
        {
            InitializeComponent();

            salesOrderRepo = new SalesOrderRepository(Program.log);
            listSO = salesOrderRepo.GetAll();        
            salesOrderBindingSource.DataSource = listSO;

            salesOrderBindingSource.AddNew();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrder = (SalesOrder)salesOrderBindingSource.Current;
            detailBindingSource.DataSource =  salesOrderRepo.GetProducts(salesOrder.detail);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            SalesOrder salesOrder = (SalesOrder)salesOrderBindingSource.Current;
            salesOrder.detail = (IList<SalesOrderDetail>) detailBindingSource.DataSource;
            MessageBox.Show("Count : " + salesOrder.detail.Count);

            //salesOrderRepo.Save(salesOrder);
        }
    }
}
