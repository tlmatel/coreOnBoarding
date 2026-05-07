using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class SalesController : Controller
{
    public IActionResult ElevatorPitch() => View();
    public IActionResult Arguments() => View();
    public IActionResult Objections() => View();
    public IActionResult Competitors() => View();
    public IActionResult SuccessStories() => View();
}
