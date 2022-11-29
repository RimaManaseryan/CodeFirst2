using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username
        {
            get { return Username; }
            set { if (Username.Length > 6) Username = value; }
        }
        public string Password
        {
            get { return Password; }
            set
            {
                if (Password.Length >= 6 && Password.IsIn('&', '.', ',', '@') && Password.IsIn(Username))
                    Password = value;
                else Console.WriteLine("Your password must contain at least 6 characters and one of '&', '.', ',', '@' symbols");
            }
        }

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
