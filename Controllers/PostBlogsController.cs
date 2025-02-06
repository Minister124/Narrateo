using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    public class PostBlogsController : Controller
    {
        public ActionResult Index()
        {
            return View("BlogLists");
        }

    }
}
