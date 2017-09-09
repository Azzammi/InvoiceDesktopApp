using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    class commandGetNumber : Command
    {
        #region Constructor

        public commandGetNumber()
        {

        }

        #endregion

        #region Method

        //public override object Execute(string namaTable, string namaField)
        //{
        //    NumberingList list = new NumberingList(namaTable, namaField);
        //    return list;
        //}

        public override object Execute()
        {
            return null;
        }

        #endregion


    }
}
