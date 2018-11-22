using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panda.Data;

namespace Panda.Controllers
{
    public class BaseController : Controller
    {
        public ApplicationDbContext Context { get; set; }

        public BaseController()
        {
            this.Context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
        }
    }
}