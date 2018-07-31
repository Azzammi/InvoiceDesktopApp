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
        public string slsmCode { get; set; }
        public string outlRoute { get; set; }        
        public bool outlStat { get; set; }       
        public bool isppn { get; set; }
        public int outlDisc { get; set; }
    }
}
