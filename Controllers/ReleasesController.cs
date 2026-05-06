using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class ReleasesController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Environments() => View();
    public IActionResult VersionFlow() => View();
    public IActionResult Hotfix() => View();
}
