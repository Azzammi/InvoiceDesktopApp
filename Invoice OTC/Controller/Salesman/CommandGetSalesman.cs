using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Salesman
{
    class CommandGetSalesman : Command
    {
        #region Constructor
        public CommandGetSalesman(){}
        #endregion

        #region Method
        public override object Execute()
        {
            SalesmanList list = new SalesmanList();
            return list;
        }
        #endregion
    }
}
