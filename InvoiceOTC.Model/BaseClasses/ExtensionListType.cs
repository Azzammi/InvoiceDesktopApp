using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSCollections
{
    public static class ExtensionListType
    {
        public static FSBindingList<TSource> ToListSorted<TSource>(this IEnumerable<TSource> source)
        {
            return new FSBindingList<TSource>(source);
        }
    }
}
