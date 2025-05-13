using Microsoft.AspNetCore.Mvc;

namespace banhang.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //update sau
        }
    }
}
