using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System;

using InvoiceOTCNew.Helper;

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
            base.DeleteBtn_Click(sender, e);
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
