using System;

namespace InvoiceOTC.Model
{
    public class PaymentDetail
    {
        public int paymentDetailID;
        public int paymentID;
        public string nomorInvoice;
        public DateTime dueDate;
        public decimal total;
    }
}
