using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class FunctionalGuideController : Controller
{
    public IActionResult Index() => View();
}
