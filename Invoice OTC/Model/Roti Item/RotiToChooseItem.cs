using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace Invoice_OTC.Model
{
    public class RotiToChooseItem : FSBindingItem
    {
        #region Declarations

        //Member Variables
        private string itemCode;
        private string itemName;
        private string itemSort;

        #endregion

        #region Constructor

        public RotiToChooseItem()
        {

        }

        #endregion

        #region Properties

        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string ItemSort
        {
            get { return itemSort; }
            set { itemSort = value; }
        }
        #endregion
    }
}
