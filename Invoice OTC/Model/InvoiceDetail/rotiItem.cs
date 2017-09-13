using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Data_Access;
using FSCollections;

namespace Invoice_OTC.Model
{
    public class rotiItem : FSBindingItem
    {
        #region Declarations

        //Property Variables
        private int p_ID;
        private int invoiceID;
        private string itemCode;
        private string itemName;
        private int itemQty;
        private decimal itemPrice;

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor for data 
        /// </summary>
        
        public rotiItem()
        {

        }

        //Use this to create new data
        public rotiItem(int parentID)
        {            
              rotiItemDAO dao = new rotiItemDAO();
              dao.CreateDatabaseRecord(this, parentID);            
        }

        #endregion

        #region Properties

        public int ID
        {
            get { return p_ID; }
            set { p_ID = value; }
        }

        public int Invoiceid
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }

        public string Code
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public int Qty
        {
            get { return itemQty; }
            set { itemQty = value; }
        }

        public decimal Price
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        #endregion

        #region Method

        internal void DeleteDatabaseRecord()
        {
            rotiItemDAO dao = new rotiItemDAO();
            dao.DeleteDatabaseRecord(this.p_ID);
        }

        internal void UpdateDatabaseRecord()
        {
            rotiItemDAO dao = new rotiItemDAO();
            dao.UpdateDatabaseRecord(this);
        }

        #endregion
    }
}
