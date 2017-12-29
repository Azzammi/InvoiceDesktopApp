using System;
using System.Windows.Forms;

namespace InvoiceOTCNew
{
    public static class DialogHelper
    {
        /// <summary>
        /// Show Delete Confirmation
        /// </summary>
        /// <param name="data">Input any question or record primary key</param>
        /// <returns></returns>
        public static int DeleteDialog(object data)
        {
            var result = 0;
            
            //Confirm Delete           
            var message = String.Format("Delete Items " + data + " ?");
            DialogResult dialogResult = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Delete Item
            if (dialogResult == DialogResult.Yes || dialogResult == DialogResult.OK)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
