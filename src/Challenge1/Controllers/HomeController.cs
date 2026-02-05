using Challenge1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Challenge1.ViewModels;

namespace Challenge1.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
	private readonly ILogger<HomeController> _logger = logger;

	public ViewResult Index()
	{
		var homeModel = new HomeModel() { };
		return View(homeModel);
	}

	public IActionResult Privacy()
	{
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
