using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class CloudProviderController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Infrastructure() => View();
    public IActionResult Kubernetes() => View();
    public IActionResult Reliability() => View();
    public IActionResult Backups() => View();
    public IActionResult Security() => View();
}
