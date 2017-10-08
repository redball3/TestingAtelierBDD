using System.Collections.Generic;
using System.IO;
using System.Linq;
using ApplicationTwo.Properties;
using Newtonsoft.Json;

namespace ApplicationTwo.Classes
{
    internal class AccountHelper
    {
        private readonly List<UserAccount> _testAccounts;

        public AccountHelper()
        {
            using (var sr = new StreamReader(Path.GetFullPath(Settings.Default.UserFile)))
            {
                _testAccounts = JsonConvert.DeserializeObject<List<UserAccount>>(sr.ReadToEnd());
            }
        }
        public UserAccount ValidateLogin(string username, string password)
        {
            return _testAccounts.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}