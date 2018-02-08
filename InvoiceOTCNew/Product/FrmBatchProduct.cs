using System;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

namespace InvoiceOTCNew
{
    public partial class FrmBatchProduct : TemplateFormBatch
    {
        #region Declaration
        private IProductRepository productRepo;
        #endregion

        #region Constructor
        public FrmBatchProduct()
        {
            InitializeComponent();
            productRepo = new ProductRepository(Program.log);

            SetHeader("Product Batch Operation");
            SetDataSource(productBindingSource);
        }
        #endregion

        #region Form Load
        private void FrmBatchProduct_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = productRepo.GetAll();
        }
        #endregion

        #region Overrided Methods
        protected override void CheckAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Validation 
            if (productBindingSource.DataSource == null) return;            

            if (CheckAllBtn.Checked != false)
            {
                foreach (DataGridViewRow row in productDataGridView.Rows)
                {
                    Product item = row.DataBoundItem as Product;
                    if (item != null)
                    {
                        item.stat = true;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in productDataGridView.Rows)
                {
                    Product item = row.DataBoundItem as Product;
                    if (item != null)
                    {
                        item.stat = false;
                    }
                }
            }

            productBindingSource.ResetBindings(false);
        }
        protected override void printBtn_Click(object sender, EventArgs e)
        {
            base.printBtn_Click(sender, e);
        }
        protected override void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productDataGridView.Rows)
            {
                Product item = row.DataBoundItem as Product;
                if (item != null)
                {
                    productRepo.Update(item);
                }
            }

            this.Close();
        }
        #endregion

    }
}
