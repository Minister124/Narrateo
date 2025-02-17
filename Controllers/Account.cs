using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    [Route("[controller]/[action]")]
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
