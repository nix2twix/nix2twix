using System.IO;
using Newtonsoft.Json;

namespace LoginForm
{
    internal class UserData
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public UserData(string login, string password)
        {
            Login = login;
            Password = password;
        }   
    }
}
