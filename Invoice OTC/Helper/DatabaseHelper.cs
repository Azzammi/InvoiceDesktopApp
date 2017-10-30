using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Properties;
using System.Windows.Forms;

namespace Invoice_OTC.Helper
{
    class DatabaseHelper
    {
        #region Declaration
        private static SqlConnection koneksi = new SqlConnection(Settings.Default.ConnectionString);
        #endregion
        #region Method
        //internal SqlConnection Koneksi()
        //{
        //    return new SqlConnection(Settings.Default.ConnectionString);
        //}
        public SqlConnection Koneksi
        {
            get { return koneksi; }
        }

        internal void StartConnection()
        {
            try
            {
                koneksi.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void CloseConnection()
        {
            try
            {
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
