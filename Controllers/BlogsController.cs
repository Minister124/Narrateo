using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    public class BlogsController : Controller
    {
        public ActionResult Index()
        {
            return View("Blogs");
        }

    }
}
