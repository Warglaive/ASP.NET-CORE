using System;
using System.Linq;
using IntroMvc.Models;
using IntroMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IntroMvc.Controllers.CatControllers
{
    public class CatController : BaseController
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/cat/add")]
        public IActionResult AddCat(CatViewModel model)
        {
            var cat = new Cat
            {
                Name = model.Name,
                Age = model.Age,
                Breed = model.Breed,
                ImageUrl = model.ImageUrl

            };

            this.Context.Cats.Add(cat);

            this.Context.SaveChanges();
            return RedirectToAction();
        }

        [HttpGet("/show/{name}")]
        public IActionResult Show(string name)
        {
            //get by username
            var cat = this.Context.Cats.FirstOrDefault(x => x.Name == name);
            if (cat != null)
            {
                return this.View(cat);
            }
            throw new NullReferenceException();
        }
    }
}