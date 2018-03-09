using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvivaTest.Pages
{
    public class AvivaSearchPage
    {
        private IWebDriver driver;
        public AvivaSearchPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement searchField;

        public void EnterSearchKeyWord(string searchText)
        {
            Thread.Sleep(3000);
            searchField.SendKeys(searchText);
        }

        public void clickOnSearchButton()
        {
            Thread.Sleep(3000);
            searchField.Submit();
        }
    }
}
