using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class ToolsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
