using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    class CommandGetRoti : Command
    {
        #region Constructor
        public CommandGetRoti()
        {

        }
        #endregion

        #region Methods

        public override object Execute()
        {
            RotiToChooseList rotiList = new RotiToChooseList();
            return rotiList;
        }

        #endregion
    }
}
