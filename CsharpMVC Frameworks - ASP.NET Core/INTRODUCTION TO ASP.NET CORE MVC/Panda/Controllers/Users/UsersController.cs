using Microsoft.AspNetCore.Mvc;
using Panda.Models;
using Panda.Services;
using Panda.Services.Contracts;
using Panda.ViewModels;

namespace Panda.Controllers.Users
{
    public class UsersController : BaseController
    {
        public IHashService HashService;

        public UsersController()
        {
            this.HashService = new HashService();
        }
        [HttpGet("Users/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("Users/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Users/Register")]
        public IActionResult Register(UserViewModel model)
        {
            var hashedPassword = this.HashService.Hash(model.Password);
            var user = new User
            {
                Username = model.Username,
                Password = hashedPassword,
                Email = model.Email
            };
            this.Context.Users.Add(user);
            this.Context.SaveChanges();
            return View();
        }
    }
}