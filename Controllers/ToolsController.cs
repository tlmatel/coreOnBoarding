using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class ToolsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
