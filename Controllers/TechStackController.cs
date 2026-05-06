using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class TechStackController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Development() => View();
    public IActionResult Packaging() => View();
    public IActionResult Deployment() => View();
    public IActionResult Operations() => View();
    public IActionResult Technologies() => View();
}
