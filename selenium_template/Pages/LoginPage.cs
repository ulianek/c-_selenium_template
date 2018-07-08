using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_template.Pages
{
    class LoginPage: BasePage
    {
        private IWebElement EmailInput
        {
            get
            {
                return driver.FindElement(By.Id("username"));
            }
        }

        private IWebElement PasswordInput
        {
            get
            {
                return driver.FindElement(By.Id("pwd"));
            }
        }

        private IWebElement LoginBtn
        {
            get
            {
                return driver.FindElement(By.XPath("//button[@ng-click='pwdCtrl.auth()']"));
            }
        }

        public LoginPage(IWebDriver driver): base(driver)
        {
        }

        public void Login(string email, string password)
        {
            EmailInput.SendKeys(email);
            PasswordInput.SendKeys(password);
            LoginBtn.Click();
        }
    }
}
