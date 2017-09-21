using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Roti_Item
{
    class CommandInsertRoti : Command
    {
        #region Declaration
        RotiToChooseItem m_Item;
        #endregion

        #region Constructor
        public CommandInsertRoti(RotiToChooseItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.CreateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
