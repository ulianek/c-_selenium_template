using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_template.Pages
{
    class BasePage
    {
        public string Url { get; set; }
        public IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void MakeScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C://Image.png",
            ScreenshotImageFormat.Png);
        }
    }
}
