using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mvc101.Models;


namespace Mvc101.Controllers;
// name of the controller
// two methods
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] days = {"Mon","Tue"};
        ViewData["days"] = days;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Bogus()
    {
        // ViewData and ViewBag are p much the same thing, interchangeable
        // ViewBag.Date == ViewData["Date"]
        ViewData["Name"] = "Home Page\n\n";
        ViewBag.Date = DateTime.Now;

        // we can pass only one argument to the View class.
        // if we wana pass multiple items, create a class that contains all the data 
        // you want
        string[] days = {"Mon","Tue"};
        return View(days);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
