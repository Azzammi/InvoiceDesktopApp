using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_OTC.Model;
using Invoice_OTC.Controller;
using Invoice_OTC.Controller.Outlet;

namespace Invoice_OTC.View
{
    public partial class FrmOutlet : Form
    {
        #region Declaration
        AppController m_AppController;
        outletList m_List;
        #endregion

        public FrmOutlet()
        {
            InitializeComponent();
        }

        private void FrmOutlet_Load(object sender, EventArgs e)
        {
            m_AppController = new AppController();

            CommandGettingOutlet getOutlet = new CommandGettingOutlet();
            m_List = (outletList)m_AppController.ExecuteCommand(getOutlet);

            outletItemBindingSource.DataSource = m_List;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmImportExcelOutlet form = new FrmImportExcelOutlet();
            form.ShowDialog();
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in outletItemDataGridView.Rows)
                {
                    outletItem item = row.DataBoundItem as outletItem;
                    if (item != null)
                    {
                        CommandDeleteOutlet deleteItem = new CommandDeleteOutlet(m_List, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }

        private void findStrip1_ItemFound(object sender, ItemFoundEventArgs e)
        {
            //If value found, select row
            if (e.Index >= 0)
            {
                this.outletItemDataGridView.ClearSelection();
                this.outletItemDataGridView.Rows[e.Index].Selected = true;

                //Change current list data source item
                //To ensure currency accross all controls
                //bound to this data source
                this.outletItemBindingSource.Position = e.Index;
            }
        }

        private void deletesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in outletItemDataGridView.SelectedRows)
                {
                    outletItem item = row.DataBoundItem as outletItem;
                    if (item != null)
                    {
                        CommandDeleteOutlet deleteItem = new CommandDeleteOutlet(m_List, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }

        private void outletItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {            
            // Exit if no project list
            if (m_List == null) return;

            // Get the item affected
            int index = e.NewIndex;
            outletItem changedOutlet = null;
            if ((index > -1) && (index < m_List.Count))
            {
                changedOutlet = m_List[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            // Dispatch a change handler

            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    CommandCRUOutlet updateOutlet = new CommandCRUOutlet(changedOutlet, true);
                    m_AppController.ExecuteCommand(updateOutlet);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            m_List.ResetBindings();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            outletItemBindingSource.AddNew();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (m_List == null) return;
            outletItem currentItem = (outletItem)outletItemBindingSource.Current;

            CommandCRUOutlet newOutlet = new CommandCRUOutlet(currentItem, false);
            m_AppController.ExecuteCommand(newOutlet);
        }

        /// <summary>
        /// Overrid Method to setting the shortcut keys
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                outletItemBindingSource.ListChanged -= outletItemBindingSource_ListChanged;
                newToolStripButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S)){
                saveToolStripButton.PerformClick();
                outletItemBindingSource.ListChanged += outletItemBindingSource_ListChanged;
                return true;
            }
            else if(keyData == (Keys.Delete))
            {                
                outletItemDataGridView.Rows[outletItemDataGridView.CurrentRow.Index].Selected = true;
                deletesToolStripMenuItem.PerformClick();
                outletItemDataGridView.Rows[outletItemDataGridView.CurrentRow.Index].Selected = false;

                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
    }
}
