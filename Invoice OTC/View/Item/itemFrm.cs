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
        Form1 m_motherForm;
        #endregion

        public itemFrm()
        {
            InitializeComponent();
        }

        public itemFrm(Form1 motherForm)
        {
            m_motherForm = motherForm;
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
            CommandSaveRotiList saveRoti = new CommandSaveRotiList(m_List);
            m_AppController.ExecuteCommand(saveRoti);
        }
    }
}
