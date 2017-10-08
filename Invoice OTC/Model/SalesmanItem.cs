using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

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
        private string Stat;
        #endregion

        #region Properties
        public string SlsmCode
        {
            get { return slsmCode; }
            set { slsmCode = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
