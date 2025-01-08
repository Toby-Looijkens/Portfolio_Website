using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User> GetUserByID(Guid ID);
        public Task<User> CreateUser(User user);
        public Task<User> UpdateUser(User user);
        public Task<int> DeleteUser(Guid ID);
    }
}
