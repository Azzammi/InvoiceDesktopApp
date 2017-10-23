using System;
using System.Collections.Generic;
using System.Linq;
using Invoice_OTC.Model;
using Invoice_OTC.Helper;
using System.Data.SqlClient;
using System.Windows.Forms;
using Invoice_OTC.Properties;

namespace Invoice_OTC.Data_Access
{
    class AccountItemDAO
    {
        #region Declaration
        DatabaseHelper db;
        Encryption encrypt;
        #endregion

        #region Constructor
        public AccountItemDAO()
        {
            db = new DatabaseHelper();
            encrypt = new Encryption();
        }
        #endregion

        #region Method
        internal bool Login(accountItem loginAccount)
        {
            try
            {
                db.StartConnection();
                //SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString.ToString());
                //connection.Open();
                string sql = "SELECT Username FROM USERS WHERE password = @password";

                SqlCommand command = new SqlCommand(sql, db.Koneksi);

                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@password", encrypt.HashPassword(loginAccount.PassWord.Replace("'","")));

                string username = (string)command.ExecuteScalar();


                command.Dispose();
                db.CloseConnection();
                
                if (username == loginAccount.UserName.Replace("'", ""))
                {
                    sessionUser.Login(username);             
                    return true;
                }
                else if(username == "")
                {
                    MessageBox.Show("Password Salah !");
                    return false;
                }
                else
                {
                    MessageBox.Show("Username Salah !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }             
        }
        internal void CreateDatabasesRecord(accountItem newAccount)
        {
            try
            {
                //Create and open a connection            
                db.StartConnection();

                //Sql Query
                string sql = "INSERT INTO Users " +
                             "(userID, userName, password, authLevel, JoinedDate) " +
                             " VALUES " +
                             "(@userID, @userName, @password, @authLevel, @joinedDate)";

                //create and configure a command
                SqlCommand command = new SqlCommand(sql, db.Koneksi);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@userID", newAccount.UserID);
                command.Parameters.AddWithValue("@userName", newAccount.UserName);
                command.Parameters.AddWithValue("@password", encrypt.HashPassword(newAccount.PassWord));
                command.Parameters.AddWithValue("@authLevel", newAccount.AuthLevel);
                command.Parameters.AddWithValue("@joinedDate", newAccount.JoinedDate);          

                //execute the command
                command.ExecuteNonQuery();

                //Close and dispose
                command.Dispose();
                db.CloseConnection();
                //db.Koneksi.Dispose();
            }
            catch (SqlException ex)
            {               
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        #endregion
    }
}
