using System;
using System.Collections.Generic;
using Invoice_OTC.Data_Access;
using System.Text;
using FSCollections;

namespace Invoice_OTC.Model
{
    class InvoiceList : FSBindingList<InvoiceItem>
    {
        #region Declarations

        #endregion
        #region Constructor

        public InvoiceList()
        {
            InvoiceListADO dao = new InvoiceListADO();
            dao.LoadInvoiceList(this);
        }

        #endregion
        
        #region Methods

        //internal int GetInvoiceNumber(int invoiceID) {
        //    return Find("invoiceID", Convert.ToString(invoiceID));
        //}

        internal InvoiceItem GetInvoice(int invoiceID)
        {
            foreach (InvoiceItem invoice in this)
            {
               // if (invoice.InvoiceID == GetInvoiceNumber(invoiceID));
               // {
                    return invoice;
               // }
            }
            return null;

            //this.FindCore(m_invoiceItem.InvoiceID, invoiceID);
            
        }

        //internal InvoiceItem GetInvoice(string invoiceNomor)
        //{
        //    foreach(InvoiceItem invoice in this)
        //    {
        //        if(invoice.Nomor == invoiceNomor)
        //        {
        //           return invoice;
        //        }
        //    }
        //    return null;          
        //}        

        #endregion
    }
}
