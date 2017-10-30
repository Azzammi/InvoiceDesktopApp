using System;
using System.Collections.Generic;
using System.Linq;
using FSCollections;
using Invoice_OTC.Data_Access;

namespace Invoice_OTC.Model
{
    class AccountList<T> : FSBindingList<accountItem>
    {
        public AccountList()
        {
            AccountListDAO dao = new AccountListDAO();
            dao.accountList(this);
        }
        public AccountList(bool mantap)
        {

        }
    }
}
