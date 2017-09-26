using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Invoice_Detail
{
    class CommandGetItem : Command
    {
        #region Method
        public override object Execute()
        {
            RotiList list = new RotiList(true);
            return list;
        }
        #endregion
    }
}
