using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class ArchitectureController : Controller
{
    public IActionResult Modules() => View();
    public IActionResult ModuleRelations() => View();
    public IActionResult Navigation() => View();
    public IActionResult RolesProfiles() => View();
    public IActionResult MultiCompany() => View();
    public IActionResult Security() => View();
}
