using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using banhang.Models;
using banhang.Repository;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using banhang.Models.ViewModel;

public class POSController : Controller
{
    private readonly DataContext _context;

    public POSController(DataContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var customers = await _context.Customers
            .Select(c => new Customer
            {
                CustomerId = c.CustomerId,
                CustomerName = c.CustomerName ?? "Khách không tên",
                CustomerAddress = c.CustomerAddress ?? "Không có địa chỉ"
            })
            .ToListAsync();

        if (!customers.Any())
        {
            customers.Add(new Customer { CustomerId = 0, CustomerName = "Khách lẻ", CustomerAddress = "Không có địa chỉ" });
        }

        var products = _context.Products.ToList(); 
        ViewBag.Products = products;
        var orders = await _context.Orders.Include(o => o.Customer).ToListAsync();

        Console.WriteLine($"Customers count: {customers.Count}");
        Console.WriteLine($"Products count: {products.Count}");
        Console.WriteLine($"Orders count: {orders.Count}");

        ViewBag.Customers = customers;
        ViewBag.Orders = orders;

        return View();
    }

[HttpPost]
public async Task<IActionResult> ProcessOrder([FromBody] OrderViewModel model)
{
    if (model == null || model.OrderDetails == null || model.OrderDetails.Count == 0)
    {
        return BadRequest(new { message = "Dữ liệu không hợp lệ. Vui lòng chọn ít nhất một sản phẩm." });
    }

    using (var transaction = await _context.Database.BeginTransactionAsync())
    {
        try
        {

            if (model.CustomerId == 0)
            {
                var guestCustomer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerName == "Khách lẻ");
                if (guestCustomer == null)
                {
                    guestCustomer = new Customer { CustomerName = "Khách lẻ" };
                    _context.Customers.Add(guestCustomer);
                    await _context.SaveChangesAsync();
                }
                model.CustomerId = guestCustomer.CustomerId;
            }

            var order = new Order
            {
                CustomerId = model.CustomerId,
                OrderDate = DateTime.Now,
                TotalAmount = 0,
                Status = model.OrderNote
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(); 

            var orderDetails = new List<Order_Details>();

            foreach (var item in model.OrderDetails)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null)
                {
                    return BadRequest(new { message = $"Sản phẩm không hợp lệ: {item.ProductId}" });
                }

                orderDetails.Add(new Order_Details
                {
                    OrderId = order.OrderId,
                    ProductId = product.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = product.Price
                });

                product.Stock -= item.Quantity;
                order.TotalAmount += product.Price * item.Quantity;
            }

            _context.OrderDetails.AddRange(orderDetails);
            await _context.SaveChangesAsync(); 

            await transaction.CommitAsync();

            return Ok(new { message = "Đơn hàng đã được xử lý thành công!", orderId = order.OrderId });
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            return StatusCode(500, new { message = "Đã xảy ra lỗi khi xử lý đơn hàng.", error = ex.Message });
        }
    }
}

    public async Task<IActionResult> OrderSuccess(int id)
    {
        var order = await _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.Order_Details)
            .ThenInclude(od => od.Product)
            .FirstOrDefaultAsync(o => o.OrderId == id);

        if (order == null) return NotFound();

        return View(order);
    }
    public IActionResult PrintInvoice(int orderId)
    {
        var order = _context.Orders
            .Include(o => o.Order_Details)
            .ThenInclude(od => od.Product)
            .FirstOrDefault(o => o.OrderId == orderId);

        if (order == null)
            return NotFound();

        var invoiceData = new
        {
            OrderId = order.OrderId,
            OrderDate = order.OrderDate.ToString("dd/MM/yyyy"),
            CustomerName = order.Customer?.CustomerName ?? "Khách lẻ",
            TotalAmount = order.TotalAmount,
            OrderNote = order.Status,


            Items = order.Order_Details.Select(od => new
            {
                ProductName = od.Product.ProductName,
                Quantity = od.Quantity,
                Price = od.UnitPrice,
                SubTotal = od.Quantity * od.UnitPrice
            }).ToList()
        };

        return View("PrintInvoice", invoiceData);
    }

}