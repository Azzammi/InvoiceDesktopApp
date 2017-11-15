using System;
using System.Collections.Generic;
using Invoice_OTC.Data_Access;
using System.Text;
using FSCollections;

namespace Invoice_OTC.Model
{
    public class InvoiceItem : FSBindingItem
    {

        #region Declaration

        //Property Variables
        private RotiList p_Items;
        private int invoiceID;
        private string nomorInvoice;
        private DateTime dueDate;
        private string outletName;
        private decimal subTotal;
        private float ppn;
        private DateTime issuedDate;
        private bool isPPN;
        private string nomorPO;
        private string pengguna;
        private string periode;
        private string paymentMethod;
        private bool isPayed;
        #endregion

        #region Constructor

        public InvoiceItem()
        {

        }

        public InvoiceItem(bool createDatabaseRecord)
        {
            p_Items = new RotiList();

            if (createDatabaseRecord == true)
            {
                InvoiceItemDAO dao = new InvoiceItemDAO();
                dao.CreateDatabaseRecord(this);
            }
        }

        #endregion

        #region Properties

        public RotiList Items
        {
            get { return p_Items; }
            set { p_Items = value; }
        }

        public int InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }

        public string Nomor
        {
            get { return nomorInvoice; }
            set { nomorInvoice = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public string OutletCode
        {
            get { return outletName; }
            set { outletName = value; }
        }

        public decimal SubTotal //Get the value from invoice Detail
        {
            get {
                //Reset the subtotal to zero
                subTotal = 0;

                if (p_Items == null) return 0;

                //Get the sub of subtotal from the rotiList
                foreach (rotiItem item in p_Items)
                {
                    subTotal += item.Price * item.Qty;
                }

                return subTotal;
            }
        }

        public float PPN
        {
            //get { return (float)(SubTotal * 10) / 100; } 
            get {
                if (isPPN)
                {
                    return (float)(subTotal * 10) / 100;
                }
                else
                {
                    return ppn;
                }
            }
            set {
                if (!isPPN)
                {
                    ppn = value;
                }
            }
        }

        public decimal Total
        {
            get { return SubTotal + Convert.ToDecimal(PPN); }
        }

        public DateTime IssuedData
        {
            get { return issuedDate; }
            set { issuedDate = value; }
        }

        public bool IsPPN
        {
            get { return isPPN; }
            set { isPPN = value; }
        }

        public string NomorPO
        {
            get { return nomorPO; }
            set { nomorPO = value; }
        }

        public string Periode
        {
            get { return periode; }
            set { periode = value; }
        }
        public string User
        {
            get { return pengguna; }
            set { pengguna = value; }
        }
        public string Payment
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        public bool IsPayed
        {
            get { return isPayed; }
            set { isPayed = value; }
        }
        #endregion

        #region Methods

        internal void DeleteItem()
        {
            p_Items.ClearRoti();
        }

        internal void CreateDatabaseRecord()
        {
            InvoiceItemDAO dao = new InvoiceItemDAO();
            dao.CreateDatabaseRecord(this, true);
        }

        internal void DeleteDatabaseRecord()
        {
            InvoiceItemDAO dao = new InvoiceItemDAO();
            dao.DeleteDatabaseRecord(this.invoiceID);
        }

        internal void UpdateDatabaseRecord()
        {
            InvoiceItemDAO dao = new InvoiceItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        #endregion
    }
}
