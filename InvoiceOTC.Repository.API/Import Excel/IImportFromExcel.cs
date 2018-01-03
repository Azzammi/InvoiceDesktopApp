using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Repository.API
{
    public interface IImportFromExcel<T> where T : class
    {
        IList<T> CheckIfExistRecord(IList<T> source, IList<T> sourceExcel);
    }
}
