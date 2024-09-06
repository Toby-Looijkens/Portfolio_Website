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
        Task<IEnumerable<User>> GetAllUsers();
        Task<IEnumerable<User>> GetUserByID(Guid ID);
        Task<User> CreateUser(User user);
        Task<IEnumerable<User>> UpdateUser();
        Task<IEnumerable<int>> DeleteUser(Guid ID);
    }
}
