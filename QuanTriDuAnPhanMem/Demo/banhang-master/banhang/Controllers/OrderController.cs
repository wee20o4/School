using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using banhang.Models;
using banhang.Repository;
using OfficeOpenXml.Style;
using OfficeOpenXml;

public class OrderController : Controller
{
    private readonly DataContext _context;

    public OrderController(DataContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int page = 1)
    {
        int pageSize = 10;

        var ordersQuery = _context.Orders
            .Include(o => o.Customer)
            .OrderByDescending(o => o.OrderDate);

        var totalOrders = await ordersQuery.CountAsync();
        var totalPages = (int)Math.Ceiling(totalOrders / (double)pageSize);

        var orders = await ordersQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;

        return View(orders);
    }

    public async Task<IActionResult> Search(string search = "", string startDate = "", string endDate = "")
    {
        var ordersQuery = _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.Order_Details)
            .ThenInclude(od => od.Product)
            .OrderByDescending(o => o.OrderDate)
            .AsQueryable();

        if (!string.IsNullOrEmpty(search))
        {
            search = search.Trim().ToLower();
            ordersQuery = ordersQuery.Where(o =>
                (o.Customer != null && o.Customer.CustomerName.ToLower().Contains(search)) ||
                o.Order_Details.Any(od => od.Product.ProductName.ToLower().Contains(search))
            );
        }

        if (DateTime.TryParse(startDate, out DateTime start) && DateTime.TryParse(endDate, out DateTime end))
        {
            end = end.AddDays(1).AddTicks(-1);
            ordersQuery = ordersQuery.Where(o => o.OrderDate >= start && o.OrderDate <= end);
        }

        var orders = await ordersQuery.Select(o => new
        {
            orderId = o.OrderId,
            orderDate = o.OrderDate,
            customerName = o.Customer != null ? o.Customer.CustomerName : "Khách lẻ",
            totalAmount = o.TotalAmount
        }).ToListAsync();

        return Json(orders);
    }
    public async Task<IActionResult> Details(int id)
    {
        var order = await _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.Order_Details)
                .ThenInclude(od => od.Product)
            .FirstOrDefaultAsync(o => o.OrderId == id);

        if (order == null)
        {
            return NotFound();
        }

        return View(order);
    }
    public IActionResult ExportOrders()
    {
        var orders = _context.Orders.Include(o => o.Customer).ToList();

        var exportPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "exports");
        if (!Directory.Exists(exportPath))
        {
            Directory.CreateDirectory(exportPath);
        }

        var filePath = Path.Combine(exportPath, "DonHang.xlsx");

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Đơn hàng");

            // Header
            worksheet.Cells[1, 1].Value = "ID";
            worksheet.Cells[1, 2].Value = "Khách hàng";
            worksheet.Cells[1, 3].Value = "Ngày đặt";
            worksheet.Cells[1, 4].Value = "Tổng tiền";

            int row = 2;
            foreach (var order in orders)
            {
                worksheet.Cells[row, 1].Value = order.OrderId;
                worksheet.Cells[row, 2].Value = order.Customer?.CustomerName;
                worksheet.Cells[row, 3].Value = order.OrderDate.ToString("dd/MM/yyyy");
                worksheet.Cells[row, 4].Value = order.TotalAmount;
                row++;
            }

            package.SaveAs(new FileInfo(filePath));
        }

        return PhysicalFile(filePath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DonHang.xlsx");
    }
}
