using System.Threading;
using ApplicationTwo.Tests.UIHelpers;
using TechTalk.SpecFlow;

namespace ApplicationTwo.Tests.Steps
{
    [Binding]
    public sealed class ScenarioSteps
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ApplicationInitializer.InitializeApplication();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ApplicationInitializer.TeardownApplication();
            Thread.Sleep(500);
            //sometimes boots up the next application before the previous one is fully closed
        }
    }
}
