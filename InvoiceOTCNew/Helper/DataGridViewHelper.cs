
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

            if (dgView2 != null)
            {
                dgView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
                dgView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
                dgView2.DefaultCellStyle = dataGridViewCellStyle6;
            }
        }
    }
}
