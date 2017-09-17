using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;
using Invoice_OTC.Properties;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Invoice_OTC.Data_Access
{
    class outletitemDAO
    {
        #region Declaration 
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public outletitemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString.ToString();
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(outletItem newItem)
        {
            string sql = "INSERT INTO OUTLET (outlcode, outlname, outladdress, outlroute, outlslsm, outlstat) " +
                         "VALUES(@code, @name, @address, @route, @slsmCode, @stat)";
            AddOrUpdateDatabaseRecord(sql, newItem);
        }
        internal void UpdateDatabaseRecord(outletItem updateItem)
        {
            string sql = "UPDATE OUTLET SET " +
                         "outlName = @name, " +
                         "outlAdd1 = @address, " +
                         "outlroute = @route, " +
                         "outlslsm = @slsmCode, " +
                         "outlStat = @stat " +
                         "WHERE outlCode = @code";
            AddOrUpdateDatabaseRecord(sql, updateItem);

        }
        internal void DeleteDatabaseRecord(string kodeOutlet)
        {
            string sql = "Delete From OUTLET Where outlCode = @code";
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
                command.Parameters.AddWithValue("@code", kodeOutlet);                

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

        protected void AddOrUpdateDatabaseRecord(string sql, outletItem itemMaster)
        {
            //try
            //{
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand(sql, connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@code", itemMaster.OutletCode);
                command.Parameters.AddWithValue("@name", itemMaster.OutletName);
                command.Parameters.AddWithValue("@address", itemMaster.OutletAddress);
                command.Parameters.AddWithValue("@route", itemMaster.OutletRoute);
                command.Parameters.AddWithValue("@slsmCode", itemMaster.SlsmCode);
                command.Parameters.AddWithValue("@stat", itemMaster.OutletStatus);

                //execute the command
                command.ExecuteNonQuery();

                //Close and dispose
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }
        #endregion
    }

