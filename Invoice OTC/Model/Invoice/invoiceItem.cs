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
        private DateTime periodeBulan;
        private string slsmCode;
        private string slsmName;
        private string slsmFullName;
        private decimal subTotal;
        private float ppn;
        private decimal total;
        private DateTime issuedData;

        #endregion

        #region Constructor

        public InvoiceItem()
        {

        }

        public InvoiceItem(bool createDatabaseRecord)
        {
            p_Items = new RotiList();

            if(createDatabaseRecord == true)
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

        public DateTime PeriodeBulan
        {
            get { return periodeBulan; }
            set { periodeBulan = value; }
        }

        public string SlsmCode
        {
            get { return slsmCode; }
            set { slsmCode = value; }
        }

        public string SlsmName
        {
            get { return slsmName; }
            set { slsmName = value; }
        }

        public string SlsmFullName //Get the value from the textbox
        {
            get { return slsmCode + " | " + slsmName; }
            set {
                //Set slsmCode
                slsmCode = value;
                slsmCode = slsmCode.Substring(0, 6);
                
                //Set slsmName
                SlsmName = value;
                SlsmName = slsmName.Remove(0, 9);
                SlsmName = SlsmName.Trim(); //Remove all white space
            }
        }

        public decimal SubTotal //Get the value from invoice Detail
        {
            get {
                //Reset the subtotal to zero
                subTotal = 0;

                if (p_Items == null) return 0;

                //Get the sub of subtotal from the rotiList
                foreach(rotiItem item in p_Items)
                {
                    subTotal += item.Price * item.Qty;
                }

                return subTotal;
            }            
        }

        public float PPN
        {
            get { return ppn; }
            set { ppn = value; }
        }

        public decimal Total
        {
            //It will using the subTotal Value until i figured the formula of PPN
            get { return subTotal; }                   
        }

        public DateTime IssuedData
        {
            get { return issuedData; }
            set { issuedData = value; }
        }

        #endregion

        #region Methods

        internal void DeleteItem()
        {
            p_Items.ClearRoti();
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
