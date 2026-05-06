using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class FunctionalGuideController : Controller
{
    public IActionResult Index() => View();
}
