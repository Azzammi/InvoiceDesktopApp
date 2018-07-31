using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using FSCollections;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using log4net;
using System.Collections.Generic;

namespace InvoiceOTCNew
{
    public partial class FrmInputSalesOrder : TemplateEntryFrm
    {
        #region Declaration
        private IProductRepository productRepo;
        private ISalesOrderRepository salesOrderRepo;
        private SalesOrder currentSalesOrder;
        #endregion

        #region Constructor
        public FrmInputSalesOrder()
        {
            InitializeComponent();

            productRepo = new ProductRepository(Program.log);
            salesOrderRepo = new SalesOrderRepository(Program.log);
        }
        #endregion

        #region Overriding Method
        protected override void button1_Click(object sender, EventArgs e)
        {
            salesOrderBindingSource.AddNew();
            currentSalesOrder = (SalesOrder)salesOrderBindingSource.Current;

            currentSalesOrder.p_Items = salesOrderRepo.GetProducts(currentSalesOrder.p_Items).ToListSorted();
            salesOrderBindingSource.ResetCurrentItem();

            isAddNew = true;
            CekKondisi(FormCondition.Inputting);
        }
        protected override void button2_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrder = (SalesOrder)salesOrderBindingSource.Current;

            //if (salesOrder == null || salesOrder.p_Items == null || sa)
        }
        #endregion

        private bool CheckQuantity()
        {
            SalesOrder salesOrder = (SalesOrder)salesOrderBindingSource.Current;
            var totalQty = 0;

            if (salesOrder == null || salesOrder.p_Items == null) return false;

            foreach(SalesOrderDetail detail in salesOrder.p_Items)
            {
                totalQty += detail.qtyOrder;                   
            }

            var result = totalQty != 0 ? true : false;
            return result;
        }

        private void detailDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SalesOrder salesOrder = (SalesOrder)salesOrderBindingSource.Current;
            salesOrder.p_Items = p_ItemsBindingSource.List.Cast<SalesOrderDetail>().ToListSorted();

            switch (e.ColumnIndex)
            {
                case 3:
                    salesOrderRepo.GetTotalAmount(salesOrder);
                    salesOrderRepo.GetTotalQty(salesOrder);

                    salesOrderBindingSource.ResetCurrentItem();
                    break;
                default:
                    salesOrderBindingSource.ResetCurrentItem(); 
                    break;
            }
                
        }
    }
}
