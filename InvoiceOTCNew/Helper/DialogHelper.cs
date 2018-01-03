using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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

        /// <summary>
        /// Return Selected Excel File to datatable. To Show on the datagridview
        /// </summary>
        /// <param name="sheetName">Default : sheet1</param>
        /// <returns></returns>
        public static DataTable OpenExcelFileDialog(string sheetName)
        {
            var fileName = "";

            using (OpenFileDialog opd = new OpenFileDialog())
            {
                switch (opd.ShowDialog())
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        fileName = opd.FileName;
                        break;
                }
            }                

            var constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                       "'" + fileName + "'" +
                       ";Extended Properties='Excel 8.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + sheetName + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);

            return data;
        }
    }
}
