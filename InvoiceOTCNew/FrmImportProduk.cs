using System;
using System.Linq;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System.Collections.Generic;


namespace InvoiceOTCNew
{
    public partial class FrmImportProduk : Form
    {
        #region Declaration
        private IProductImportExcel importExcel;
        private IProductRepository productRepo;
        #endregion

        #region Constructor
        public FrmImportProduk()
        {
            importExcel = new ProductImportExcelRepository();
            productRepo = new ProductRepository();
            InitializeComponent();
        }
        #endregion


        private void browseBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DialogHelper.OpenExcelFileDialog("sheet1");            
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            IList<Product> productList = importExcel.CheckIfExistRecord(productRepo.GetAll(), importExcel.dataGridToObjectList(dataGridView1));
            foreach(Product product in productList)
            {
                productRepo.Save(product);
            }
        }
    }
}
