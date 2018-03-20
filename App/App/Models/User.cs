using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        public bool CheckInfo()
        {
            if (!this.UserName.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
