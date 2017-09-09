using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    class CommandGetCustomer : Command
    {
        #region Declaratiojns
        
        #endregion

        #region Methods
        public override object Execute()
        {
            CustomerList list = new CustomerList();
            return list;    
        }
        #endregion
    }
}
