using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_template.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_template
{
    [TestFixture()]
    class LoginTests : Config
    {
  
        [Test()]
        public void ReservePage()
        {
           driver.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual(1, 2);
        }

        [Test()]
        public void ReservePage1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test()]
        public void ReservePage2()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test()]
        public void ReservePage3()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
    }
}
