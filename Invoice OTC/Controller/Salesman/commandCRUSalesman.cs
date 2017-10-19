using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Salesman
{
    class commandCRUSalesman : Command
    {
        #region Declartion
        SalesmanItem m_Item;
        #endregion

        #region Declaration
        public commandCRUSalesman(SalesmanItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.CreateOrUpdateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
