using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using Invoice_OTC.Data_Access;

namespace Invoice_OTC.Model
{
    public class CustomerList : FSBindingList<CustomerItem>
    {
        #region Constructor
        public CustomerList()
        {
            CustomerListDAO dao = new CustomerListDAO();
            dao.LoadCustomerList(this);
        }
        #endregion
    }
}
