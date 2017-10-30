using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Account
{
    class CommandLoadAccountList : Command
    {
        #region Declaration
        string fileName;
        #endregion

        #region Constructor
        public CommandLoadAccountList(string fileName)
        {
            this.fileName = fileName;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            AccountList<accountItem> m_List = new AccountList<accountItem>(true);
            m_List.Load(fileName);
            return m_List;
        }
        #endregion
    }
}
