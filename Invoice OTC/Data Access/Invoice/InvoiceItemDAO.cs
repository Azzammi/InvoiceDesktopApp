using System;
using System.Text;
using Invoice_OTC.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Invoice_OTC.Data_Access
{
    public class InvoiceItemDAO
    {
        #region Declaration
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public InvoiceItemDAO()
        {
            m_ConnectionString = Properties.Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods 

        internal void CreateDatabaseRecord(InvoiceItem newInvoice)
        {            
            //Built SqlQuery
            string sql = string.Format("INSERT INTO INVOICED "
                                + "(noInvoice, pengguna) "
                                + "OUTPUT INSERTED.invoiceID "
                                + " VALUES "
                                + "('[1313]','" + Properties.Settings.Default.currentUser + "')");

            //ExecuteQuery
                int newRecordId = DataProvider.ExecuteScalar(sql);

            //Set record ID of the new object
            newInvoice.InvoiceID = newRecordId;
        }

        internal void UpdateDatabaseRecord(InvoiceItem changedInvoice)
        {            
            StringBuilder sqlQuery = new StringBuilder("Update INVOICED SET ");
            sqlQuery.Append(String.Format("noInvoice = '{0}', ", changedInvoice.Nomor));
            sqlQuery.Append(String.Format("dueDate = '{0}', ", changedInvoice.DueDate));
            sqlQuery.Append(String.Format("outletCode = '{0}', ", changedInvoice.OutletCode));            
            sqlQuery.Append(String.Format("subTotal = '{0}', ", changedInvoice.SubTotal));
            sqlQuery.Append(String.Format("ppn = '{0}', ", changedInvoice.PPN));
            sqlQuery.Append(String.Format("total = '{0}', ", changedInvoice.Total));
            sqlQuery.Append(String.Format("issuedDate = '{0}', ", changedInvoice.IssuedData));
            sqlQuery.Append(String.Format("isPPN = '{0}', ", changedInvoice.IsPPN));
            sqlQuery.Append(String.Format("nomorPO = '{0}', ", changedInvoice.NomorPO));
            sqlQuery.Append(String.Format("pengguna = '{0}' ", sessionUser.GetCurrentUser()));
            sqlQuery.Append(String.Format("WHERE InvoiceID = '{0}'", changedInvoice.InvoiceID));

            //Execute Query
            DataProvider.ExecuteNonQuery(sqlQuery.ToString());
        }

        internal void DeleteDatabaseRecord(int invoiceID)
        {
            //Build 'Delete' Query
            string sqlQuery = string.Format("Delete from INVOICED WHERE invoiceID = '{0}' ", invoiceID);

            //Execute Query
            DataProvider.ExecuteNonQuery(sqlQuery);
        }

        /// <summary>
        /// overload method to insert new Record Manually
        /// </summary>
        /// <param name="newInvoice">InvoiceItem Type</param>
        /// <param name="isNewRecord">Just insert true to use this method</param>
        internal void CreateDatabaseRecord(InvoiceItem newInvoice, bool isNewRecord)
        {
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //Sql Query
                string sql = "INSERT INTO INVOICED " +
                             "(noInvoice, dueDate, outletCode, Subtotal, PPN, Total,issuedDate, isPPN, pengguna) " +
                             " VALUES " +
                             "(@noinvoice, @dueDate, @outletcode, @subtotal, @ppn, @total, @issueddate, @isppn, @pengguna)";

                //create and configure a command
                SqlCommand command = new SqlCommand(sql, connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@noInvoice", newInvoice.Nomor);
                command.Parameters.AddWithValue("@dueDate", newInvoice.DueDate);
                command.Parameters.AddWithValue("@outletCode", newInvoice.OutletCode);
                command.Parameters.AddWithValue("@subtotal", newInvoice.SubTotal);
                command.Parameters.AddWithValue("@ppn", newInvoice.PPN);
                command.Parameters.AddWithValue("@total", newInvoice.Total);
                command.Parameters.AddWithValue("@issueddate", newInvoice.IssuedData);
                command.Parameters.AddWithValue("@isppn", newInvoice.IsPPN);
                command.Parameters.AddWithValue("@pengguna", newInvoice.User);

                //execute the command
                command.ExecuteNonQuery();

                //Close and dispose
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion
       
    }
}
