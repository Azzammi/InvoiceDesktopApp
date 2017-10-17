using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Data_Access;
using FSCollections;

namespace Invoice_OTC.Model
{
    class SalesmanList : FSBindingList<SalesmanItem>
    {
        #region Constructor
        public SalesmanList()
        {
            SalesmanListDAO dao = new SalesmanListDAO();
            dao.LoadCustomerList(this);
        }
        #endregion
    }
}
