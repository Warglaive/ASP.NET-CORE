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
            //maybe context is null
            var user = this.SignInManager.UserManager.Users.FirstOrDefault(x =>
                x.UserName == model.Username && x.CustomPasswordHash == hashedPassword);

            if (user != null)
            {
                this.SignInManager.SignInAsync(user, model.RememberMe).Wait();
                return RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        public IActionResult Logout()
        {
            SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
                CustomPasswordHash = hashedPassword
            };
            var result = this.SignInManager.UserManager.CreateAsync(user, user.Password).Result;
            if (this.SignInManager.UserManager.Users.Count() == 1)
            {
                var roleResult = this.SignInManager.UserManager.AddToRolesAsync(user, new[] { "Admin" }).Result;
                if (roleResult.Errors.Any())
                {
                    return this.View();
                }
            }
            if (result.Succeeded)
            {
                this.SignInManager.SignInAsync(user, false).Wait();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}