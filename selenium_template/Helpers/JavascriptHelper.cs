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
        protected IJavaScriptExecutor jsExecutor;
        public void ScrollToElement(IWebElement element)
        {
            var js = String.Format("arguments[0].scrollTop = arguments[0].scrollHeight;");
            jsExecutor.ExecuteScript(js, element);
        }

        public void ScrollToHeight(string height)
        {
            var js = String.Format("window.scrollTo(0, " + height + ");");
            jsExecutor.ExecuteScript(js);
        }
    }
}
