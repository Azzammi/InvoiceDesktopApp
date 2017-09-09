using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_OTC.Controller
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
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox searchTxt;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox searchInCmb;
        private ToolStripButton searchBtn;
        private BindingSource m_bindingSource;
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

        public void searchInToolStripCombobox_GotFocus(object sender, EventArgs e)
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
            this.Find();
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


        #endregion

        #region InitComponent
        private void InitializeComponent()
        {
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.searchInCmb = new System.Windows.Forms.ToolStripComboBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
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
            searchInCmb.GotFocus += new EventHandler(searchInToolStripCombobox_GotFocus);
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(52, 29);
            this.searchBtn.Text = "Search !";
            searchBtn.Click += new EventHandler(searchBtnToolStripButton_Click);
            // 
            // FindStrip
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchTxt,
            this.toolStripLabel2,
            this.searchInCmb,
            this.searchBtn});
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
