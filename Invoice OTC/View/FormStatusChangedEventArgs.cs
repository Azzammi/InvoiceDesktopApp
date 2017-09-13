using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC.View
{
    public enum FormStatus
    {
        Init,
        OnEditMode,
        Ready,
        NewRecord
    }

    public class FormStatusChangedEventArgs : EventArgs
    {
        #region Declaration
        private FormStatus frmStatus;
        #endregion

        #region Constructor
        public FormStatusChangedEventArgs(FormStatus status)
        {
            FrmStatus = status;
        }
        #endregion

        #region Properties
        public FormStatus FrmStatus
        {
            get { return frmStatus; }
            set { frmStatus = value; }
        }
        #endregion

        public delegate void FormStatusChangedEventHandles(object sender, FormStatusChangedEventArgs e);
    }
}
