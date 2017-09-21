using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Roti_Item
{
    class CommandDeleteRoti : Command
    {
        #region Declaration
        RotiToChooseList m_List;
        RotiToChooseItem m_Item;
        #endregion

        #region Constructor
        public CommandDeleteRoti(RotiToChooseList list, RotiToChooseItem item)
        {
            m_List = list;
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.DeleteDatabaseRecord();
            m_List.Remove(m_Item);
            return null;
        }
        #endregion
    }
}
