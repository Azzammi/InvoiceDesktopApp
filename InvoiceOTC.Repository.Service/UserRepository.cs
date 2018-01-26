using System.Collections.Generic;
using System.Linq;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using FSCollections;
using System.Windows.Forms;
using System;

namespace InvoiceOTC.Repository.Service
{
    public class UserRepository : IUserRepository
    {
        #region Declaration
        private ILog m_Log;
        private string m_Sql;
        private IDapperContext context;
        #endregion

        #region Constructors
        public UserRepository()
        {
            context = new DapperContext();
        }
        public UserRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
        }
        #endregion

        #region Select Methods
        public IList<User> GetAll()
        {
            IList<User> list = new List<User>();
            try
            {
                m_Sql = @"SELECT userid, username, password, authlevel, joineddate FROM users;";
                list = context.db.Query<User>(m_Sql).ToList();
            }
            catch(Exception ex)
            {
                m_Log.Error("Pengambilan data gagal, Cek Log atau hubungi hubungi admin", ex);
            }
            return list;
        }
        public IList<User> Search(string key, string value)
        {
            IList<User> list = new List<User>();
            string newValue = "%" + value + "%";

            //Default Key For Search
            if (string.IsNullOrEmpty(key)) key = "username";
            try
            {
                m_Sql = @"SELECT userid, username, password, authlevel, joineddate FROM users WHERE " + key + " ILIKE @newValue;";
                list = context.db.Query<User>(m_Sql, new { newValue }).ToList();
            }
            catch (Exception ex)
            {
                m_Log.Error("Pengambilan data gagal, Cek Log atau hubungi hubungi admin", ex);
            }
            return list;
        }
        #endregion

        #region CRUD Methods
        public int Save(User obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO users(userid, username, password, authlevel, joineddate)
                            VALUES (@userid, @username, @password, @authlevel, @joinedDate);";
                result = context.db.Execute(m_Sql, obj);
            }
            catch(Exception ex)
            {
                m_Log.Error("Terjadi error saat menyimpan ke database",ex);
            }
            return result;
        }
        public int Update(User obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"UPDATE users" +
                         "SET username = @username, password = @password, authlevel = @authlevel, joineddate = @joineddate " +
                         "WHERE userid = @userid;";
                result = context.db.Execute(m_Sql, obj);
            }
            catch (Exception ex)
            {
                m_Log.Error("Terjadi error saat mengedit data", ex);
            }
            return result;
        }
        public int Delete(User obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"DELETE FROM users WHERE UserID = @userid and username = @username";
                result = context.db.Execute(m_Sql, obj);
            }
            catch(Exception ex)
            {
                m_Log.Error("Delete Error",ex);
            }
            return result;
        }
        #endregion

        #region User Session Methods   
        public User Login(string username, string password)
        {
            var user = new User();
            try
            {
                m_Sql = @"SELECT userid, Password FROM users WHERE username = @username;";
                user = context.db.Query<User>(m_Sql, new { username }).SingleOrDefault();

                if(user != null)
                {
                    if(user.Password != password)
                    {
                        MessageBox.Show("Password Salah", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        user = null;
                        throw new Exception("Incorrect Password");
                    }
                }
                else
                {
                    MessageBox.Show(username + " Tidak ditemukan !", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("User Not Found : " + user);
                }

                m_Log.Info("Pengguna : " + username + " login ke system");
            }
            catch(Exception ex)
            {
                m_Log.Error(ex.Message, ex);
            }
            return user;
        }
        public void Logout()
        {
            m_Log.Info("User Logout");
        }
        #endregion
    }
}
