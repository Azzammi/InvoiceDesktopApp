using System;
using System.Windows.Forms;
using InvoiceOTCNew.Helper;

namespace InvoiceOTCNew
{
    public partial class TemplateEntryFrm : Form
    {
        #region Declaration       
        protected BindingSource bindingSource;
        protected bool isAddNew;
        protected FormCondition _condition;

        public IListener Listener { get; set; }
        #endregion

        #region Enum
        public enum FormCondition
        {
            Ready = 0,
            Inputting = 1,
        }
        #endregion

        #region Constructor
        public TemplateEntryFrm()
        {
            InitializeComponent();            
        }
        #endregion

        #region Protected and Override Method
        /// <summary>
        /// Setting header text
        /// </summary>
        /// <param name="header"></param>
        protected void SetHeader(string header)
        {
            this.Text = header;
            this.lblHeader.Text = header.ToUpper();
            this.Text = header.ToUpperInvariant();
        }

        /// <summary>
        /// To check if form is ready to input new data or not
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        protected FormCondition CekKondisi(FormCondition condition)
        {
            switch (condition)
            {
                case FormCondition.Ready:

                    InputControlHelper.DisableInput(this);
                    button1.Enabled = true;
                    button2.Enabled = false;

                    break;
                case FormCondition.Inputting:

                    InputControlHelper.EnableInput(this);
                    button1.Enabled = false;
                    button2.Enabled = true;

                    break;
                default:
                    break;
            }

            //Method to setup the control
            InputControlHelper.SetUpControls(this);
            _condition = condition;
            return condition;
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {

        }

        protected virtual void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Supplementary Function
        /// <summary>
        /// Prevent window from closing before the data inputted is saved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemplateEntryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_condition == FormCondition.Inputting)
            {
                if(DialogHelper.ExitDialog(this) != 0)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }                
            }
        }       
        #endregion    
    }
}
