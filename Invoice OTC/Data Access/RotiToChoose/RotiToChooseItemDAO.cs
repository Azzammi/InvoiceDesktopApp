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
    class RotiToChooseItemDAO
    {
        #region Declaration
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public RotiToChooseItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(RotiToChooseItem newRoti)
        {
            string sql = "INSERT INTO ITEM " +
                        "(ITEMCODE, ITEMNAME, ITEMSORT, Brand, Jenis, Category, SubCategory, Price, Stat)" +
                        " VALUES " +
                        "(@code, @name, @sort, @brand, @jenis, @category, @subcategory, @price, @stat)";
            AddorUpdateDatabaseRecord(sql, newRoti);
        }
        internal void UpdateDatabaseRecord(RotiToChooseItem updateRoti)
        {
            string sql = "UPDATE ITEM SET " +
                        "ITEMNAME = @code, " +
                        "ITEMSORT = @sort, " +
                        "Brand = @brand, " +
                        "Jenis = @jenis, " +
                        "category = @category, " +
                        "subcategory = @subcategory, " +
                        "price = @price, " +
                        "Stat = @stat " +
                        "WHERE ITEMCODE = @code";
            AddorUpdateDatabaseRecord(sql, updateRoti);
        }
        internal void DeleteDatabaseRecord(string itemCode)
        {
            string sql = "Delete From ITEM Where ITEMCODE = @code";
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
                command.Parameters.AddWithValue("@code", itemCode);

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
        protected void AddorUpdateDatabaseRecord(string sql, RotiToChooseItem itemMaster)
        {
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
                command.Parameters.AddWithValue("@code", itemMaster.ItemCode);
                command.Parameters.AddWithValue("@name", itemMaster.ItemName);
                command.Parameters.AddWithValue("@sort", itemMaster.ItemSort);
                command.Parameters.AddWithValue("@brand", itemMaster.Brand);
                command.Parameters.AddWithValue("@jenis", itemMaster.Jenis);
                command.Parameters.AddWithValue("@category", itemMaster.Category);
                command.Parameters.AddWithValue("@subcategory", itemMaster.SubCategory);
                command.Parameters.AddWithValue("@price", itemMaster.Price);
                command.Parameters.AddWithValue("@stat", itemMaster.Stat);

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
