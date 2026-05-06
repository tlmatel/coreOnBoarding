using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class SupportController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Traceability() => View();
    public IActionResult Grafana() => View();
    public IActionResult TenantMonitoring() => View();
    public IActionResult UserActivity() => View();
    public IActionResult Diagnostics() => View();
}
