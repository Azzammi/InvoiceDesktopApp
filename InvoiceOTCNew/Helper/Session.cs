namespace InvoiceOTCNew.Helper
{
    public static class Session
    {
        #region Declaration
        private static string currentUser;
        private static string levelUser;
        private static bool isLoggedIn;        
        #endregion

        #region Constructor
        static Session()
        {

        }
        #endregion

        #region Methods
        internal static void Login(string username)
        {
            currentUser = username;
            isLoggedIn = true;
        }

        internal static void Login(string username, string leveluser)
        {
            currentUser = username;
            levelUser = leveluser;
            isLoggedIn = true;
        }

        internal static string GetCurrentUser()
        {
            return currentUser;
        }

        internal static bool GetLoginStatus()
        {
            return isLoggedIn;
        }

        internal static void LogOut()
        {
            currentUser = null;
            isLoggedIn = false;
        }
        #endregion
    }
}
