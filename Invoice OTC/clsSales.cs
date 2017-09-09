using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC
{
    class clsSales
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string FullName
        {
            get
            {
                return FirstName + "|" + LastName;
            }
        }

        public clsSales(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
