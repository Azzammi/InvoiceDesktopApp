using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Account
{
    class CommandSaveAccountList : Command
    {
        #region Declaration
        AccountList<accountItem> m_List;
        #endregion

        #region Constructor
        public CommandSaveAccountList(AccountList<accountItem> list)
        {
            m_List = list;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_List.Save("D:/MSSQL/item.account");
            return null;
        }
        #endregion
    }
}
