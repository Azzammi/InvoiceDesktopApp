using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    class CommandDeleteInvoice : Command
    {

        #region Declarations

        //Member Variables
        InvoiceList m_invoices;
        InvoiceItem m_invoiceToDelete;
        #endregion

        #region Constructor
        public CommandDeleteInvoice(InvoiceList invoices, InvoiceItem invoiceToDelete)
        {
            m_invoices = invoices;
            m_invoiceToDelete = invoiceToDelete;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_invoiceToDelete.DeleteItem();
            m_invoiceToDelete.DeleteDatabaseRecord();
            m_invoices.Remove(m_invoiceToDelete);
            return null;
        }
        #endregion
    }
}
