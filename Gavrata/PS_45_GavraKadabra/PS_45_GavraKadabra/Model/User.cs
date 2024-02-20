using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class User
    {   
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRolesEnum Role  { get; set; }

    public User(string name, string password, UserRolesEnum role)
    {
        Name = name;
        Password = password;
        Role = role;
    }
}
