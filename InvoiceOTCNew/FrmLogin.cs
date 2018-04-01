using System;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
using log4net;

namespace InvoiceOTCNew
{
    public partial class FrmLogin : Form
    {
        #region Declaration
        private IUserRepository userRepo;
        #endregion

        #region Constructor
        public FrmLogin()
        {
            InitializeComponent();
            userRepo = new UserRepository(Program.log);
        }
        #endregion

        #region Methods
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text)) errorProvider1.SetError(usernameTextBox, "Username Cannot be empty "); 
            if (string.IsNullOrEmpty(passwordTextBox.Text)) errorProvider1.SetError(passwordTextBox, "Password Cannot be empty ");

            User user = userRepo.Login(usernameTextBox.Text, passwordTextBox.Text);

            if (user != null)
            {
                Session.Login(usernameTextBox.Text);
                GlobalContext.Properties["username"] = usernameTextBox.Text;
                this.Close();
            }
        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Session.GetLoginStatus() == false) Application.Exit();
        }
        #endregion
    }
}
