using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using System.Runtime.InteropServices;

namespace InvoiceOTCNew
{
    public partial class TemplateListForm : Form 
    {
        #region Declaration
        protected object DataModelList { get; set; } 
        protected object DataModel { get; set; }
        
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

        protected void SetDataSource(BindingSource source)
        {
            findStrip2.bindingSource = source;
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
        #endregion

        protected virtual void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
