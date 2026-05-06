using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
