using System;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;

namespace InvoiceOTCNew
{
    public partial class FrmListOutlet : TemplateListForm, IListener
    {
        #region Declaration
        private IOutletRepository outletRepository;
        #endregion

        #region Constructor
        public FrmListOutlet()
        {
            InitializeComponent();
            SetHeader("outlet");
            outletRepository = new OutletRepository();

            outletBindingSource.DataSource = outletRepository.GetAll();
        }
        #endregion

        #region Overrided Method
        protected override void tambahBtn_Click(object sender, EventArgs e)
        {
            base.tambahBtn_Click(sender, e);
        }
        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            base.EditBtn_Click(sender, e);
        }
        protected override void DeleteBtn_Click(object sender, EventArgs e)
        {
            base.DeleteBtn_Click(sender, e);
        }
        #endregion

        #region IListener Method
        public void Ok(object sender, object data)
        {
            throw new NotImplementedException();
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            if (isNewData)
            {
                outletBindingSource.Add(data);
            }
        }
        #endregion
    }
}
