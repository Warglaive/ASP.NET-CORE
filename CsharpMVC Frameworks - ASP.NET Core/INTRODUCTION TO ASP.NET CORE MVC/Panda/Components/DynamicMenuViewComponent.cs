using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Panda.Components
{
    [ViewComponent(Name = "menu")]
    public class DynamicMenuViewComponent : ViewComponent
    {
        public DynamicMenuViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new List<MenuItemViewModel>
            {
                new MenuItemViewModel
                {
                    Url = "https://google.com/",
                    Title = "Google"
                },
                new MenuItemViewModel
                {
                    Url = "https://facebook.com/",
                    Title = "Facebook"
                }
            };
            //Shared/Components/menu/
            return this.View(viewModel);
        }
    }

    public class MenuItemViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}