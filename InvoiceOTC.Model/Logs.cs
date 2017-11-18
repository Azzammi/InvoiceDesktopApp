using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace InvoiceOTC.Model
{
    [Serializable]
    public class Logs 
    {
        public int LogID { get; set; }
        public string Level { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string Message { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
        public string Exception { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LogDate { get; set; }
    }
}
