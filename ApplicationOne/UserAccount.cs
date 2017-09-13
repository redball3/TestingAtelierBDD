using System;

namespace ApplicationOne
{
    public class UserAccount
    {
        public string Username;
        public string Password; //lazyyyyy

        public string Address;
        public DateTime DateOfBirth;
        public string FirstName;
        public string Surname;
        public string QualifiedFullName => $"{FirstName} {Surname}";
    }
}