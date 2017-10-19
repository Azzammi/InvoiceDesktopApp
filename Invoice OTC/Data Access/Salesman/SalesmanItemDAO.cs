using System;
using System.Collections.Generic;
using System.Linq;
using Invoice_OTC.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Invoice_OTC.Data_Access
{
    class SalesmanItemDAO
    {
        #region Declaration
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public SalesmanItemDAO()
        {
            m_ConnectionString = Properties.Settings.Default.ConnectionString.ToString();
        }
        #endregion

        #region Methods       
        internal void DeleteDatabaseRecord(string SlsmCode)
        {
            string sql = "Delete From Salesman Where slsmCode = @code";
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand(sql, connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@code", SlsmCode);

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
                sql = null;
            }
        }
        internal void CreateOrUpdateDatabase(SalesmanItem itemMaster)
        {
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command     
                string sql2 = "CRUSalesman";
                SqlCommand command = new SqlCommand(sql2, connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@slsmCode", itemMaster.SlsmCode);
                command.Parameters.AddWithValue("@slsmName", itemMaster.SlsmName);
                command.Parameters.AddWithValue("@slsmAddress", itemMaster.SlsmAddress);
                command.Parameters.AddWithValue("@slsmTelp", itemMaster.SlsmTelp);
                command.Parameters.AddWithValue("@slsmSupv", itemMaster.SlsmSupv);
                command.Parameters.AddWithValue("@slsmPhoto", itemMaster.SlsmPhoto);
                command.Parameters.AddWithValue("@slsmStat", itemMaster.Stat);

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
