using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Repository.API
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Execute INSERT Query to Database. Return int
        /// </summary>
        /// <param name="obj">Object to insert</param>
        /// <returns></returns>
        int Save(T obj);

        /// <summary>
        /// Execute UPDATE Query to database. Return int
        /// </summary>
        /// <param name="obj">Object to update</param>
        /// <returns></returns>
        int Update(T obj);

        /// <summary>
        /// Execute DELETE Query to database. Return int
        /// </summary>
        /// <param name="obj">Object to delete</param>
        /// <returns></returns>
        int Delete(T obj);

        /// <summary>
        /// Get The List of data. Support sorting, and searching by using ToListSorted() Method Extension.
        /// </summary>
        /// <returns></returns>
        IList<T> GetAll();

        /// <summary>
        /// Get The List of data by respective field and value. Support sorting, and searching by using ToListSorted() Method Extension.
        /// </summary>
        /// <returns></returns>
        IList<T> Search(string key, string value);
    }
}
