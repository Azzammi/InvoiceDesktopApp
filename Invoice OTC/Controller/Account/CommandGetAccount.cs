using System;
using System.Collections.Generic;
using System.Linq;
using Invoice_OTC.Model;
using Invoice_OTC.Controller;
using Invoice_OTC.Controller.Account;

namespace Invoice_OTC.Controller.Account
{
    class CommandGetAccount : Command
    {
        #region Declaration
        //AccountList<accountItem> m_List;
        #endregion

        #region Constructor
        public CommandGetAccount()
        {

        }
        #endregion

        #region Method
        public override object Execute()
        {
            AccountList<accountItem> m_List = new AccountList<accountItem>();
            return m_List;
        }
        #endregion
    }
}
