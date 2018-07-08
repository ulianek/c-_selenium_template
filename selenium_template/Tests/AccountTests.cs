using NUnit.Framework;
using selenium_template.Data;
using selenium_template.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_template.Tests
{
    [TestFixture]
    class AccountTests : Config
    {
        [Test]
        public void VisiteProfile()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Navigate();
            var accountPage = loginPage.Login(Users.RealUser.Email, Users.RealUser.Password);
            accountPage.GoToProfile();
            Assert.IsTrue(accountPage.ProfileHeaderIsVisible(), "Profile info not visible");
        }
    }
}
