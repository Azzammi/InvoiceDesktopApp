using System;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
namespace InvoiceOTCNew
{
    public partial class FrmProduct : TemplateEntryFrm
    {
        #region Declaration
        private IProductRepository productRepository;        
        #endregion

        #region Properties
        
        #endregion

        public FrmProduct()
        {
            InitializeComponent();
            SetHeader("Product");

            productRepository = new ProductRepository();
            CekKondisi(FormCondition.Ready);
        }
        /// <summary>
        /// Passing data for edit
        /// </summary>
        /// <param name="data"></param>
        public FrmProduct(Product data)
        {
            InitializeComponent();
            SetHeader("Product");

            productRepository = new ProductRepository();
            CekKondisi(FormCondition.Inputting);

            productBindingSource.Add(data);
            isAddNew = false;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            
        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
            isAddNew = true;
                        
            CekKondisi(FormCondition.Inputting);
            itemCodeTextBox.Focus();
        }

        protected override void button2_Click(object sender, EventArgs e)
        {
            Product product = (Product)productBindingSource.Current;
            if (product == null) return;

            if (isAddNew && product.itemCode != null)
            {
                productRepository.Save(product);
                Listener.Ok(this, true, product);
            }
            else
            {
                productRepository.Update(product);
                Listener.Ok(this, false, product);
            }
                        
            CekKondisi(FormCondition.Ready);
        }
        
    }
}
