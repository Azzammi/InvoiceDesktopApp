using System;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System.Collections.Generic;

namespace InvoiceOTCNew
{
    public partial class FrmImportOutlet : Form
    {
        #region Declaration
        private IOutletImportExcel importRepo;
        private IOutletRepository outletRepo;
        #endregion

        #region Constructor
        public FrmImportOutlet()
        {
            InitializeComponent();

            importRepo = new OutletImportExcelRepository();
            outletRepo = new OutletRepository();
        }
        #endregion
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DialogHelper.OpenExcelFileDialog("sheet1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<Outlet> outletList = importRepo.CheckIfExistRecord(outletRepo.GetAll(), importRepo.dataGridToObjectList(dataGridView1));
            foreach (Outlet outlet in outletList)
            {
                outletRepo.Save(outlet);
            }
        }
    }
}
