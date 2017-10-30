using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Invoice_OTC.Controller;
using Invoice_OTC.Controller.Account;
using Invoice_OTC.Model;
using System.Windows.Forms;

namespace Invoice_OTC.View
{
    public partial class FrmListAccount : Form
    {
        #region Declartion
        AppController m_AppController;
        AccountList<accountItem> m_List;
        #endregion

        public FrmListAccount()
        {
            InitializeComponent();
        }

        private void FrmListAccount_Load(object sender, EventArgs e)
        {
            m_AppController = new AppController();

            //CommandGetAccount getAccount = new CommandGetAccount();
            //m_List = (AccountList<accountItem>)m_AppController.ExecuteCommand(getAccount);

            //accountItemBindingSource.DataSource = m_List;
        }

        private void accountItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            CommandSaveAccountList saveList = new CommandSaveAccountList(m_List);
            m_AppController.ExecuteCommand(saveList);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog opd = new OpenFileDialog())
            {
                switch (opd.ShowDialog()){
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        CommandLoadAccountList newList = new CommandLoadAccountList(opd.FileName);
                        m_List = (AccountList<accountItem>)m_AppController.ExecuteCommand(newList);

                        accountItemBindingSource.DataSource = m_List;
                        break;
                }
            }
        }
    }
}
