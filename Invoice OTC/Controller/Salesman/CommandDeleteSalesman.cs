using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Salesman
{
    class CommandDeleteSalesman : Command
    {
        #region Declaration
        SalesmanList m_List;
        SalesmanItem m_Item;
        #endregion

        #region Constructor
        public CommandDeleteSalesman(SalesmanList list, SalesmanItem item)
        {
            m_List = list;
            m_Item = item;
        }
        #endregion

        #region Methdod
        public override object Execute()
        {
            m_Item.DeleteDatabaseRecord();
            m_List.Remove(m_Item);
            return null;
        }
        #endregion
    }
}
