using Microsoft.AspNetCore.Mvc;

namespace Panda.Controllers.Users
{
    public class UsersController : BaseController
    {
        [HttpGet("Users/Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}