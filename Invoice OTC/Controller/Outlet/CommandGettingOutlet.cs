using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Outlet
{
    class CommandGettingOutlet : Command
    {
        #region Declaration 

        #endregion

        #region Method
        public override object Execute()
        {
            outletList list = new outletList();
            return list;
        }
        #endregion
    }
}
