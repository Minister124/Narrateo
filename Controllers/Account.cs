using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    public class Account : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

    }
}
