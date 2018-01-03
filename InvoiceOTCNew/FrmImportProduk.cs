using System;
using System.Linq;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using InvoiceOTC.Controller;
using System.Collections.Generic;
using System.Data;
using FSCollections;

namespace InvoiceOTCNew
{
    public partial class FrmImportProduk : Form
    {
        private IProductImportExcel importExcel;
        private IProductRepository productRepo;
        private DataTable sourceExcel;

        public FrmImportProduk()
        {
            importExcel = new ProductImportExcel();
            productRepo = new ProductRepository(); 
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DialogHelper.OpenExcelFileDialog("sheet1");
            productBindingSource.DataSource = productRepo.GetAll();
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
           // var excelDG = sourceExcel.AsEnumerable().Select(r => sourceExcel.Columns.ToDictionary)
            dataGridView3.DataSource = importExcel.CheckIfExistRecord(productBindingSource.List.Cast<Product>().ToList(), sourceExcel.ToList<Product>());
        }
    }
}
