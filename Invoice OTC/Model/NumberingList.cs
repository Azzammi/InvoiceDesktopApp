using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using Invoice_OTC.Data_Access;

namespace Invoice_OTC.Model
{
    public class NumberingList : FSBindingList<numberingItem>
    {
        #region Declarations
    
        #endregion

        #region Constructor
        public NumberingList(string namaTabel, string namaField)
        {
            numberingListDAO dao = new numberingListDAO();
            dao.LoadNumberList(namaTabel, namaField);
        }
        #endregion

        #region Method
       

        #endregion
    }
}
