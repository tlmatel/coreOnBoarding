using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class SalesController : Controller
{
    public IActionResult ElevatorPitch() => View();
    public IActionResult Arguments() => View();
    public IActionResult Objections() => View();
    public IActionResult Competitors() => View();
    public IActionResult SuccessStories() => View();
}
