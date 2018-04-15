using System;
using System.Windows.Forms;

namespace InvoiceOTCNew.Helper
{
    public sealed class InputControlHelper
    {
        /// <summary>
        /// Disable all input controls in a form. And in tableLayoutPanel too.
        /// </summary>
        /// <param name="sender">This Form</param>
        public static void DisableInput(Form sender)
        {
            foreach (Control control in sender.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is CheckBox || innerControl is TextBox || innerControl is ComboBox || innerControl is DataGridView || innerControl is TableLayoutPanel)
                        {
                            innerControl.Enabled = false;
                        }
                    }
                }

                if (control is CheckBox || control is TextBox || control is ComboBox || control is DataGridView)
                {
                    control.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Enable all input controls in a form. And in tableLayoutPanel too
        /// </summary>
        /// <param name="sender">This Form</param>
        public static void EnableInput(Form sender)
        {
            foreach (Control control in sender.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control innerControl in control.Controls)
                    {                        
                        if (innerControl is CheckBox || innerControl is TextBox || innerControl is ComboBox || innerControl is DataGridView || innerControl is TableLayoutPanel)
                        {
                            innerControl.Enabled = true;
                        }
                    }
                }

                if (control is CheckBox || control is TextBox || control is ComboBox || control is DataGridView)
                {
                    control.Enabled = true;
                }
            }
        }

        /// <summary>
        /// miscellanacious to setting the font, and behaviour of desired control in form
        /// </summary>
        /// <param name="sender">This Form</param>
        public static void SetUpControls(Form sender)
        {
            foreach (Control control in sender.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is CheckBox || innerControl is Label || innerControl is ComboBox)
                        {
                            innerControl.Text = StringHelper.FirstLetterToUpper(innerControl);
                        }
                    }
                }

                if (control is CheckBox || control is Label || control is ComboBox)
                {
                    control.Text = StringHelper.FirstLetterToUpper(control);
                }
            }
        }
    }
}
