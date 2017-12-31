using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System;

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
            productRepository = new ProductRepository();

            productBindingSource.DataSource = productRepository.GetAllSorted();
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
            //Get Item Roti
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
        #endregion

        #endregion
        }
    }
}
