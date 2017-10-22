using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Outlet
{
    class CommandGetOutletBySalesman : Command
    {
        #region Declaration
        private string slsmCode;
        #endregion

        #region Constructor
        public CommandGetOutletBySalesman(string slsmCode)
        {
            this.slsmCode = slsmCode;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            outletList list = new outletList(slsmCode);
            return list;
        }
        #endregion
    }
}
