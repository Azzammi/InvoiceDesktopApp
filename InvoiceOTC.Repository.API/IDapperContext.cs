using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data;

namespace InvoiceOTC.Repository.API
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection db { get; }
        string GetLastID();
    }
}
