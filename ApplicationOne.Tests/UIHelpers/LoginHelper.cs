using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace ApplicationOne.Tests.UIHelpers
{
    internal class LoginHelper
    {
        private readonly Window _loginWindow;
        public LoginHelper()
        {
            var app1 = ApplicationInitializer.GetApplication();
            _loginWindow = app1.GetWindow("Login", InitializeOption.NoCache);
        }

        public void EnterUserName(string userName)
        {
            _loginWindow.Get<TextBox>("UsernameTextBox").Text = userName;
        }

        public void EnterPassword(string password)
        {
            _loginWindow.Get<TextBox>("PasswordTextBox").Text = password;
        }

        public void ClickLogin()
        {
            _loginWindow.Get<Button>("LoginButton").Click();
        }
    }
}
