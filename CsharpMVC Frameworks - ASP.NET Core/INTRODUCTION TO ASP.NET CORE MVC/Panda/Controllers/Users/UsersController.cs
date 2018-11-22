using System.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Panda.Models;
using Panda.Services;
using Panda.Services.Contracts;
using Panda.ViewModels;

namespace Panda.Controllers.Users
{
    public class UsersController : HomeController
    {
        public IHashService HashService;
        public SignInManager<User> SignInManager;

        public UsersController(SignInManager<User> signInManager)
        {
            SignInManager = signInManager;
            this.HashService = new HashService();
        }
        [HttpGet("Users/Login")]
        public IActionResult Login(string returnUrl = null)
        {
            var returnUrlParsed = returnUrl ?? Url.Content("~/");
            HttpContext.SignOutAsync(IdentityConstants.ExternalScheme).GetAwaiter().GetResult();
            this.TempData["ReturnUrl"] = returnUrlParsed;
            return View();
        }

        [HttpPost("Users/Login")]
        public IActionResult Login(UserViewModel model)
        {
            var hashedPassword = this.HashService.Hash(model.Password);

            var user = this.SignInManager.UserManager.Users.FirstOrDefault(x =>
                x.UserName == model.Username && x.PasswordHash == hashedPassword);

            if (user != null)
            {
                //var result = this.SignInManager.UserManager.CreateAsync(user, user.Password).Result;
                //if (result.Succeeded)
                //{
                //    return RedirectToAction("Index", "Home");
                //}
            }

            return this.View();
        }

        public void Logout()
        {
            HttpContext.SignOutAsync(IdentityConstants.ExternalScheme).GetAwaiter().GetResult();
            RedirectToAction("Index", "Home");
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
                UserName = model.Username,
                Password = model.Password,
                Email = model.Email,
                PasswordHash = hashedPassword
            };
            var result = this.SignInManager.UserManager.CreateAsync(user, user.Password).Result;
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}