using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

[Authorize]
public class DataBanksController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Edam() => View();
    public IActionResult GoCatalog() => View();
}
