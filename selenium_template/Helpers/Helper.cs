using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_template.Helpers
{
    public partial class Helper
    {
        public IWebDriver Driver { get; set; }

        public Helper(IWebDriver driver)
        {
            Driver = driver;
            jsExecutor = Driver as IJavaScriptExecutor;

        }
    }
}
