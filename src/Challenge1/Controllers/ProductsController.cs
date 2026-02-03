using Microsoft.AspNetCore.Mvc;

namespace Challenge1.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}