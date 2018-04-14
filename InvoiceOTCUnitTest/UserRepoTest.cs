using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
using NUnit.Framework;
using System;

namespace InvoiceOTCUnitTest
{
    [TestFixture]
    class UserRepoTest
    {
        #region Declaration
        private IUserRepository userRepo;
        private EncryptHelper encryptHelper;
        #endregion

        #region Constructor
        [SetUp]
        public void Init()
        {
            userRepo = new UserRepository();
            encryptHelper = new EncryptHelper();
        }
        #endregion

        #region Tests
        [Test]
        public void AddTest()
        {
            var user = new User
            {
                UserID = "80001314",
                Username = "username",
                Password = encryptHelper.HashPassword("rumah"),
                JoinedDate = DateTime.Now,
                AuthLevel = "superuser"
            };

            var result = userRepo.Save(user);
            Assert.IsTrue(result != 0);
        }
        [Test]
        public void EditTest()
        {
            var user = new User
            {
                UserID = "80001314",
                Username = "superuser",
                Password = encryptHelper.HashPassword("rumah"),
                JoinedDate = DateTime.Now,
                AuthLevel = "admin"
            };

            var result = userRepo.Update(user);
            Assert.IsTrue(result != 0);
        }
        [Test]
        public void RemoveTest()
        {
            var user = new User
            {
                UserID = "80001314"
            };

            var result = userRepo.Delete(user);
            Assert.IsTrue(result != 0);
        }
        [Test]
        public void HashPasswordTest()
        {
            var password = encryptHelper.HashPassword("password");
            var inputterdPassword = encryptHelper.HashPassword("password");

            Assert.AreEqual(password, inputterdPassword);
        }
        [Test]
        public void LoginTest()
        {
            var user = userRepo.Login("superuser", encryptHelper.HashPassword("rumah"));

            Assert.IsNotNull(user);
            Assert.AreEqual("80001314", user.UserID);
            Assert.AreEqual("admin", user.AuthLevel);
        }
        [Test]
        public void GetAll()
        {
            var list = userRepo.GetAll();
            Assert.IsNotNull(list);
        }
        [Test]
        public void Find()
        {
            var listSearch = userRepo.Search("Username", "superuser");
            Assert.IsNotNull(listSearch);
        }
        [Test]
        public void Dispose() {

        }
        #endregion
    }
}
