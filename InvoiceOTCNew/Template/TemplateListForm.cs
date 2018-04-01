using System;
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
            findStrip2.bindingSource = source;
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
        protected virtual void findStrip1_ItemFound(object sender, InvoiceOTC.Controller.ItemFoundEventArgs e)
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
        #endregion

        /// <summary>
        /// Adding method when user delete data from dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true; //To Prevent Deleting data when user press No in confirm dialog
            DeleteBtn.PerformClick();
        }
    }
    
}
