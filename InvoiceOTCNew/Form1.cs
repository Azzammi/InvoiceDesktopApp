using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using FSCollections;


namespace InvoiceOTCNew
{
    public partial class Form1 : Form
    {
        #region Declaration
        private IProductRepository product;
        #endregion

        public Form1()
        {
            InitializeComponent();

            product = new ProductRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productList = product.GetAll();            
            FSBindingList<Product> sorted = new FSBindingList<Product>(productList);

            productBindingSource.DataSource = sorted;            
        }
    }
}
