using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class User
    {
        public User(string username, string email, int roleID, string password)
        {
            ID = Guid.NewGuid();
            Username = username;
            Email = email;
            RoleID = roleID;
            Password = password;
        }

        public User(Guid iD, string username, string email, int roleID)
        {
            ID = iD;
            Username = username;
            Email = email;
            RoleID = roleID;
        }

        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public string? Password { get; set; }

    }
}
