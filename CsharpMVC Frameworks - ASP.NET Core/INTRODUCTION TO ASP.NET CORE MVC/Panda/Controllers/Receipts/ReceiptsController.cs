using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Panda.Controllers.Receipts
{
    [Authorize]
    public class ReceiptsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}