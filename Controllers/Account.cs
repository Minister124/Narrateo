using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    [Route("[controller]/[action]")]
    public class Account : Controller
    {
        public IActionResult LoginView()
        {
            return View();
        }

        public IActionResult RegisterView()
        {
            return View();
        }
    }
}
