using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    class commandInsertInvoice : Command
    {
        #region Constructor

        public commandInsertInvoice()
        {

        }

        #endregion

        #region Methods

        public override object Execute()
        {
            //Create a new invoice
            bool createDatabaseRecord = true;
            InvoiceItem newItem  = new InvoiceItem(createDatabaseRecord);

            //return value
            return newItem;
        }

        #endregion
    }
}
