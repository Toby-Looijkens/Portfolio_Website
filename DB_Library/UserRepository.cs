using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    public class UserRepository : IUserRepository
    {
        public UserRepository() { }
        public Task<IEnumerable<User>> GetAllUsers()
        {
            return null;
        }
        public Task<IEnumerable<User>> GetUserByID(Guid ID)
        {
            return null;
        }
        public Task<User> CreateUser(User user)
        {
            return null;
        }
        public Task<IEnumerable<User>> UpdateUser()
        {
            return null;
        }
        public Task<IEnumerable<int>> DeleteUser(Guid ID)
        {
            return null;
        }
    }
}
