using System.Threading;
using ApplicationOne.Tests.UIHelpers;
using TechTalk.SpecFlow;

namespace ApplicationOne.Tests.Steps
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
        }
    }
}
