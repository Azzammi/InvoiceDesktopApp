using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_OTC.Controller
{
    class miscellanacousFunction
    {
        #region Methods
        internal void ResetInput(Form frm)
        {
            foreach (Control ctl in frm.Controls)
            {
                if (ctl is TextBox) ctl.Text = "";
            }
        }
        internal void DisableInput(Form frm)
        {
            foreach (Control ctl in frm.Controls)
            {
                if (ctl is TextBox || ctl is ComboBox || ctl is DataGridView || ctl is DateTimePicker) ctl.Enabled = false;
            }
        }
        internal void EnableInput(Form frm)
        {
            foreach (Control ctl in frm.Controls)
            {
                if (ctl is TextBox || ctl is ComboBox || ctl is DataGridView || ctl is DateTimePicker) ctl.Enabled = true;
            }
        }
        #endregion
    }
}
