using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace Invoice_OTC.Model
{
    public class numberingItem : FSBindingItem
    {
        #region Declarations
        int number;
        #endregion

        #region Constructor

        public numberingItem()
        {

        }

        #endregion

        #region Properties

        public int NumberIncrement
        {
            get { return number; }
            set { number = value; }          
        }
        #endregion
    }
}
