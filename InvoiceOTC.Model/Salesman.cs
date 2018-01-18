using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class Salesman
    {
        #region Declaration
        public string slsmCode {get; set;}
        public string slsmIdNumber { get; set; }
        public string slsmName {get; set;}
        public string slsmAddress {get; set;}
        public string slsmTelp {get; set;}
        public string slsmSupv {get; set;}
        public string slsmPhoto {get; set;}
        public bool stat {get; set;}
        #endregion
    }
}
