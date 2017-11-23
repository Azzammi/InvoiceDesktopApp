using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace InvoiceOTC.Model
{
    public class SortableBindingList<T> : FSBindingList<T>,ICollection<T>
    {
        private IList<T> list;        

        public SortableBindingList()
        {
        }
        
        public SortableBindingList(IList<T> list):base(list)
        {

        }       
    }
}
