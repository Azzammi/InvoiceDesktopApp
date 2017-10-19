using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoice_OTC.Data_Access;
using FSCollections;
using System.Drawing;

namespace Invoice_OTC.Model
{
    class SalesmanItem : FSBindingItem
    {
        #region Declaration
        private string slsmCode;
        private string slsmName;
        private string slsmAddress;
        private string slsmTelp;
        private string slsmSupv;
        private string slsmPhoto;
        private bool stat;
        #endregion

        #region Constructor
        public SalesmanItem()
        {

        }
        #endregion

        #region Properties
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
        public string SlsmAddress
        {
            get { return slsmAddress; }
            set { slsmAddress = value; }
        }
        public string SlsmTelp
        {
            get { return slsmTelp;}
            set { slsmTelp = value; }
        }
        public string SlsmSupv
        {
            get { return slsmSupv; }
            set { slsmSupv = value; }
        }
        public string SlsmPhoto
        {
            get { return slsmPhoto; }
            set { slsmPhoto = value; }
        }
        public bool Stat
        {
            get { return stat; }
            set { stat = value; }
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord()
        {
            //SalesmanItemDAO dao = new SalesmanItemDAO();
            //dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {
            //SalesmanItemDAO dao = new SalesmanItemDAO();
            //dao.UpdateDatabaseRecord(this);
        }
        internal void CreateOrUpdateDatabaseRecord()
        {
            SalesmanItemDAO dao = new SalesmanItemDAO();
            dao.CreateOrUpdateDatabase(this);            
        }
        internal void DeleteDatabaseRecord()
        {
            SalesmanItemDAO dao = new SalesmanItemDAO();
            dao.DeleteDatabaseRecord(this.SlsmCode);
        }
        #endregion
    }
}
