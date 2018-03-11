using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeWorkshop.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string name, string pass, Role role)
        {
            Name = name;
            Password = pass;
            Role = role;
        }
    }

    public enum Role
    {
        Director,
        Designer,
        Unknown
    }
}
