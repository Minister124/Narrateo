using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers
{
    public class PostBlogs : Controller
    {
        // GET: PostBlogs
        public ActionResult Index()
        {
            return View("/Views/Home/BlogLists.cshtml");
        }

    }
}
