using DB_Library;
using Logic.Business;
using Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository = new UserRepository();
        public async Task<IActionResult> Index()
        {
            UserManager userManager = new UserManager(userRepository);
            Logic.Entities.User user = await userManager.CreateUser(new Logic.Entities.User(new Guid(), "f", "f", 1));

            return Ok(user);
        }
    }
}
