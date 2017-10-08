using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller.Invoice
{
    class CommandInsertByDetailInvoice : Command
    {
        #region Declaration
        InvoiceItem m_Item;
        #endregion

        #region Constructor
        public CommandInsertByDetailInvoice(InvoiceItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_Item.CreateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
