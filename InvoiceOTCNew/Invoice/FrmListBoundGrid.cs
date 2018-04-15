using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using InvoiceOTC.Controller;

using FSCollections;

namespace InvoiceOTCNew
{
    public partial class FrmListBoundGrid : TemplateListForm, IListener
    {
        #region Declaration
        private IInvoiceRepository invoiceRepo;
        private IProductRepository productRepo;
        private IOutletRepository outletRepo;

        private IList<Invoice> invoiceData;
        private PageOffset pageOffset;
        private int totalRecords = 0;        
        #endregion

        public FrmListBoundGrid()
        {
            InitializeComponent();
            SetHeader("Invoice");
            DataGridViewHelper.SetDataGridTheme(dataGridView1);            

            productRepo = new ProductRepository();
            invoiceRepo = new InvoiceRepository();
            outletRepo = new OutletRepository();

            InitData();
            searchInCmb.GotFocus += searchInToolStripCombobox_GotFocus;
        }

        private void FrmListBoundGrid_Load(object sender, EventArgs e)
        {
           
        }

        private void InitData()
        {
            invoiceBindingSource.CurrentChanged -= new EventHandler(bindingSource1_CurrentChanged);

            invoiceData = invoiceRepo.GetAllSorted();
            invoiceBindingSource.DataSource = invoiceData;
            productBindingSource.DataSource = productRepo.GetAll();
            outletBindingSource.DataSource = outletRepo.GetAll();

            SetDataSource(invoiceData);

            pageOffset = new PageOffset();
            pageOffset.PageSize = 10;
            pageOffset.TotalRecords = invoiceData.Count;
            totalRecords = invoiceData.Count;

            bindingNavigator1.BindingSource = invoiceBindingSource;            
            invoiceBindingSource.CurrentChanged += new EventHandler(bindingSource1_CurrentChanged);
            invoiceBindingSource.DataSource = pageOffset;
        }

        #region Overrided Method
        protected override void tambahBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmInvoice();
            frm.Listener = this;
            frm.ShowDialog();
        }
        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            Invoice currentInvoice = (Invoice)dataGridView1.CurrentRow.DataBoundItem;
            if (currentInvoice == null) return;

            var frm = new FrmInvoice(currentInvoice);
            frm.Listener = this;
            frm.ShowDialog();
        }
        protected override void DeleteBtn_Click(object sender, EventArgs e)
        {            
            //Remove the event first - to prevent executing the other method
            dataGridView1.UserDeletingRow -= dataGridView1_UserDeletingRow;

            //Get Item Roti
            if (invoiceBindingSource.DataSource == null) return;
            if (dataGridView1.SelectedRows.Count == 0) return;

            //Confirm Delete     
            if (DialogHelper.DeleteDialog(dataGridView1.SelectedRows.Count + " record(s)") != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Invoice item = row.DataBoundItem as Invoice;
                    if (item != null)
                    {
                        invoiceRepo.Delete(item);
                        invoiceBindingSource.Remove(item);
                        
                    }
                }
            }

            //Assign the method again
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
        }        
        protected override void advancedSearchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = invoiceRepo.Search(searchInCmb.Text, searchTxt.Text);
        }
        protected override void printBtn_Click(object sender, EventArgs e)
        {
            Invoice currentInvoice = (Invoice)dataGridView1.CurrentRow.DataBoundItem;
            if (currentInvoice == null) return;

            var frm = new FrmReportInvoice(currentInvoice.nomorInvoice);            
            frm.ShowDialog();
        }
        protected override void refreshBtn_Click(object sender, EventArgs e)
        {
            InitData();
        }
        #endregion

        #region IListener Method
        public void Ok(object sender, object data)
        {
            throw new NotImplementedException();
        }
        public void Ok(object sender, bool isNewData, object data)
        {
            if (isNewData)
            {
                invoiceBindingSource.ResetBindings(true);
                //invoiceBindingSource.Add(data);
            }
            else
            {
                invoiceBindingSource.ResetCurrentItem();
            }
        }
        #endregion

        #region DataGridView Method
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Get Item 
            if (invoiceBindingSource.DataSource == null) e.Cancel = true;
            if (dataGridView1.CurrentRow == null) e.Cancel = true;

            DataGridViewRow row = dataGridView1.CurrentRow;
            Invoice item = row.DataBoundItem as Invoice;

            //Confirm Delete     
            if (DialogHelper.DeleteDialog(item.nomorInvoice) != 0)
            {
                if (item != null)
                {
                    invoiceRepo.Delete(item);
                    invoiceBindingSource.Remove(item);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

                if (selectedCellCount > 0)
                {
                    if (dataGridView1.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("Just Select cells that have number !");
                    }
                    else
                    {
                        //Using Linq to iterate through selected cells
                        countDGCellBtn.Text = "Count : " + selectedCellCount;
                        var total = (from DataGridViewCell cell in dataGridView1.SelectedCells
                                     where cell.FormattedValue.ToString() != string.Empty && cell.ValueType != typeof(string) && cell.ValueType != typeof(DateTime)
                                     select Convert.ToDecimal(cell.FormattedValue)).Sum().ToString("N03", Program.ci);
                        totalDGCellBtn.Text = "Total : " + total;
                    }
                }
            }
            catch (Exception ex)
            {
                Program.log.Error("Error", ex);
            }            
        }    
        #endregion

        private void FrmListBoundGrid_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region Paging
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)invoiceBindingSource.Current;
            var records = new List<Invoice>();
            for (int i = offset; i < offset + pageOffset.PageSize && i < totalRecords; i++)
                records.Add(invoiceData[i]);
            dataGridView1.DataSource = records;
        }
        #endregion
    }
}
