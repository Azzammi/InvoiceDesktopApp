using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Data_Access;
using FSCollections;

namespace Invoice_OTC.Model
{
    public class RotiToChooseList: FSBindingList<RotiToChooseItem>
    {
        #region Constructor
        public RotiToChooseList()
        {
            RotiToChooseListDAO dao = new RotiToChooseListDAO();
            dao.ListRotiToChoose(this);
        }
        #endregion
    }
}
