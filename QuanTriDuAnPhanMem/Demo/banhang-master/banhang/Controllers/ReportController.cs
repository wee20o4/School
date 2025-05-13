using banhang.Models;
using banhang.Models.ViewModel;
using banhang.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Linq;
using Microsoft.Extensions.Hosting;

namespace banhang.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReportController(DataContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index(string filterType = "month")
        {
            ViewBag.FilterType = filterType; 

            DateTime startDate, endDate;
            DateTime today = DateTime.Today;

            switch (filterType.ToLower())
            {
                case "week":
                    startDate = today.AddDays(-7);
                    endDate = today.AddDays(1).AddTicks(-1); 
                    break;
                case "year":
                    startDate = new DateTime(today.Year, 1, 1);
                    endDate = today.AddDays(1).AddTicks(-1); 
                    break;
                default:
                    startDate = new DateTime(today.Year, today.Month, 1);
                    endDate = today.AddDays(1).AddTicks(-1); 
                    break;
            }

            ViewBag.RevenueReport = _context.Orders
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new
                {
                    Date = g.Key, 
                    TotalSales = g.Sum(o => o.TotalAmount)
                })
                .AsEnumerable() 
                .Select(g => new
                {
                    Date = g.Date.ToString("o"), 
                    TotalSales = g.TotalSales
                })
                .OrderBy(g => g.Date)
                .ToList();

            ViewBag.TotalOrders = _context.Orders.Count(o => o.OrderDate >= startDate && o.OrderDate <= endDate);
            ViewBag.TotalReturns = _context.ReturnOrders.Count(r => r.ReturnDate >= startDate && r.ReturnDate <= endDate);
            ViewBag.TotalCompletedOrders = _context.Orders.Count(o => o.Status == "Completed" && o.OrderDate >= startDate && o.OrderDate <= endDate);

            // Top 5 sản phẩm bán chạy
            ViewBag.TopSellingProducts = _context.OrderDetails
                .GroupBy(od => od.ProductId)
                .Select(g => new
                {
                    ProductName = g.First().Product.ProductName,
                    TotalSold = g.Sum(od => od.Quantity)
                })
                .OrderByDescending(p => p.TotalSold)
                .Take(5)
                .ToList();

            // Sản phẩm tồn kho thấp
            ViewBag.LowStockProducts = _context.Products
                .Where(p => p.Stock < 5)
                .Select(p => new { p.ProductName, p.Stock })
                .ToList();

            // Sản phẩm tồn kho vượt mức
            ViewBag.HighStockProducts = _context.Products
                .Where(p => p.Stock > 100)
                .Select(p => new { p.ProductName, p.Stock })
                .ToList();

            return View();
        }
        public IActionResult ExportLowStockProducts()
        {
            var lowStockProducts = _context.Products
                .Where(p => p.Stock < 5)
                .Select(p => new { p.ProductName, p.Stock })
                .ToList();

            if (!lowStockProducts.Any())
            {
                return RedirectToAction("Index"); 
            }

            string folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "exports");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); 
            }

            string fileName = $"SanPhamTonKhoThap_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
            string filePath = Path.Combine(folderPath, fileName);

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sản phẩm tồn kho thấp");

                worksheet.Cells["A1:B1"].Merge = true;
                worksheet.Cells["A1"].Value = "BÁO CÁO SẢN PHẨM TỒN KHO THẤP";
                worksheet.Cells["A1"].Style.Font.Size = 14;
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["A2"].Value = "Tên sản phẩm";
                worksheet.Cells["B2"].Value = "Tồn kho";
                worksheet.Cells["A2:B2"].Style.Font.Bold = true;
                worksheet.Cells["A2:B2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells["A2:B2"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                int row = 3;
                foreach (var product in lowStockProducts)
                {
                    worksheet.Cells[$"A{row}"].Value = product.ProductName;
                    worksheet.Cells[$"B{row}"].Value = product.Stock;
                    worksheet.Cells[$"B{row}"].Style.Font.Bold = product.Stock < 3;
                    row++;
                }

                worksheet.Cells.AutoFitColumns();
                package.SaveAs(new FileInfo(filePath)); 
            }

            return RedirectToAction("Index"); 
        }
        public IActionResult ExportHighStockProducts()
        {
            var highStockProducts = _context.Products
                .Where(p => p.Stock > 100)
                .Select(p => new { p.ProductName, p.Stock })
                .ToList();

            if (!highStockProducts.Any())
            {
                return RedirectToAction("Index"); 
            }

            string folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "exports");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); 
            }

            string fileName = $"SanPhamTonKhoCao_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
            string filePath = Path.Combine(folderPath, fileName);

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sản phẩm tồn kho cao");

                worksheet.Cells["A1:B1"].Merge = true;
                worksheet.Cells["A1"].Value = "BÁO CÁO SẢN PHẨM TỒN KHO CAO";
                worksheet.Cells["A1"].Style.Font.Size = 14;
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["A2"].Value = "Tên sản phẩm";
                worksheet.Cells["B2"].Value = "Tồn kho";
                worksheet.Cells["A2:B2"].Style.Font.Bold = true;
                worksheet.Cells["A2:B2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells["A2:B2"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                int row = 3;
                foreach (var product in highStockProducts)
                {
                    worksheet.Cells[$"A{row}"].Value = product.ProductName;
                    worksheet.Cells[$"B{row}"].Value = product.Stock;
                    row++;
                }

                worksheet.Cells.AutoFitColumns();
                package.SaveAs(new FileInfo(filePath)); 
            }

            return RedirectToAction("Index"); 
        }
        public IActionResult ExportRevenueReport(string filterType = "month")
        {
            DateTime startDate, endDate;
            DateTime today = DateTime.Today;

            switch (filterType.ToLower())
            {
                case "week":
                    startDate = today.AddDays(-7);
                    endDate = today.AddDays(1).AddTicks(-1);
                    break;
                case "month":
                    startDate = new DateTime(today.Year, today.Month, 1);
                    endDate = today.AddDays(1).AddTicks(-1);
                    break;
                case "year":
                    startDate = new DateTime(today.Year, 1, 1);
                    endDate = today.AddDays(1).AddTicks(-1);
                    break;
                default:
                    startDate = new DateTime(today.Year, today.Month, 1);
                    endDate = today.AddDays(1).AddTicks(-1);
                    break;
            }

            var revenueData = _context.Orders
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalSales = g.Sum(o => o.TotalAmount),
                    TotalOrders = g.Count()
                })
                .ToList();

            var returnData = _context.ReturnOrders
                .Where(r => r.ReturnDate >= startDate && r.ReturnDate <= endDate)
                .GroupBy(r => r.ReturnDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalReturns = g.Count()
                })
                .ToList();

            string folderPath = Path.Combine(_webHostEnvironment.WebRootPath, "exports");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = $"BaoCaoDoanhThu_{filterType}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
            string filePath = Path.Combine(folderPath, fileName);

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Báo cáo doanh thu");

                // Tiêu đề báo cáo
                worksheet.Cells["A1:D1"].Merge = true;
                worksheet.Cells["A1"].Value = $"BÁO CÁO DOANH THU ({filterType.ToUpper()})";
                worksheet.Cells["A1"].Style.Font.Size = 14;
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // Header
                worksheet.Cells["A2"].Value = "Ngày";
                worksheet.Cells["B2"].Value = "Tổng doanh thu";
                worksheet.Cells["C2"].Value = "Tổng đơn hàng";
                worksheet.Cells["D2"].Value = "Tổng đơn hoàn";
                worksheet.Cells["A2:D2"].Style.Font.Bold = true;
                worksheet.Cells["A2:D2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells["A2:D2"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                int row = 3;
                foreach (var revenue in revenueData)
                {
                    worksheet.Cells[$"A{row}"].Value = revenue.Date.ToString("yyyy-MM-dd");
                    worksheet.Cells[$"B{row}"].Value = revenue.TotalSales;
                    worksheet.Cells[$"C{row}"].Value = revenue.TotalOrders;

                    var returnOrder = returnData.FirstOrDefault(r => r.Date == revenue.Date);
                    worksheet.Cells[$"D{row}"].Value = returnOrder?.TotalReturns ?? 0;

                    row++;
                }

                worksheet.Cells.AutoFitColumns();

                package.SaveAs(new FileInfo(filePath));

                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }

    }
}
