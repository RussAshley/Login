using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
    public class UserDetails
    {
        private String name;
        private String userName;
        private int age;
        private String password;
        private String Address;
        private int colourScheme;

        public UserDetails(string name, string userName, int age, string password, string address, int colourScheme)
        {
            this.Name = name;
            this.UserName = userName;
            this.Age = age;
            this.Password = password;
            this.Address = address;
            this.ColourScheme = colourScheme;
        }

        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public int Age { get => age; set => age = value; }
        public string Password { get => password; set => password = value; }
        public string Address1 { get => Address; set => Address = value; }
        public int ColourScheme { get => colourScheme; set => colourScheme = value; }
    }
}
