using Microsoft.AspNetCore.Mvc;

namespace WebProgramming.Controllers
{
    public class LoginRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
