namespace ApplicationOne
{
    internal class LoginHelper
    {
        private UserAccount testAccount = new UserAccount
        {
            Username = "JohnSmith",
            Password = "Test",

            Address = "1 One Way, Leeds",
            DateOfBirth = System.DateTime.Now,
            FirstName = "John",
            Surname = "Smith",
        };

        public UserAccount ValidateLogin(string username, string password)
        {
            if (username == testAccount.Username
                && password == testAccount.Password)
                return testAccount;
            else
                return null;
        }
    }
}
