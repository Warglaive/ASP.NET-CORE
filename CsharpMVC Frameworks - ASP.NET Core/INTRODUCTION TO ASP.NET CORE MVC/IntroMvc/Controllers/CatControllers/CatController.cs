using IntroMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMvc.Controllers.CatControllers
{
    public class CatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ////add cat to db
            //var cat = new Cat
            //{
            //    Name = this.ViewData["name"].ToString()
            //};
            return View();
        }
    }
}