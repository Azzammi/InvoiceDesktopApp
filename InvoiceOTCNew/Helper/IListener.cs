using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTCNew.Helper
{
    public interface IListener
    {
        void Ok(object sender, object data);
        void Ok(object sender, bool isNewData, object data);
    }
}
