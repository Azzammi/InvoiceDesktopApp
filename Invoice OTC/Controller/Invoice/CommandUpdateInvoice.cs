using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    class CommandUpdateInvoice : Command
    {
        #region Declarations
        InvoiceItem m_InvoiceToUpdate;
        CustomerItem m_CustomerToSelect;
        #endregion

        #region Contructor

        public CommandUpdateInvoice(InvoiceItem InvoiceToUpdate)
        {
            m_InvoiceToUpdate = InvoiceToUpdate;            
        }

        #endregion

        #region Methods

        public override object Execute()
        {            
            m_InvoiceToUpdate.UpdateDatabaseRecord();
            return m_InvoiceToUpdate;
        }

        #endregion
    }
}
