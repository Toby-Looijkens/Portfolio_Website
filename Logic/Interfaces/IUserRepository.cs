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
        public Task<IEnumerable<User>> GetUserByID(Guid ID);
        public Task<User> CreateUser(User user);
        public Task<IEnumerable<User>> UpdateUser();
        public Task<IEnumerable<int>> DeleteUser(Guid ID);
    }
}
