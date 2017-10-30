using System;
using System.Collections.Generic;
using System.Linq;
using FSCollections;
using Invoice_OTC.Data_Access;

namespace Invoice_OTC.Model
{
    [Serializable]
    class accountItem 
    {
        #region Declaration
        private string userId;
        private string userName;
        private string password;
        private string authLevel;
        private DateTime joinedDate;
        private bool isLoggedIn;
        #endregion

        #region Constructor
        public accountItem()
        {

        }
        #endregion

        #region Properties
        public string UserID
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
        public string AuthLevel
        {
            get { return authLevel; }
            set { authLevel = value; }
        }
        public DateTime JoinedDate
        {
            get { return joinedDate; }
            set { joinedDate = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }
        #endregion

        #region Methods
        internal bool Login()
        {
            AccountItemDAO dao = new AccountItemDAO();
            return dao.Login(this);
        }
        internal void CreateDatabaseRecord()
        {
            AccountItemDAO dao = new AccountItemDAO();
            dao.CreateDatabasesRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {

        }
        internal void DeleteDatabaseRecord()
        {

        }
        #endregion
    }
}
