using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FSCollections;

namespace Invoice_OTC.Model
{
    class PeriodeItem : FSBindingItem
    {
        #region Declaration
        protected string periodeNumber;
        protected DateTime startDate;
        protected DateTime endDate;
        protected string keterangan;
        protected bool isClosed;
        #endregion

        #region Properties
        public string PeriodeNumber
        {
            get { return periodeNumber; }
            set { periodeNumber = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        public bool IsClosed
        {
            get { return isClosed; }
            set { isClosed = value; }
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord()
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
