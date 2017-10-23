#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Invoice_OTC.Model;
using System.Text;
using System.Windows.Forms;

namespace Invoice_OTC.View
{
    public partial class FrmLogin : Syncfusion.Windows.Forms.MetroForm
    {
        #region Declaration
        accountItem m_Item;
        private bool isLoggedIn;
        #endregion

        #region Properties
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
        }
        #endregion
        public FrmLogin()
        {
            InitializeComponent();           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            m_Item = (accountItem)accountItemBindingSource.Current;
            if (m_Item == null) return;

            if(m_Item.Login())
            {
                isLoggedIn = true;
                MessageBox.Show("Selamat ! Anda Berhasil Masuk");

                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            accountItemBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDaftarUser frm = new FrmDaftarUser();
            frm.ShowDialog();
        }
    }
}
