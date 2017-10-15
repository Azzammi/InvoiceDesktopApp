using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Outlet
{
    class CommandGettingOutlet : Command
    {
        #region Declaration 
        string param;
        #endregion

        #region Constructor
        public CommandGettingOutlet()
        {

        }
        public CommandGettingOutlet(string param)
        {
            this.param = param;
        }
        #endregion

        #region Method
        public override object Execute()
        {          
            if(param != "" && param != null)
            {
                return new outletList(param);
            }
            else
            {
                return new outletList();
            }            
        }
        #endregion
    }
}
