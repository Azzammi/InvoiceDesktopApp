using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class Outlet
    {           
        public string outlCode { get; set; }
        public string outlName { get; set; }
        public string outlAddress { get; set; }
        public string outlSlsm { get; set; }
        public string outlRoute { get; set; }
        public bool outlStatus { get; set; }        
    }
}
