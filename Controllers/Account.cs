using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [Route("Account/RegisterView")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
