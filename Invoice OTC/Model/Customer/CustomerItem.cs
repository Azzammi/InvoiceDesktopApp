using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace Invoice_OTC.Model
{
    public class CustomerItem : FSBindingItem
    {
        #region Declarations

        private string slsmCode;
        private string slsmName;
        private string slsmAddress;
        
        #endregion

        #region Constructor
        public CustomerItem() { }
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
        
        #endregion
    }
}
