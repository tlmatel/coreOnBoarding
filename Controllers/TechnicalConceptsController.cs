using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class TechnicalConceptsController : Controller
{
    public IActionResult Saas() => View();
    public IActionResult HighLevel() => View();
    public IActionResult Security() => View();
    public IActionResult Integrations() => View();
    public IActionResult Performance() => View();
}
