using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IntroMvc.Models;
using Microsoft.Extensions.Configuration;
using IntroMvc.Data;

namespace IntroMvc.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IConfiguration configuration;
        
        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
