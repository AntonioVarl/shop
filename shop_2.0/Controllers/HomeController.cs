using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using shop_2._0.Models;
using static shop_2._0.Data.ProductsData;

namespace shop_2._0.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    

    public IActionResult Index()
    {
        var model = new IndexModel()
        {
            Products = PRODUCTS_LIST
        };
        return View(model);
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