using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

    }
}
