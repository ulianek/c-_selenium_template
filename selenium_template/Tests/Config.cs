using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_template
{
    [SetUpFixture]
    public abstract class Config
    {
        public IWebDriver Driver { get; set; }
        protected ExtentReports _extent;
        protected ExtentTest _test;

        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            var dir = TestContext.CurrentContext.TestDirectory + "\\";
            var fileName = this.GetType().ToString() + ".html";
            var htmlReporter = new ExtentHtmlReporter(dir + fileName);

            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            _extent.Flush();
        }

        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            //_test.Fail("details", MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
            if (logstatus != Status.Pass)
            {
                string path = MakeScreenshot(TestContext.CurrentContext.Test.Name + ".png");
                _test.Log(logstatus, "Test ended with " + logstatus + stacktrace, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
            }
            else
            {
                _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            }
            _extent.Flush();
            Driver.Close();
        }

        public string MakeScreenshot(string fileName)
        {
            var dir = TestContext.CurrentContext.TestDirectory + "\\";
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            ss.SaveAsFile(dir + fileName,
            ScreenshotImageFormat.Png);

            return dir + fileName;
        }
    }

}
