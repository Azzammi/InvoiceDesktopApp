using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Outlet
{
    class CommandGetOutlet : Command
    {
        #region Declaration
      
        #endregion

        #region Constructor
       public CommandGetOutlet() { }
        #endregion

        #region Methods
        public override object Execute()
        {
            outletList list = new outletList();
            return list;
        }
        #endregion
    }
}
