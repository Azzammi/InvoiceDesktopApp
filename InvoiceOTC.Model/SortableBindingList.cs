using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace InvoiceOTC.Model
{
    public class SortableBindingList<T> : FSBindingList<T>
    {
        private IList<T> logs;

        public SortableBindingList(IList<T> logs)
        {
            this.logs = logs;
        }
    }
}
