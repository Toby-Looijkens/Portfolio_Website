using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Business
{
    public class UserManager
    {
        private readonly IUserRepository userDB;
        public UserManager(IUserRepository userRepository)
        {
            userDB = userRepository;
        }

        public string Login(string username, string password)
        {
            return string.Empty;
        }

        public void Logout()
        {

        }

        public User[] GetAllUsers()
        {
            return null;
        }

        public async Task<User> CreateUser(User user)
        {
            return await userDB.CreateUser(user);
        }

    }
}
