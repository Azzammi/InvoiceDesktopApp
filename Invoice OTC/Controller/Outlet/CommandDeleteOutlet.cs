using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Outlet
{
    class CommandDeleteOutlet : Command
    {
        #region Declaration
        outletList m_List;
        outletItem m_Item;
        #endregion

        #region Constructor
        public CommandDeleteOutlet(outletList list, outletItem item)
        {
            m_List = list;
            m_Item = item;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_Item.DeleteDatabaseRecord();
            m_List.Remove(m_Item);
            return null;
        }
        #endregion
    }
}
