using ApplicationTwo.Tests.UIHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ApplicationTwo.Tests.Steps
{
    [Binding]
    public sealed class ShowCatsSteps
    {
        private readonly AccountScreenHelper _accountScreenHelper = new AccountScreenHelper();

        [Then(@"i can look at some cats")]
        public void ThenICanLookAtSomeCats()
        {
            Assert.IsTrue(_accountScreenHelper.ShowCatsButtonIsEnabled());
        }
    }
}
