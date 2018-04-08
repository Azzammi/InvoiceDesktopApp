using System;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;

namespace InvoiceOTCNew
{
    public partial class FrmUser : TemplateEntryFrm
    {
        #region Declaration
        private IUserRepository userRepository = new UserRepository(Program.log);
        private EncryptHelper encryptHelper = new EncryptHelper();
        #endregion

        #region Constructor
        public FrmUser()
        {
            InitializeComponent();
            SetHeader("User Baru");

            CekKondisi(FormCondition.Ready);
        }
        /// <summary>
        /// Constructor for edit / update data
        /// </summary>
        /// <param name="data"></param>
        public FrmUser(User data)
        {
            InitializeComponent();
            SetHeader("Edit User");

            CekKondisi(FormCondition.Inputting);
            userBindingSource.Add(data);

            isAddNew = false;
        }
        #endregion

        #region Overrided Function
        protected override void button1_Click(object sender, EventArgs e)
        {
            userBindingSource.AddNew();
            isAddNew = true;

            CekKondisi(FormCondition.Inputting);
        }
        protected override void button2_Click(object sender, EventArgs e)
        {
            User userToUpdate = (User)userBindingSource.Current;

            userToUpdate.Password = encryptHelper.HashPassword(userToUpdate.Password);
            if (userToUpdate == null) return;

            if(isAddNew && string.IsNullOrEmpty(userToUpdate.Username))
            {
                userRepository.Save(userToUpdate);
                Listener.Ok(this, true, userToUpdate);
            }
            else
            {
                userRepository.Update(userToUpdate);
                Listener.Ok(this, false, userToUpdate);
            }

            CekKondisi(FormCondition.Ready);
        }
        #endregion
    }
}
