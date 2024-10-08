using DB_Library;
using Logic.Business;
using Logic.Entities;
using Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository = new UserRepository();
        [HttpGet(nameof(GetAllUsers))]
        public async Task<IActionResult> GetAllUsers()
        {
            UserManager usersManager = new UserManager(userRepository);
            return Ok(usersManager.GetAllUsers());
        }

        [HttpPost(nameof(CreateUser))]
        public async Task<IActionResult> CreateUser(User user)
        {
            UserManager userManager = new UserManager(userRepository);
            User _user = await userManager.CreateUser(user);

            return Ok(_user);
        }

    }
}
