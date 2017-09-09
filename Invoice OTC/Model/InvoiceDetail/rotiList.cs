using System;
using System.Collections.Generic;
using System.Text;
using FSCollections;
using Invoice_OTC.Data_Access;

namespace Invoice_OTC.Model
{
    public class RotiList : FSBindingList<rotiItem>
    {
        #region Methods

        internal void ClearRoti()
        {
            //Delete Database Records
            foreach(rotiItem roti in this)
            {
                roti.DeleteDatabaseRecord();
            }
            /* We call BindingList<T>.ClearItems, instead of Clear(),
           * because it raises the ListChanged event. Bound controls
           * in the UI will respond by updating themselves. */

            // Clear list
            ClearItems();
        }

        internal void DeleteRoti(int rotiID)
        {
            //Find Roti to delete
            rotiItem rotiToDelete = null;
            foreach (rotiItem roti in this)
            {
                if(roti.ID == rotiID)
                {
                    rotiToDelete = roti;
                    break;
                }
            }

            //Delete Book
            rotiToDelete.DeleteDatabaseRecord();
            this.Remove(rotiToDelete);
        }

        #endregion
    }
}
