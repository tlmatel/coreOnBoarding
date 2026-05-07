using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class AIController : Controller
{
    public IActionResult Index() => View();
    public IActionResult MassiveChanges() => View();
    public IActionResult Widgets() => View();
    public IActionResult Reports() => View();
    public IActionResult Filters() => View();
    public IActionResult Mcp() => View();
}
