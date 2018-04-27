using System;
using System.Linq;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
using System.Windows.Forms;

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
            DataGridViewHelper.SetDataGridTheme(outletDataGridView);
            SetDataSource(outletBindingSource);
            SetDGUserDeletingRow(outletDataGridView);

            outletRepository = new OutletRepository();
            outletBindingSource.DataSource = outletRepository.GetAll();

            searchInCmb.GotFocus += searchInToolStripCombobox_GotFocus;
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
        protected override void advancedSearchBtn_Click(object sender, EventArgs e)
        {
           outletBindingSource.DataSource = outletRepository.Search(searchInCmb.Text, searchTxt.Text);           
        }
        protected override void importBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmImportOutlet();
            frm.ShowDialog();
        }
        protected override void printBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmBatchOutlet();
            frm.ShowDialog();
        }
        protected override void refreshBtn_Click(object sender, EventArgs e)
        {
            outletBindingSource.DataSource = outletRepository.GetAll();
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

        #region DetaGridViewMethod
        private void outletDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int selectedCellCount = outletDataGridView.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (outletDataGridView.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Just Select cells that have number !");
                }
                else
                {
                    //Using Linq to iterate through selected cells
                    countDGCellBtn.Text = "Count : " + selectedCellCount;

                    var total = (from DataGridViewCell cell in outletDataGridView.SelectedCells
                                 where cell.FormattedValue.ToString() != string.Empty && cell.ValueType != typeof(string)
                                 select Convert.ToInt32(cell.FormattedValue)).Sum().ToString();
                    totalDGCellBtn.Text = "Total : " + total;

                }
            }
        }
        #endregion
    }
}
