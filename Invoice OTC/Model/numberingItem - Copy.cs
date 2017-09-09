using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace Invoice_OTC.Model
{
    public class numberingItemcopr : FSBindingItem
    {
        #region Declarations
        int number;
        #endregion

        #region Constructor

        public numberingItemcopr()
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
