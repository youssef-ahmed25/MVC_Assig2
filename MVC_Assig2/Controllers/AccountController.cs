using Microsoft.AspNetCore.Mvc;

namespace MVC_Assig2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
