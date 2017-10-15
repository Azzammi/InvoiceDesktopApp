using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
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
            //OutletListDAO dao = new OutletListDAO();
            //dao.ShowList(this);
            OutletListDAO dao = new OutletListDAO();
            dao.ShowListWithLinq(this);
        }

        public outletList(string param)
        {
            OutletListDAO dao = new OutletListDAO();
            dao.ShowListWithLinq(this,OutletListDAO.OutletParameter.OutletName,param);
        }
        //public outletList(string periode)
        //{
        //    //Set the connection
        //    DataClasses1DataContext db = new DataClasses1DataContext();

        //    //Get a typed table
        //    Table<OUTLET> outlets = db.GetTable<OUTLET>();

        //    //Get all author
        //    var allItem = from toko in outlets select toko;

        //    return allItem;
        //}
        #endregion
    }
}
