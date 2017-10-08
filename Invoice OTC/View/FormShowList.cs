using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using System.Windows.Forms;

namespace Invoice_OTC.View
{
    class FormShowList : FSBindingList<FormShowItem>
    {
        #region Methods
        internal Form ShowForm(object form)
        {
            foreach(FormShowItem item in this.Items)
            {
                if(form != item)
                {
                    return (Form)form;
                }
            }
            return null;
        }
        #endregion
    }
}
