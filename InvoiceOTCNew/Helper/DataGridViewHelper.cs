
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceOTCNew.Helper
{
    public static class DataGridViewHelper
    {
        /// <summary>
        /// Set DataGridColumnsHeaderStyle, AlternateRowStyle, CellDefaultStyle, and CellBorder = Single
        /// </summary>
        /// <param name="dgView1">DataGridView that will be applying style</param>
        /// <param name="dgView2">Optional, if there's two DataGridView</param>
        public static void SetDataGridTheme(DataGridView dgView1, DataGridView dgView2 = null)
        {
            #region AlternatingRows Cell Style
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();            
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            #endregion

            #region Column Header Style
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;            
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            #endregion

            #region Default Cell Style
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));            
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;        
            #endregion

            dgView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgView1.AutoGenerateColumns = false;
            dgView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;            
            dgView1.ColumnHeadersHeight = 22;
            dgView1.DefaultCellStyle = dataGridViewCellStyle1;
            dgView1.RowTemplate.Height = 40;

            if (dgView2 != null)
            {
                dgView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
                dgView2.AutoGenerateColumns = false;
                dgView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
                dgView2.ColumnHeadersHeight = 22;
                dgView2.DefaultCellStyle = dataGridViewCellStyle1;
                dgView2.RowTemplate.Height = 40;
            }
        }
    }
}
