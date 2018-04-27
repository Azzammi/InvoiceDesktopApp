using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System;
using System.Linq;

using InvoiceOTCNew.Helper;
using System.Windows.Forms;

namespace InvoiceOTCNew
{
    public partial class FrmListProduct : TemplateListForm, IListener
    {
        #region Declaration
        private IProductRepository productRepository;
        #endregion

        #region Constructor
        public FrmListProduct()
        {
            InitializeComponent();
            SetHeader("Product");
            DataGridViewHelper.SetDataGridTheme(productDataGridView);
            SetDataSource(productBindingSource);
            SetDGUserDeletingRow(productDataGridView);            

            productRepository = new ProductRepository(Program.log);
            productBindingSource.DataSource = productRepository.GetAll();
        }
        #endregion

        #region Overrided Method
        protected override void tambahBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmProduct();
            frm.Listener = this;
            frm.ShowDialog();
        }
        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            Product currentProduct = (Product)productBindingSource.Current;
            if (currentProduct == null) return;

            var frm = new FrmProduct(currentProduct);
            frm.Listener = this;
            frm.ShowDialog();
        }
        protected override void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Verification 
            if (productBindingSource.DataSource == null) return;
            if (productDataGridView.SelectedRows.Count == 0) return;

            //Confirm Delete     
            if (DialogHelper.DeleteDialog(productDataGridView.SelectedRows.Count + " record(s)") != 0)
            {
                foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                {
                    Product item = row.DataBoundItem as Product;
                    if (item != null)
                    {
                        productRepository.Delete(item);
                        productBindingSource.Remove(item);
                    }
                }              
            }          
        }        
        protected override void advancedSearchBtn_Click(object sender, EventArgs e)
        {
           productBindingSource.DataSource = productRepository.Search(searchInCmb.Text, searchTxt.Text);
        }
        protected override void importBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmImportProduk();
            frm.ShowDialog();
        }
        protected override void printBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmBatchProduct();
            frm.ShowDialog();
        }
        protected override void refreshBtn_Click(object sender, EventArgs e)
        {            
            productBindingSource.DataSource = productRepository.GetAll();
        }
        #endregion

        #region IListener
        public void Ok(object sender, object data)
        {
            throw new NotImplementedException();
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            if (isNewData)
            {
                productBindingSource.Add(data);
            }

        }
        #endregion

        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int selectedCellCount = productDataGridView.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (productDataGridView.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Just Select cells that have number !");
                }
                else
                {
                    //Using Linq to iterate through selected cells
                    countDGCellBtn.Text = "Count : " + selectedCellCount;
                    var total = (from DataGridViewCell cell in productDataGridView.SelectedCells
                                 where cell.FormattedValue.ToString() != string.Empty && cell.ValueType != typeof(string) && cell.ValueType != typeof(DateTime)
                                 select Convert.ToDecimal(cell.FormattedValue)).Sum().ToString("N03", Program.ci);
                    totalDGCellBtn.Text = "Total : " + total;
                }
            }
        }
    }
}
