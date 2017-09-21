using Invoice_OTC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC.Controller
{
    class CommandDeleteItem : Command
    {
        #region Declarations
        InvoiceItem m_parent;
        rotiItem m_rotiToDelete;
        #endregion

        #region Constructor
        public CommandDeleteItem(rotiItem rotiToDelete)
        {
            m_rotiToDelete = rotiToDelete;
        }
        public CommandDeleteItem(InvoiceItem parent, rotiItem rotiToDelete)
        {
            m_parent = parent;
            m_rotiToDelete = rotiToDelete;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_rotiToDelete.DeleteDatabaseRecord();
            if (m_parent != null)
            {                
                m_parent.Items.Remove(m_rotiToDelete);
            }            
            return null;
        }
        #endregion
    }
}
