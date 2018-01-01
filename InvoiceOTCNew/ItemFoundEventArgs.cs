using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Controller
{
    public class ItemFoundEventArgs:EventArgs
    {
        #region Declarations
        private int m_Index;
        #endregion

        #region Constructor
        public ItemFoundEventArgs(int index)
        {
            m_Index = index;
        }
        #endregion

        #region Properties
        public int Index
        {
            get { return m_Index; }
        }
        #endregion
    }

    public delegate void ItemFoundEventHandler(object sender, ItemFoundEventArgs e);
}
