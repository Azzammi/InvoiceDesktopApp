using System;
using System.Linq;
using System.Windows.Forms;

namespace InvoiceOTCNew.Helper
{
    public static class StringHelper
    {
        /// <summary>
        /// Method To Make The First Letter of the string type to uppercase
        /// Credit to this answer https://stackoverflow.com/a/4405876
        /// </summary>
        /// <returns></returns>
        public static string FirstLetterToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "":throw new ArgumentException();
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        /// <summary>
        /// Method To Make The First Letter of the control to uppercase
        /// Credit to this answer https://stackoverflow.com/a/4405876
        /// </summary>
        /// <returns></returns>
        public static string FirstLetterToUpper(Control input)
        {
            switch (input.Text)
            {
                case null: throw new ArgumentNullException(nameof(input.Text));
                case "": return "";         
                default: return input.Text.First().ToString().ToUpper() + input.Text.Substring(1);
            }
        }
    }
}
