using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_OTC.Model;

namespace Invoice_OTC.Controller
{
    public class CommandAddItem : Command
    {
        #region Declarations

        int m_ParentIDs;

        #endregion
        #region Constructor

        public CommandAddItem(int m_ParentID)
        {
            this.m_ParentIDs = m_ParentID;
        }

        #endregion

        #region Methods

        public override object Execute()
        {
            /* Note that we will only create the book here and return it to the Projects
           * work panel. That's because the Books BindingSource object adds the
           * book to it's project. The BindingSource object  expects its e.NewObject 
           * event arg to be set to the new object. Since the BookList is a bound 
           * object, we will let the BindingSource object manage the addition. */

            // Create book
            //Creates a new Item Invoice
            rotiItem item = new rotiItem(m_ParentIDs);
            return item;
        }

        #endregion
    }
}
