using System;
using System.Windows.Forms;
using ApplicationTwo.Classes;

namespace ApplicationTwo.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var loginHelper = new LoginHelper();
            var login = loginHelper.ValidateLogin(UsernameTextBox.Text, PasswordTextBox.Text);

            if (login != null)
            {
                var accountscreen = new UserAccountScreen(login);
                accountscreen.Show();
            }
        }
    }
}
