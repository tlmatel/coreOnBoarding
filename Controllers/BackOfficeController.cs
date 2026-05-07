using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class BackOfficeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Instances() => View();
    public IActionResult Tenants() => View();
    public IActionResult Users() => View();
    public IActionResult Updates() => View();
}
