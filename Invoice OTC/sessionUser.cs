using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC
{
    public static class sessionUser
    {
        #region Declaration
        private static string currentUser;
        private static string levelUser;
        private static bool isLoggedIn;
        #endregion

        #region Constructor
        static sessionUser()
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
            currentUser = "";
            isLoggedIn = false;
        }
        #endregion
    }
}
