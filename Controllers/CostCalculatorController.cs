using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class CostCalculatorController : Controller
{
    public IActionResult Index() => View();
}
