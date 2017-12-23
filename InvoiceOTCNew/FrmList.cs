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

namespace InvoiceOTCNew
{
    public partial class FrmList : TemplateListForm
    {
        #region Constructor
        public FrmList()
        {
            InitializeComponent();
            SetHeader("OUTLET");
        }
        #endregion

        private void FrmList_Load(object sender, EventArgs e)
        {
            SetFormData();
        }

        private void SetFormData()
        {
            switch (headerLbl.Text)
            {
                case "OUTLET":
                    IOutletRepository outletRepo = new OutletRepository();

                    DataModelList = outletRepo.GetAll();
                    break;
                case "PRODUCT":
                    IProductRepository productRepo = new ProductRepository();

                    DataModelList = productRepo.GetAll();
                    break;
                default:
                    break;

            }

            bindingSource.DataSource = DataModelList;
            dataGridView1.DataSource = bindingSource;
        }
    }
}
