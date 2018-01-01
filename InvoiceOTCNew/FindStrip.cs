using InvoiceOTCNew.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using System.Windows.Forms;

namespace InvoiceOTC.Controller
{
    public class FindStrip : System.Windows.Forms.ToolStrip
    {

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Declarations    
        public ToolStripTextBox searchTxt;
        public ToolStripComboBox searchInCmb;
        private ToolStripLabel toolStripLabel1;        
        private ToolStripLabel toolStripLabel2;        
        private ToolStripButton searchBtn;
        private ToolStripButton refreshBtn;
        private BindingSource m_bindingSource;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox advancedSearchChk;
        public event ItemFoundEventHandler ItemFound;
        #endregion

        #region Properties

        public BindingSource bindingSource
        {
            get { return m_bindingSource; }
            set { m_bindingSource = value; }
        }         
        #endregion

        #region Constructor
        public FindStrip()
        {
            InitializeComponent();   
        }


        #endregion

        #region Methods

        private void searchInToolStripCombobox_GotFocus(object sender, EventArgs e)
        {
            //Bail in no data source
            if (m_bindingSource == null) return;
            if (m_bindingSource.DataSource == null) return;

            this.searchInCmb.Items.Clear();

            //Add columns name to search in list
            PropertyDescriptorCollection properties = ((ITypedList)bindingSource).GetItemProperties(null);

            foreach(PropertyDescriptor property in properties)
            {
                if (property.PropertyType == typeof(string)) { this.searchInCmb.Items.Insert(0, property.Name); }
                //this.searchInCmb.Items.Insert(0, property.Name);
            }

            //Select first columns name in list,, if columns name were added
            if(this.searchInCmb.Items.Count > 0)
            {
                this.searchInCmb.SelectedIndex = 0;
            }
        }

        private void searchBtnToolStripButton_Click(object sender,EventArgs e)
        {
            if(advancedSearchChk.CheckState == CheckState.Checked)
            {
                //AdvancedSearchMethod();               
            }
            else
            {
                this.Find();
            }            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (m_bindingSource == null) return;
            this.m_bindingSource.ResetBindings(true);
        }

        private void Find()
        {
            //Don't search if nothing specified to look for
            string find = this.searchTxt.Text;
            if (string.IsNullOrEmpty(find.Trim())) return;

            //Don't search of a column isn;t specified to search in
            string findIn = this.searchInCmb.Text;
            if (string.IsNullOrEmpty(findIn.Trim())) return;

            //Get the property descriptor
            PropertyDescriptorCollection properties = ((ITypedList)m_bindingSource).GetItemProperties(null);
            PropertyDescriptor property = properties[findIn];

            //Find a value in a column
            int index = m_bindingSource.Find(property, find);

            //Call method 
            this.OnItemFound(new ItemFoundEventArgs(index));
        }

        protected virtual void OnItemFound(ItemFoundEventArgs e)
        {
            //Report Find results
            ItemFound?.Invoke(this, e);
        }

        private void AdvancedSearchChk_CheckedChanged(object sender, EventArgs e)
        {
            if(advancedSearchChk.CheckState == CheckState.Checked)
            {
                searchBtn.Visible = false;
            }
            else
            {
                searchBtn.Visible = true;
            }
        }
        #endregion

        #region InitComponent
        private void InitializeComponent()
        {
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.searchInCmb = new System.Windows.Forms.ToolStripComboBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.advancedSearchChk = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.SuspendLayout();
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 29);
            this.toolStripLabel1.Text = "Search :";
            // 
            // searchTxt
            // 
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 32);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 29);
            this.toolStripLabel2.Text = "Search In:";
            // 
            // searchInCmb
            // 
            this.searchInCmb.Name = "searchInCmb";
            this.searchInCmb.Size = new System.Drawing.Size(100, 32);
            this.searchInCmb.GotFocus += new System.EventHandler(this.searchInToolStripCombobox_GotFocus);
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(52, 29);
            this.searchBtn.Text = "Search !";
            this.searchBtn.Click += new System.EventHandler(this.searchBtnToolStripButton_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 29);
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // advancedSearchChk
            // 
            this.advancedSearchChk.Name = "advancedSearchChk";
            this.advancedSearchChk.Size = new System.Drawing.Size(155, 29);
            this.advancedSearchChk.Text = "Enable Advanced Search";
            this.advancedSearchChk.CheckedChanged += AdvancedSearchChk_CheckedChanged;
            // 
            // FindStrip
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchTxt,
            this.toolStripLabel2,
            this.searchInCmb,
            this.searchBtn,
            this.refreshBtn,
            this.advancedSearchChk});
            this.Name = "findStrip2";
            this.Size = new System.Drawing.Size(772, 32);
            this.TabIndex = 2;
            this.Text = "toolStrip1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
