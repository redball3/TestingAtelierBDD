using System;
using System.Windows.Forms;
using ApplicationTwo.Classes;

namespace ApplicationTwo.Forms
{
    public partial class UserAccountScreen : Form
    {
        private UserAccount _account;
        public UserAccountScreen(UserAccount account)
        {
            _account = account;
            InitializeComponent();
        }

        private void UserAccountScreen_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = _account.QualifiedFullName;
            UsernameTextBox.Text = _account.Username;
            PasswordTextBox.Text = _account.Password;
            FirstNameTextBox.Text = _account.FirstName;
            SurnameTextBox.Text = _account.Surname;
            AddressTextBox.Text = _account.Address;
            DobTextBox.Text = _account.DateOfBirth.ToString();
        }
    }
}
