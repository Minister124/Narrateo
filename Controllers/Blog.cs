using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Narrateo.Controllers;

public class Blog : Controller
{
    private readonly ILogger<Blog> _logger;

    public Blog(ILogger<Blog> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
