using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panda.Data;
using Panda.Models;

namespace Panda.Controllers
{
    public class BaseController : Controller
    {
        public SignInManager<User> SignInManager;
        public ApplicationDbContext Context { get; set; }

        public BaseController()
        {
            this.Context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
        }
    }
}