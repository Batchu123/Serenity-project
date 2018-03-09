using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivaTest.Base
{
    public class BaseClass
    {
        private static IWebDriver driver;

        public static IWebDriver Driver { get => driver; set => driver = value; }

        public static void OpenBrowser(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.IE:
                    driver = new InternetExplorerDriver();
                    break;
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                case BrowserType.FF:
                    driver = new FirefoxDriver();
                    break;
                default:
                    break;
            }
        }

        public static void GoToUrl(String url)
        {
            driver.Url = url;
        }
    }
    public enum BrowserType
    {
        IE,
        Chrome,
        FF
    }
}
