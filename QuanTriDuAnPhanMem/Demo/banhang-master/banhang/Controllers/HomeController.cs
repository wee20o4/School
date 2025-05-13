using banhang.Models;
using banhang.Models.ViewModel;
using banhang.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace banhang.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DataContext _context;

        public HomeController(DataContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var today = DateTime.Today; 
            var username = User.Identity?.Name ?? "Unknown"; 

            var revenueData = _context.Orders
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalSales = g.Sum(o => o.TotalAmount)
                })
                .OrderBy(g => g.Date)
                .AsEnumerable()
                .Select(g => new RevenueViewModel
                {
                    Date = g.Date.ToString("dd/MM"),
                    TotalSales = (int)g.TotalSales
                })
                .ToList();

            var totalOrdersToday = _context.Orders
                .Count(o => o.OrderDate.Date == today);
            //
            var totalReturnOrdersToday = _context.ReturnOrders
                .Count(ro => ro.ReturnDate.Date == today);
            ;

            var topProducts = _context.OrderDetails
                .GroupBy(od => od.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    ProductName = g.First().Product.ProductName,
                    TotalSold = g.Sum(od => od.Quantity)
                })
                .OrderByDescending(p => p.TotalSold)
                .Take(5)
                .ToList();

            ViewBag.TopProducts = topProducts;
            ViewBag.TotalOrdersToday = totalOrdersToday;
            ViewBag.TotalReturnOrdersToday = totalReturnOrdersToday;

            var orderLogs = _context.Orders
                .Select(o => new
                {
                    UserName = username,
                    Action = "đã tạo đơn hàng",
                    Reference = o.OrderId,
                    Timestamp = o.OrderDate
                });

            var purchaseLogs = _context.PurchaseOrders
                .Select(p => new
                {
                    UserName = username,
                    Action = "đã nhập hàng",
                    Reference = p.PurchaseOrderId,
                    Timestamp = p.PurchaseOrderDate
                });

            var activityLogs = orderLogs.Concat(purchaseLogs)
                .OrderByDescending(log => log.Timestamp)
                .Take(10)
                .ToList();
            var inventoryData = _context.Products
                .OrderByDescending(p => p.Stock)
                .Take(10) 
                .Select(p => new
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    StockQuantity = p.Stock
                })
                .ToList();

            ViewBag.Inventory = inventoryData; 


            ViewBag.ActivityLogs = activityLogs;
            ViewBag.LastLoggedInUser = username;
            return View(revenueData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
