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
        internal void resetInput(Form frm)
        {
            foreach(Control ctl in frm.Controls)
            {
                if (ctl is TextBox) ctl.Text = ""; 
            }
        }
    }
}
