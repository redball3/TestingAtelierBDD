using System.Linq;
using TestStack.White.UIItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.WindowItems;

namespace ApplicationTwo.Tests.UIHelpers
{
    internal class AccountScreenHelper
    {
        private Window _accountScreenwindow;

        public AccountScreenHelper()
        {
            if (IsAccountScreenShown())
                CaptureUserAccountWindow();
        }

        private void CaptureUserAccountWindow()
        {
            var app = ApplicationInitializer.GetApplication();
            _accountScreenwindow = app.GetWindow("UserAccountScreen");
        }

        public bool IsAccountScreenShown()
        {
            return ApplicationInitializer.GetApplication().GetWindows().Any(w => w.NameMatches("UserAccountScreen"));
        }

        public bool CheckUserNameMatches(string username)
        {
            return _accountScreenwindow.Get<TextBox>("UsernameTextBox").Text == username;
        }

        internal bool CheckFirstNameMatches(string name)
        {
            return _accountScreenwindow.Get<TextBox>("FirstNameTextBox").Text == name;
        }

        public bool CheckLastNameMatches(string name)
        {
            return _accountScreenwindow.Get<TextBox>("SurnameTextBox").Text == name;
        }

        public bool WelcomeScreenIsShown()
        {
            return _accountScreenwindow.Get<Tab>("UserAccountTabs").SelectedTab.Name == "Welcome";
        }

        public void NavigateToTab(string tab)
        {
            _accountScreenwindow.Get<Tab>("UserAccountTabs").SelectTabPage(tab);
        }

        public bool ShowCatsButtonIsEnabled()
        {
            return _accountScreenwindow.Get<Button>("CatButton").Enabled;
        }
    }
}
