using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_template.Pages
{
    class AccountPage : BasePage
    {
        public AccountPage(IWebDriver driver) : base(driver)
        {
            Url = base.Url + "account";
        }

        private IWebElement GreetingHeader => WaitAndGetElement(By.XPath("//h3[text()='Hi, Johny Smith']"));
        private IWebElement ProfileBtn => WaitAndGetElement(By.CssSelector("a[href='#profile']"));
        private IWebElement ProfileHeader => WaitAndGetElement(By.XPath("//h3[text()='Personal Details']"));

        public bool GreetingHeaderIsVisible()
        {
            return GreetingHeader != null;
        }

        public void GoToProfile()
        {
            ProfileBtn.Click();
        }

        public bool ProfileHeaderIsVisible()
        {
            return ProfileHeader != null;
        }
    }
}
