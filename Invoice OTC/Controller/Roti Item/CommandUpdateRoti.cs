using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Roti_Item
{
    class CommandUpdateRoti : Command
    {
        #region Declaration
        RotiToChooseItem m_Item;
        #endregion

        #region Constructor
        public CommandUpdateRoti(RotiToChooseItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.UpdateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
