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

        protected void SetDataSource(BindingSource source)
        {
            findStrip2.bindingSource = source;
        }

        /// <summary>
        /// Set DataGridColumnsHeaderStyle, AlternateRowStyle, CellDefaultStyle, and CellBorder = Single
        /// </summary>
        /// <param name="dgView1">DataGridView that will be applying style</param>
        /// <param name="dgView2">Optional, if there's two DataGridView</param>
        protected void SetDataGridTheme(DataGridView dgView1, DataGridView dgView2 = null)
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgView1.AutoGenerateColumns = false;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgView1.DefaultCellStyle = dataGridViewCellStyle6;

            if(dgView2 != null)
            {
                dgView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
                dgView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
                dgView2.DefaultCellStyle = dataGridViewCellStyle6;
            }
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
    }
    
}
