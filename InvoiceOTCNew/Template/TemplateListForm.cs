using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoiceOTCNew
{
    public partial class TemplateListForm : Form 
    {
        #region Declaration & Properties
        protected object DataModelList { get; set; } 
        protected object DataModel { get; set; }
        public object Listener { get; set; }
        
        protected BindingSource bindingSource;        
        #endregion

        #region Constructor
        public TemplateListForm() 
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
            this.headerLbl.Text = header.ToUpper();
        }

        /// <summary>
        /// Set Data Source to get the schema
        /// </summary>
        /// <param name="source"></param>
        protected void SetDataSource(BindingSource source)
        {
            bindingSource = source;
        }        

        /// <summary>
        /// Set Datagridview event
        /// </summary>
        /// <param name="dgView"></param>
        protected void SetDGUserDeletingRow(DataGridView dgView)
        {
            dgView.UserDeletingRow += dgView_UserDeletingRow;
        }

        protected virtual void tambahBtn_Click(object sender, EventArgs e)
        {

        }
        protected virtual void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected virtual void EditBtn_Click(object sender, EventArgs e)
        {

        }
        protected virtual void DeleteBtn_Click(object sender, EventArgs e)
        {
          
        }      
        protected virtual void advancedSearchBtn_Click(object sender, EventArgs e)
        {

        }
        protected virtual void importBtn_Click(object sender, EventArgs e)
        {

        }
        protected virtual void printBtn_Click(object sender, EventArgs e)
        {

        }
        protected virtual void refreshBtn_Click(object sender, EventArgs e) { }
        protected virtual void clearBtn_Click(object sender, EventArgs e) { }
        #endregion

        #region ToolStrip Method
        protected void searchInToolStripCombobox_GotFocus(object sender, EventArgs e)
        {
            //Bail in no data source
            if (bindingSource == null) return;
            if (bindingSource.DataSource == null) return;

            this.searchInCmb.Items.Clear();

            //Add columns name to search in list
            PropertyDescriptorCollection properties = ((ITypedList)bindingSource).GetItemProperties(null);

            foreach (PropertyDescriptor property in properties)
            {
                if (property.PropertyType == typeof(string)) { this.searchInCmb.Items.Insert(0, property.Name); }
                //this.searchInCmb.Items.Insert(0, property.Name);
            }

            //Select first columns name in list,, if columns name were added
            if (this.searchInCmb.Items.Count > 0)
            {
                this.searchInCmb.SelectedIndex = 0;
            }
        }
        #endregion

        /// <summary>
        /// Adding method when user delete data from dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dgView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true; //To Prevent Deleting data when user press No in confirm dialog
            DeleteBtn.PerformClick();
        }        
    }
    
}
