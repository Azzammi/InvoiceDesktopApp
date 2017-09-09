using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    class CommandGetInvoices : Command
    {
        #region Declarations
        string m_NomorInvoice;
        #endregion
        #region Constructor

        public CommandGetInvoices()
        {

        }

        public CommandGetInvoices(string nomorInvoice)
        {
            m_NomorInvoice = nomorInvoice;
        }

        #endregion

        #region methods

        public override object Execute()
        {
            InvoiceList list = new InvoiceList();
            return list;
        }
        

        #endregion
    }
}
