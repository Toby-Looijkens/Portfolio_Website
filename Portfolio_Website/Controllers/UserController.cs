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
        private readonly IUserRepository userRepository;
        private readonly UserManager userManager;

        public UserController() { 
            userRepository = new UserRepository();
            userManager = new UserManager(userRepository);
        }

        [HttpGet(nameof(GetAllUsers))]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(userManager.GetAllUsers());
        }

        [HttpGet(nameof(GetUserByID))]
        public async Task<IActionResult> GetUserByID(Guid ID)
        {
            return Ok(userManager.GetUserByID(ID));
        }

        [HttpPost(nameof(CreateUser))]
        public async Task<IActionResult> CreateUser(User user)
        {
            User _user = await userManager.CreateUser(user);

            return Ok(_user);
        }

        [HttpPost(nameof(UpdateUser))]
        public async Task<IActionResult> UpdateUser(User user)
        {
            return Ok(userManager.UpdateUser(user));
        }

        [HttpPost(nameof(DeleteUser))]
        public async Task<IActionResult> DeleteUser(Guid ID)
        {
            return Ok(userManager.DeleteUser(ID));
        }
    }
}
