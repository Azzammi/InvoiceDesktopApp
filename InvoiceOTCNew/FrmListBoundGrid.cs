using System;
using System.Linq;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using System.Windows.Forms;
using InvoiceOTC.Controller;

namespace InvoiceOTCNew
{
    public partial class FrmListBoundGrid : TemplateListForm, IListener
    {
        #region Declaration
        private IInvoiceRepository invoiceRepo;
        private IProductRepository productRepo;
        #endregion

        public FrmListBoundGrid()
        {
            InitializeComponent();
            SetHeader("Invoice");
            SetDataSource(invoiceBindingSource);

            productRepo = new ProductRepository();
            invoiceRepo = new InvoiceRepository();            
            invoiceBindingSource.DataSource = invoiceRepo.GetAllSorted();
            productBindingSource.DataSource = productRepo.GetAll();
        }

        private void FrmListBoundGrid_Load(object sender, EventArgs e)
        {
           
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
            Invoice currentInvoice = (Invoice)invoiceBindingSource.Current;
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
        protected override void findStrip1_ItemFound(object sender, ItemFoundEventArgs e)
        {
            //If value found, select row
            if (e.Index >= 0)
            {
                this.dataGridView1.ClearSelection();
                this.dataGridView1.Rows[e.Index].Selected = true;

                //Change current list data source item
                //To ensure currency accross all controls
                //bound to this data source
                this.invoiceBindingSource.Position = e.Index;
            }
        }
        protected override void advancedSearchBtn_Click(object sender, EventArgs e)
        {
            invoiceBindingSource.DataSource = invoiceRepo.Search(findStrip2.searchInCmb.Text, findStrip2.searchTxt.Text);
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
                invoiceBindingSource.Add(data);
            }
            else
            {
                invoiceBindingSource.ResetCurrentItem();
            }
        }
        #endregion

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
                                 select Convert.ToDecimal(cell.FormattedValue)).Sum().ToString();
                    totalDGCellBtn.Text = "Total : " + total;
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int selectedCellCount = dataGridView2.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (dataGridView2.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Just Select cells that have number !");
                }
                else
                {
                    //Using Linq to iterate through selected cells
                    countDGCellBtn.Text = "Count : " + selectedCellCount;
                    var total = (from DataGridViewCell cell in dataGridView2.SelectedCells
                                 where cell.FormattedValue.ToString() != string.Empty && cell.ValueType != typeof(string)
                                 select Convert.ToDecimal(cell.FormattedValue)).Sum().ToString("N");
                    totalDGCellBtn.Text = "Total : " +  total; 
                }
            }
        }
    }
}
