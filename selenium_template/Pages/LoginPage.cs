using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_template.Pages
{
    class LoginPage: BasePage
    {

        public LoginPage(IWebDriver driver): base(driver)
        {
            Url = base.Url + "login";
        }

        private IWebElement LoginFailesMsg => WaitAndGetElement(By.XPath("//div[@class='alert alert-danger']"));
        private IWebElement EmailInput => WaitAndGetElement(By.Name("username"));
        private IWebElement PasswordInput => WaitAndGetElement(By.Name("password"));
        private IWebElement LoginBtn => WaitAndGetElement(By.XPath("//button[@class='btn btn-action btn-lg btn-block loginbtn']"));

        public AccountPage Login(string email, string password)
        {
            EmailInput.SendKeys(email);
            PasswordInput.SendKeys(password);
            LoginBtn.Click();
            return new AccountPage(Driver);
        }

        public bool LoginFailedMsgIsVisible()
        {
            return LoginFailesMsg != null;
        }
    }
}
