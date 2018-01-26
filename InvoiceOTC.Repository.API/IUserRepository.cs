using System;
using InvoiceOTC.Model;

namespace InvoiceOTC.Repository.API
{
    public interface IUserRepository : IBaseRepository<User>
    {
        #region Properties
        User Login(string username, string password);       
        void Logout();
        #endregion
    }
}
