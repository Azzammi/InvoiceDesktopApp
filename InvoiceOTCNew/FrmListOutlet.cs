using System;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
using System.Windows.Forms;
using InvoiceOTC.Controller;

namespace InvoiceOTCNew
{
    public partial class FrmListOutlet : TemplateListForm, IListener
    {
        #region Declaration
        private IOutletRepository outletRepository;
        #endregion

        #region Constructor
        public FrmListOutlet()
        {
            InitializeComponent();
            SetHeader("outlet");
            SetDataSource(outletBindingSource);

            outletRepository = new OutletRepository();

            outletBindingSource.DataSource = outletRepository.GetAll();
        }
        #endregion

        #region Overrided Method
        protected override void tambahBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmOutlet();
            frm.Listener = this;
            frm.ShowDialog();
        }
        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            Outlet outlet = (Outlet)outletBindingSource.Current;
            if (outlet == null) return;

            var frm = new FrmOutlet(outlet);
            frm.Listener = this;
            frm.ShowDialog();
        }
        protected override void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Get Item Roti
            if (outletBindingSource.DataSource == null) return;
            if (outletDataGridView.SelectedRows.Count == 0) return;

            //Confirm Delete     
            if (DialogHelper.DeleteDialog(outletDataGridView.SelectedRows.Count + " record(s)") != 0)
            {
                foreach (DataGridViewRow row in outletDataGridView.SelectedRows)
                {
                    Outlet item = row.DataBoundItem as Outlet;
                    if (item != null)
                    {
                        outletRepository.Delete(item);
                        outletBindingSource.Remove(item);
                    }
                }
            }
        }
        protected override void findStrip1_ItemFound(object sender, ItemFoundEventArgs e)
        {
            //If value found, select row
            if (e.Index >= 0)
            {
                this.outletDataGridView.ClearSelection();
                this.outletDataGridView.Rows[e.Index].Selected = true;

                //Change current list data source item
                //To ensure currency accross all controls
                //bound to this data source
                this.outletBindingSource.Position = e.Index;
            }
        }
        protected override void toolStripButton1_Click(object sender, EventArgs e)
        {
            outletBindingSource.DataSource = outletRepository.Search(findStrip2.searchInCmb.Text, findStrip2.searchTxt.Text);
        }
        #endregion        

        #region IListener Method
        public void Ok(object sender, object data)
        {
            throw new NotImplementedException();
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            if (isNewData)
            {
                outletBindingSource.Add(data);
            }
        }
        #endregion
        
    }
}
