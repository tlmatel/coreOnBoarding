using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class ProductOverviewController : Controller
{
    public IActionResult Platform() => View();
    public IActionResult TargetAudience() => View();
    public IActionResult ValueProposition() => View();
    public IActionResult KeyConcepts() => View();
}
