using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSCollections;

namespace Invoice_OTC.View
{
    class FormShowItem : FSBindingItem
    {
        #region Declaration
        private Form m_form;
        #endregion

        #region Properties
        public Form m_Form
        {
            get { return m_form; }
            set { m_form = value; }
        }
        #endregion
    }
}
