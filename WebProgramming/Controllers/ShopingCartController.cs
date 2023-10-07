using Microsoft.AspNetCore.Mvc;

namespace WebProgramming.Controllers
{
    public class ShopingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
