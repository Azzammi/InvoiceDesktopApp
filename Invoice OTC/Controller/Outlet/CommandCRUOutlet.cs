using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Outlet
{
    class CommandCRUOutlet : Command
    {
        #region Declaration
        outletItem m_Item;
        bool isUpdate;
        #endregion

        #region Constructor
        public CommandCRUOutlet() { }
        public CommandCRUOutlet(outletItem item)
        {
            m_Item = item;
            this.isUpdate = true;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            if(isUpdate != false)
            {
                m_Item.UpdateDatabaseRecord();
                return m_Item;
            }
            else
            {
                m_Item.CreateDatabaseRecord();
                return m_Item;
            }            
       }
        #endregion
    }
}
