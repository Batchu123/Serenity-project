using AvivaTest.Base;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AvivaTest.Hooks
{
    [Binding]
    public class Hooks
    {

        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Initialize()
        {
            BaseClass.OpenBrowser(BrowserType.IE);
        }

        [AfterScenario]
        public void CleanUp()
        {
            BaseClass.Driver.Quit();
        }


        

    }

    
}
