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
        public string slsmCode { get; set; }
        public string outletCode { get; set; }
        public string outletName { get; set; }
        public string outletAddress { get; set; }
        public string outletRoute { get; set; }
       // public string outletType { get; set; }
        public bool outletStatus { get; set; }
        #endregion
    }
}
