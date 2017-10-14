using ApplicationTwo.Tests.UIHelpers;
using TechTalk.SpecFlow;

namespace ApplicationTwo.Tests.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private LoginHelper _loginHelper = new LoginHelper();

        [Given(@"i am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            //Intentionaly blank, we start on the login page.
            //If the winodw doesn't open, the test will fail before we even get here.
        }

        [When(@"i enter username '(.*)'")]
        public void WhenIEnterUsername(string userName)
        {
            _loginHelper.EnterUserName(userName);
        }

        [When(@"i enter password '(.*)'")]
        public void WhenIEnterPassword(string password)
        {
            _loginHelper.EnterPassword(password);
        }

        [When(@"i click login")]
        public void WhenIClickLogin()
        {
            _loginHelper.ClickLogin();
        }
    }
}
