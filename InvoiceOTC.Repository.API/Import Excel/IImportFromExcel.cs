using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoiceOTC.Repository.API
{
    public interface IImportFromExcel<T> where T : class
    {
        /// <summary>
        /// Return Compare of the excel file with existing data.
        /// </summary>
        /// <param name="source">The current existing data</param>
        /// <param name="sourceExcel">dataGridToObject method with respective datagridview parameter</param>
        /// <returns></returns>
        IList<T> CheckIfExistRecord(IList<T> source, IList<T> sourceExcel);

        /// <summary>
        /// Convert dataGridView.Value to List of object
        /// </summary>
        /// <param name="dataGridView1">The datagridview to convert</param>
        /// <returns></returns>
        IList<T> dataGridToObjectList(DataGridView dataGridView1);
    }
}
