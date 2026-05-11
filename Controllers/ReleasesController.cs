using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class ReleasesController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Environments() => View();
    public IActionResult VersionManagement() => View();
    public IActionResult UpdateProcess() => View();
}
