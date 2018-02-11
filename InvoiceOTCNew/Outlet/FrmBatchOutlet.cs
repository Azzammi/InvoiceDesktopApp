using System;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using InvoiceOTCNew.Helper;

namespace InvoiceOTCNew
{
    public partial class FrmBatchOutlet : TemplateFormBatch
    {
        #region Declaration
        private IOutletRepository outletRepo;
        #endregion

        #region Constructor
        public FrmBatchOutlet()
        {
            InitializeComponent();
            outletRepo = new OutletRepository(Program.log);

            SetHeader("Set Active Outlet");
            DataGridViewHelper.SetDataGridTheme(outletDataGridView);
        }
        #endregion

        #region Form-Load
        private void FrmBatchOutlet_Load(object sender, EventArgs e)
        {
            outletBindingSource.DataSource = outletRepo.GetAll();
        }
        #endregion

        #region Overrided Methods
        protected override void CheckAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Validation 
            if (outletBindingSource.DataSource == null) return;

            if (CheckAllBtn.Checked != false)
            {
                foreach (DataGridViewRow row in outletDataGridView.Rows)
                {
                    Outlet item = row.DataBoundItem as Outlet;
                    if (item != null)
                    {
                        item.outlStat = true;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in outletDataGridView.Rows)
                {
                    Outlet item = row.DataBoundItem as Outlet;
                    if (item != null)
                    {
                        item.outlStat = false;
                    }
                }
            }

            outletBindingSource.ResetBindings(false);
        }
        protected override void printBtn_Click(object sender, EventArgs e)
        {
            base.printBtn_Click(sender, e);
        }
        protected override void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in outletDataGridView.Rows)
            {
                Outlet item = row.DataBoundItem as Outlet;
                if (item != null)
                {
                    outletRepo.Update(item);
                }
            }

            this.Close();
        }
        #endregion        
    }
}
