using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FSCollections
{
    public static class ExtensionListType
    {
        /// <summary>
        /// Convert IList to Sortable Binding List
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static FSBindingList<TSource> ToListSorted<TSource>(this IEnumerable<TSource> source)
        {
            return new FSBindingList<TSource>(source);
        }

        public static List<TSource> ToList<TSource>(this DataTable dataTable) where TSource : new()
        {
            var dataList = new List<TSource>();

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;

            var objFieldName = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
                                select new
                                {
                                    Name = aProp.Name,
                                    Type = Nullable.GetUnderlyingType(aProp.PropertyType) ?? aProp.PropertyType
                                }).ToList();
            var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
                                     select new
                                     {
                                         Name = aHeader.ColumnName,
                                         Type = aHeader.DataType
                                     }).ToList();
            var commonFields = objFieldName.Intersect(dataTblFieldNames).ToList();

            foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            {
                var aTSource = new TSource();
                foreach (var aField in commonFields)
                {
                    PropertyInfo propertyInfos = aTSource.GetType().GetProperty(aField.Name);
                    var value = (dataRow[aField.Name] == DBNull.Value) ? null : dataRow[aField.Name]; //if database field is nullable
                    propertyInfos.SetValue(aTSource, value, null);
                }
                dataList.Add(aTSource);
            }

            return dataList;
        }
    }
}
