using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Data_Access;
using FSCollections;

namespace Invoice_OTC.Model
{
    class outletList : FSBindingList<outletItem>
    {
        #region Constructor
        public outletList()
        {
            OutletListDAO dao = new OutletListDAO();
            dao.ShowList(this);
        }
        public outletList(string slsmCode)
        {
            OutletListDAO dao = new OutletListDAO();
            dao.ShowList(this, slsmCode);
        }
        #endregion
    }
}
