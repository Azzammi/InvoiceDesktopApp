using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC.Model
{
    class outletItem
    {
        #region Declaration
        private string slsmCode;
        private string slsmName;
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
        public string SlsmName
        {
            get { return slsmName; }
            set { slsmName = value; }
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

        }
        internal void ImportDatabaseRecord()
        {

        }
        internal void UpdateDatabaseRecord()
        {

        }
        internal void DeleteDatabaseRecord()
        {

        }
        #endregion
    }
}
