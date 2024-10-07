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
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository = new UserRepository();
        [HttpPost(nameof(CreateUser))]
        public async Task<IActionResult> CreateUser(User user)
        {
            UserManager userManager = new UserManager(userRepository);
            User _user = await userManager.CreateUser(user);

            return Ok(_user);
        }
    }
}
