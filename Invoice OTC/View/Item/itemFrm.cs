using Invoice_OTC.Controller;
using Invoice_OTC.Controller.Roti_Item;
using Invoice_OTC.Model;
using Invoice_OTC.View;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Invoice_OTC
{
    public partial class itemFrm : Form
    {
        #region Declarations
        AppController m_AppController;
        RotiToChooseList m_List;
        bool isNewRecord;
        #endregion

        public itemFrm()
        {
            InitializeComponent();
        }
        
        private void itemFrm_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            // Get invoices List          

            CommandGetRoti getRotis = new CommandGetRoti();
            m_List = (RotiToChooseList)m_AppController.ExecuteCommand(getRotis);

            //Bind Grids
            bindingSource1.DataSource = m_List;            
            
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmImportExcelRoti form = new FrmImportExcelRoti();
            form.ShowDialog();
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Exit if no project list
            if (m_List == null) return;

            // Get the item affected
            int index = e.NewIndex;
            RotiToChooseItem changedItem = null;
            if ((index > -1) && (index < m_List.Count))
            {
                changedItem = m_List[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            // Dispatch a change handler

            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    CommandUpdateRoti updateRoti = new CommandUpdateRoti(changedItem);
                    m_AppController.ExecuteCommand(updateRoti);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //CommandSaveRotiList saveRoti = new CommandSaveRotiList(m_List);
            //m_AppController.ExecuteCommand(saveRoti);
            if (m_List == null) return;
            RotiToChooseItem changeItem = (RotiToChooseItem)bindingSource1.Current;
            if (changeItem == null) return;

            if (isNewRecord)
            {
                CommandInsertRoti newRoti = new CommandInsertRoti(changeItem);
                m_AppController.ExecuteCommand(newRoti);
            }
            else
            {
                CommandUpdateRoti updateRoti = new CommandUpdateRoti(changeItem);
                m_AppController.ExecuteCommand(updateRoti);
            }             
        }


        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
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
                bindingSource1.ListChanged -= bindingSource1_ListChanged;
                newToolStripButton.PerformClick();
                isNewRecord = true;

                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                saveToolStripButton.PerformClick();
                bindingSource1.ListChanged += bindingSource1_ListChanged;
                isNewRecord = false;

                return true;
            }
            else if (keyData == (Keys.Delete))
            {
                dgViewRoti.Rows[dgViewRoti.CurrentRow.Index].Selected = true;
                bindingNavigatorDeleteItem.PerformClick();
                dgViewRoti.Rows[dgViewRoti.CurrentRow.Index].Selected = false;

                isNewRecord = false;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (m_List == null) return;            

            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgViewRoti.SelectedRows)
                {
                    RotiToChooseItem item = row.DataBoundItem as RotiToChooseItem;
                    if (item != null)
                    {
                        CommandDeleteRoti deleteItem = new CommandDeleteRoti(m_List,item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }
    }
}
