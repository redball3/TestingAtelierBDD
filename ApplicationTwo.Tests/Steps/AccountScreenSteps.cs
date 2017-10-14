using ApplicationTwo.Tests.UIHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ApplicationTwo.Tests.Steps
{
    [Binding]
    public sealed class AccountScreenSteps
    {
        private readonly AccountScreenHelper _accountScreenHelper = new AccountScreenHelper();

        [Then(@"the useraccount screen is shown")]
        public void ThenTheUseraccountScreenIsShown()
        {
            Assert.IsTrue(_accountScreenHelper.IsAccountScreenShown());
        }

        [Then(@"the useraccount screen is not shown")]
        public void ThenTheUseraccountScreenIsNotShown()
        {
            Assert.IsFalse(_accountScreenHelper.IsAccountScreenShown());
        }

        [Then(@"my username shows as '(.*)'")]
        public void ThenMyUsernameShowsAs(string username)
        {
            Assert.IsTrue(_accountScreenHelper.CheckUserNameMatches(username));
        }

        [Then(@"firt name is '(.*)'")]
        public void ThenFirtNameIs(string name)
        {
            Assert.IsTrue(_accountScreenHelper.CheckFirstNameMatches(name));
        }

        [Then(@"my last name is '(.*)'")]
        public void ThenMyLastNameIs(string name)
        {
            Assert.IsTrue(_accountScreenHelper.CheckLastNameMatches(name));
        }

        [Then(@"Welcome screen is shown")]
        public void ThenWelcomeScreenIsShown()
        {
            Assert.IsTrue(_accountScreenHelper.WelcomeScreenIsShown());
        }

        [When(@"i navigate to the '(.*)' tab")]
        public void WhenINavigateToTheTab(string tabName)
        {
            _accountScreenHelper.NavigateToTab(tabName);
        }
    }
}
