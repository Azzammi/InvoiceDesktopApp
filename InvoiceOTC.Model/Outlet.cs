using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class Outlet
    {
        #region Declaration
        private string slsmCode { get; set; }
        private string outletCode { get; set; }
        private string outletName { get; set; }
        private string outletAddress { get; set; }
        private string outletRoute { get; set; }
        private string outletType { get; set; }
        private bool outletStatus { get; set; }
        #endregion
    }
}
