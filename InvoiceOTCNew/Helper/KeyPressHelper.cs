using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceOTCNew.Helper
{
    /// <summary>
    /// Class for handling keypress event based on https://github.com/rudi-krsoftware/open-retail 
    /// </summary>
    class KeyPressHelper
    {
        /// <summary>
        /// Check if user press the enter key
        /// </summary>
        /// <param name="e"></param>
        /// <returns>bool</returns>
        public static bool IsEnter(KeyPressEventArgs e)
        {
            return (e.KeyChar == (char)Keys.Return);
        }
        
        public static bool IsEnter(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Enter);
        }

        /// <summary>
        /// Check if user press escape key
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsEsc(KeyPressEventArgs e)
        {
            return (e.KeyChar == (char)Keys.Enter);
        }

        public static bool IsEsc(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Enter);
        }

        public static bool IsShortCutKey(Keys shortcut, KeyEventArgs e)
        {
            return (e.KeyCode == shortcut);
        }

        /// <summary>
        /// Move to next control
        /// </summary>
        public static void NextFocus()
        {
            SendKeys.Send("{TAB}");
        }

        /// <summary>
        /// Number only input validation
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool NumericOnly(KeyPressEventArgs e)
        {
            string strValid = "0123456789.";

            if (strValid.IndexOf(e.KeyChar) < 0 && !(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return true; // not valid
            }
            else
            {
                return false; // valid
            }
        }

        /// <summary>
        /// Send enter keyPressEvent
        /// </summary>
        /// <returns></returns>
        public static KeyPressEventArgs SendEnter()
        {
            return new KeyPressEventArgs((char)Keys.Return);
        }
    }
}
