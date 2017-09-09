using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Invoice_OTC.Properties;

namespace Invoice_OTC.Data_Access
{
    public static class DataProvider
    {
        #region Declaration

        //Member Variables
        private static string m_ConnectionString = String.Empty;

        #endregion

        #region Constructor

        static DataProvider()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }

        #endregion

        #region methods

        /// <Summary>
        /// Insert, update, or delete a record in the database.
        /// </Summary>
        /// <param name="sqlQuery">The sql query to run against the database</param>
        /// <returns>The number of rows affected by the oparation</returns>
        
        public static int ExecuteNonQuery(string sqlQuery)
        {
            //Create and open a connection
            SqlConnection connection = new SqlConnection(m_ConnectionString);
            connection.Open();

            //create and configure a command
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //execute the command
            int numRowsAffected = command.ExecuteNonQuery();

            //Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();

            //set return value
            return numRowsAffected;
        }     

        /// <summary>
        /// Versi parameter int
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public static int ExecuteScalar(string sql)
        {
            // Create and open a connection
            SqlConnection connection = new SqlConnection(m_ConnectionString);
            connection.Open();

            // Create and configure a command
            SqlCommand command = new SqlCommand(sql, connection);

            // Execute the command
            int result = Convert.ToInt32(command.ExecuteScalar());

            // Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();

            // Set return value
            return result;
        }

        /// <summary>
        /// Retrieve a data set.
        /// </summary>
        /// <param name="sqlQuery">The SQL Select query to run against the database. </param>
        /// <returns>A populated data set.</returns>
        /// <remarks>This method uses a connection string passed in as an argument
        /// to the constructor for this class.</remarks>
        public static DataSet GetDataSet(string sqlQuery)
        {
            // Create dataset
            DataSet dataSet = new DataSet();

            // Populate dataset
            using (SqlConnection connection = new SqlConnection(m_ConnectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlQuery;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);
            }

            // return dataset
            return dataSet;
        }

        #endregion
    }
}
