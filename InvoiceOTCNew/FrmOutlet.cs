using System;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

namespace InvoiceOTCNew
{
    public partial class FrmOutlet : templateEntryFrm
    {
        #region Declaration
        private IOutletRepository outletRepository;
        #endregion

        #region Constructor
        public FrmOutlet()
        {
            InitializeComponent();
            SetHeader("outlet");

            outletRepository = new OutletRepository();
            CekKondisi(FormCondition.Ready);
        }
        /// <summary>
        /// Passing data for edit
        /// </summary>
        /// <param name="data"></param>
        public FrmOutlet(object data)
        {
            InitializeComponent();
            SetHeader("outlet");

            outletRepository = new OutletRepository();
            CekKondisi(FormCondition.Inputting);

            outletBindingSource.Add(data);
            isAddNew = false;
        }
        #endregion

        #region Overrided Method
        protected override void button1_Click(object sender, EventArgs e)
        {
            outletBindingSource.AddNew();
            isAddNew = true;

            CekKondisi(FormCondition.Inputting);
            outlCodeTextBox.Focus();
        }
        protected override void button2_Click(object sender, EventArgs e)
        {
            Outlet outlet = (Outlet)outletBindingSource.Current;
            if (outlet == null) return;

            if (isAddNew && outlet.outlCode != null)
            {
                outletRepository.Save(outlet);
                Listener.Ok(this, true, outlet);
            }
            else
            {
                outletRepository.Update(outlet);
                Listener.Ok(this, false, outlet);
            }

            CekKondisi(FormCondition.Ready);
        }
        #endregion
    }
}
