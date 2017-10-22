using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Invoice_OTC.Model;
using System.Windows.Forms;

namespace Invoice_OTC.View
{
    public partial class FrmDaftarUser : Form
    {
        #region Declaration
        accountItem m_Item;
        #endregion

        public FrmDaftarUser()
        {
            InitializeComponent();
        }

        private void FrmDaftarUser_Load(object sender, EventArgs e)
        {
            accountItemBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Item = (accountItem)accountItemBindingSource.Current;
            m_Item.JoinedDate = DateTime.Now;
            m_Item.CreateDatabaseRecord();
        }
    }
}
