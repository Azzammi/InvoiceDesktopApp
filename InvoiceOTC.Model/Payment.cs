using System;

namespace InvoiceOTC.Model
{
    public class Payment
    {
        #region Properties
        public int paymentId { get; set; }
        public DateTime paymentDate { get; set; }
        public string paymentName { get; set; }
        public string paymentJournal { get; set; }
        public string paymentMethodType { get; set; }
        public string customer { get; set; }
        public string memo { get; set; }
        public string paymentAmount { get; set; }
        public string paymentStatus { get; set; }
        #endregion        
    }
}
