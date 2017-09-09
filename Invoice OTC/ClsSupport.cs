using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_OTC
{
    class ClsSupport
    {
        public void EmptyText(Form namaForm, ComboBox cbx = null)
        {
            if (cbx != null)
            {
                foreach (Control i in cbx.Controls)
                {
                    if (i is TextBox) { i.Text = null; }
                    if (i is ComboBox) { i.Text = null; }
                }
            }

            foreach (Control i in namaForm.Controls)
            {
                if (i is TextBox) { i.Text = null; }
                if (i is ComboBox) { i.Text = null; }
            }
        }
    }
}
