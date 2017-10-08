using System;
using System.Drawing;
using System.IO;
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
            WelcomeLabel.Text = $@"welcome,{Environment.NewLine}{_account.Username}";
            UsernameTextBox.Text = _account.Username;
            PasswordTextBox.Text = _account.Password;
            FirstNameTextBox.Text = _account.FirstName;
            SurnameTextBox.Text = _account.Surname;
            AddressTextBox.Text = _account.Address;
            DobTextBox.Text = _account.DateOfBirth.ToString();
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var filePath = Path.GetFullPath($@"{Directory.GetCurrentDirectory()}../../../CatPictures/Cat{rnd.Next(1, 7)}.jpg");
            CatPictureBox.Image = Image.FromFile(filePath);
        }
    }
}
