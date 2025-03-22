using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP_WEB.Models;

namespace ASP_WEB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var products = ProductRepository.GetProducts(); 
        return View(products);
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
    
    public IActionResult Detail(int id)
    {
        var product = ProductRepository.GetProductById(id); 
        if (product == null)
        {
            return NotFound("Sản phẩm không tồn tại.");
        }
        return View(product);
    }


}