using Invoice_OTC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC.Controller
{
    class CommandGetInvoice : Command
    {
        #region Declrations
        string m_invoiceNumber = null;
        int m_invoiceID = 0;
        InvoiceList m_invoiceToSearch;
        #endregion

        #region Constructor
        
        public CommandGetInvoice(string invoiceNumber, InvoiceList invoiceToSearch)
        {
            m_invoiceNumber = invoiceNumber;
            this.m_invoiceToSearch = invoiceToSearch;  
        }

        public CommandGetInvoice(int invoiceID, InvoiceList invoiceToSearch)
        {
            m_invoiceID = invoiceID;
            this.m_invoiceToSearch = invoiceToSearch;
        }
        #endregion

        #region Methods
        public override object Execute()
        {            
            if(m_invoiceID == 0)
            {
               // m_invoiceToSearch.GetInvoice(m_invoiceNumber);
                return m_invoiceToSearch;
            }

            m_invoiceToSearch.GetInvoice(m_invoiceID);
            return m_invoiceToSearch;

        }
        
        #endregion
    }
}
