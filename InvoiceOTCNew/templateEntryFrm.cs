﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceOTCNew
{
    public partial class templateEntryFrm : Form
    {       
        public BindingSource bindingSource { get; set; }
        #region Constructor
        public templateEntryFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Protected and Override Method
        /// <summary>
        /// Setting header text
        /// </summary>
        /// <param name="header"></param>
        protected void SetHeader(string header)
        {
            this.Text = header;
            this.lblHeader.Text = header;
        }

        protected virtual void Simpan()
        {

        }

        protected virtual void AddNew()
        {
            
        }

        #endregion


        private void templateEntryFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simpan();
        }
    }
}
