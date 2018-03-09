using AvivaTest.Base;
using AvivaTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AvivaTest.StepDefinations
{
    [Binding]
    public class AvivaSearchSteps:BaseClass
    {

        AvivaSearchPage AP = new AvivaSearchPage(BaseClass.Driver);

        [Given(@"I have lauchned the google home page")]
        public void GivenIHaveLauchnedTheGoogleHomePage()
        {
            BaseClass.GoToUrl("https://www.google.com");
        }

        [Given(@"I have entered the search text ""(.*)""")]
        public void GivenIHaveEnteredTheSearchText(string searchText)
        {
            AP.EnterSearchKeyWord(searchText);
        }

        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            AP.clickOnSearchButton();
        }

        [Then(@"I should be able to see the links related to the search text")]
        public void ThenIShouldBeAbleToSeeTheLinksRelatedToTheSearchText()
        {
            Console.Write("print al links");
        }

    }
}
