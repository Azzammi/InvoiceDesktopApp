using System;
using System.Windows.Forms;

namespace InvoiceOTCNew.Helper
{
    public sealed class InputControlHelper
    {
        public static void DisableInput(Form sender)
        {
            foreach (Control control in sender.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is CheckBox || innerControl is TextBox || innerControl is ComboBox)
                        {
                            innerControl.Enabled = false;
                        }
                    }
                }

                if (control is CheckBox || control is TextBox || control is ComboBox)
                {
                    control.Enabled = false;
                }
            }
        }
        public static void EnableInput(Form sender)
        {
            foreach (Control control in sender.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control innerControl in control.Controls)
                    {                        
                        if (innerControl is CheckBox || innerControl is TextBox || innerControl is ComboBox)
                        {
                            innerControl.Enabled = true;
                        }
                    }
                }

                if (control is CheckBox || control is TextBox || control is ComboBox)
                {
                    control.Enabled = true;
                }
            }
        }
    }
}
