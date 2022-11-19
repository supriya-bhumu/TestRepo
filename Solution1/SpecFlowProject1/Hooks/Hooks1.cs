using MarsQAProfile.Drivers;
using NUnit.Framework.Internal;
using TechTalk.SpecFlow;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQAProfile.Hooks
{
    [Binding]
    public sealed class Hooks1:Driver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
      
        public void Setup()
        {
            //launch the browser
            Initialize();
           
        }


        [AfterScenario]
        public void TearDown()
        {

            Close();


        }
    }
}