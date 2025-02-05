using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
