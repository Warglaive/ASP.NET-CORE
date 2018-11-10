using IntroMvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroMvc.Controllers
{
    public class BaseController : Controller
    {
        public ApplicationDbContext Context { get; set; }

        public BaseController()
        {
            this.Context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
        }

        public BaseController(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}