using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOTC.Model
{
    public class User
    {
        #region Properties
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AuthLevel { get; set; }
        public DateTime JoinedDate { get; set; }
        #endregion
    }
}
