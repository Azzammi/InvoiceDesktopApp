using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Roti_Item
{
    class CommandSaveRotiList : Command
    {
        #region Declaration
        RotiToChooseList m_List;
        #endregion

        #region Constructor
        public CommandSaveRotiList(RotiToChooseList list)
        {
            m_List = list;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_List.Save("D:/MSSQL/item.txt");
            return null;
        }
        #endregion
    }
}
