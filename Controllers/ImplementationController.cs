using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class ImplementationController : Controller
{
    public IActionResult Methodology() => View();
    public IActionResult InitialSetup() => View();
    public IActionResult DataMigration() => View();
}
