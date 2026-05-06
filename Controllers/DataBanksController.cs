using Microsoft.AspNetCore.Mvc;

namespace coreOnBoarding.Controllers;

public class DataBanksController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Edam() => View();
    public IActionResult GoCatalog() => View();
}
