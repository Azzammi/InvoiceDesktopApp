using Invoice_OTC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC.Controller
{
    class CommandUpdateItem : Command
    {
        #region Declarations

        //Member Variables
        rotiItem m_rotiToUpdate;

        #endregion
        #region Constructor

        public CommandUpdateItem(rotiItem rotiToUpdate)
        {
            m_rotiToUpdate = rotiToUpdate;
        }

        #endregion

        #region Methods

        public override object Execute()
        {
            m_rotiToUpdate.UpdateDatabaseRecord();
            return m_rotiToUpdate;
        }        

        #endregion
    }
}
