using DB_Library;
using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace DB_Library
{
    public class UserRepository : IUserRepository
    {
        DBContext _context = new DBContext();
        public UserRepository() { }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return _context.Users.ToArray();
        }

        public async Task<User> GetUserByID(Guid ID)
        {
            return _context.Users
                .Where(u => u.ID == ID)
                .FirstOrDefault();
        }

        public async Task<User> CreateUser(User user)
        {
            _context.Users
                .Add(user);
            if (_context.SaveChanges() > 0 )
            {
                return user;
            } else
            {
                throw new Exception("User was not able to be created at this moment in time");
            }

        }

        public async Task<User> UpdateUser(User user)
        {
            User result = _context.Users
                .Where(u => u.ID == user.ID)
                .FirstOrDefault();
            if (result != null) { 
                result.Username = user.Username;
                result.Email = user.Email;
                result.RoleID = user.RoleID;
                result.Password = user.Password;
                try {
                    if (_context.SaveChanges() == 1) {
                        return user;
                    } else
                    {
                        throw new Exception("User was not able to be updated at this time");
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            } else {
                throw new Exception("User doesn't exist");
            }
        }

        public async Task<int> DeleteUser(Guid ID)
        {
            var result = _context.Users
                .Where(u => u.ID == ID)
                .FirstOrDefault();
            if (result != null)
            {
                _context.Users.Remove(result);
                try
                {
                    return _context.SaveChanges(); 
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            } else
            {
                throw new Exception("User doesn't exist");  
            }
        }
    }
}
