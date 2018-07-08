using OpenQA.Selenium.Chrome;
using selenium_template.Pages;
using System;

namespace selenium_template
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://auto-cv.bitcraft.com.pl/haslo");
            var login_page = new LoginPage(driver);
            login_page.Login("k.ulianowski", "Krower95");
            driver.Close();
            driver.Quit();
        }
    }
}
