using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_template.Data;
using selenium_template.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_template
{
    [TestFixture]
    class LoginTests : Config
    {
  
        [Test]
        public void SuccessfulLogin()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Navigate();
            loginPage.Login(Users.RealUser.Email, Users.RealUser.Password);
            Assert.IsTrue(new AccountPage(Driver).GreetingHeaderIsVisible());
        }

        [Test]
        public void FailureLogin()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Navigate();
            loginPage.Login(Users.FakeUser.Email, Users.FakeUser.Password);
            Assert.IsTrue(loginPage.LoginFailedMsgIsVisible());
        }



    }
}
