using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium_template.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_template.Pages
{
    public class BasePage : Helper
    {
        public string Url { get; set; }
        public WebDriverWait Waiter { get; set; }

        public BasePage(IWebDriver driver) : base(driver)
        {
            Url = "https://www.phptravels.net/";
            Waiter = new WebDriverWait(Driver, new TimeSpan(0, 0, 5));
        }

        public IWebElement WaitAndGetElement(By locator)
        {
            try
            {
                var element = Waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
                return element;
            }
            catch (WebDriverTimeoutException)
            {
                return null;
            }
        }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl(Url);
        }

    }

}