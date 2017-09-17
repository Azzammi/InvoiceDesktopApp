using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Data_Access;

namespace Invoice_OTC.Model
{
    class outletItem
    {
        #region Declaration
        private string slsmCode;        
        private string outletCode;
        private string outletName;
        private string outletAddress;
        private string outletRoute;
        private bool outletStatus;
        #endregion

        #region Constructor
        public outletItem() { }
        public outletItem(bool createDatabaseRecord)
        {
            if(createDatabaseRecord != false)
            {
                CreateDatabaseRecord();
            }
        }
        #endregion

        #region Properties
        public string SlsmCode
        {
            get { return slsmCode; }
            set { slsmCode = value; }
        }
        public string OutletCode
        {
            get { return outletCode; }
            set { outletCode = value; }
        }
        public string OutletName
        {
            get { return outletName; }
            set { outletName = value; }
        }
        public string OutletAddress
        {
            get { return outletAddress; }
            set { outletAddress = value; }
        }
        public string OutletRoute
        {
            get { return outletRoute; }
            set { outletRoute = value; }
        }
        public bool OutletStatus
        {
            get { return outletStatus; }
            set { outletStatus = value; }
        }
        
        #endregion

        #region Methods
        internal void CreateDatabaseRecord()
        {
            outletitemDAO dao = new outletitemDAO();
            dao.CreateDatabaseRecord(this);
        }
        //internal void ImportDatabaseRecord()
        //{
        //    outletitemDAO dao = new outletitemDAO();
        //    dao.UpdateDatabaseRecord(this);
        //}
        internal void UpdateDatabaseRecord()
        {
            outletitemDAO dao = new outletitemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            outletitemDAO dao = new outletitemDAO();
            dao.DeleteDatabaseRecord(this.OutletCode);
        }
        #endregion
    }
}
