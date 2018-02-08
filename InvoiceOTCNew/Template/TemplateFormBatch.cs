using System;
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
    public partial class TemplateFormBatch : Form
    {

        #region Declaration

        #endregion

        public TemplateFormBatch()
        {
            InitializeComponent();
        }

        #region Useful Function
        /// <summary>
        /// Setting header text
        /// </summary>
        /// <param name="header"></param>
        protected void SetHeader(string header)
        {
            this.Text = header;
            this.lblHeader.Text = header.ToUpper();
        }

        /// <summary>
        /// Set Data Source to get the schema
        /// </summary>
        /// <param name="source"></param>
        protected void SetDataSource(BindingSource source)
        {
            findStrip2.bindingSource = source;
        }        
        #endregion

        /// <summary>
        /// Method to batch print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void printBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method  to check all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void CheckAllBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Save Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
