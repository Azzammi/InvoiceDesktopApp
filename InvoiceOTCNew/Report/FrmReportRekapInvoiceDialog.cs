using System;
using FSCollections;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;
using log4net;

namespace InvoiceOTCNew
{
    public partial class FrmReportRekapInvoiceDialog : TemplateDialogFrm
    {
        #region Declaration
        private IOutletRepository outletRepository;
        #endregion

        public FrmReportRekapInvoiceDialog()
        {
            InitializeComponent();

            outletRepository = new OutletRepository();
            outletBindingSource.DataSource = outletRepository.GetAll();

            comboBoxAdv1.SelectedIndex = -1;
        }

        protected override void ShowReportBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void ResetBtn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBoxAdv1.SelectedIndex = -1;
        }
    }
}
