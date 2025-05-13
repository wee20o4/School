using banhang.Models;
using banhang.Models.ViewModel;
using banhang.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace banhang.Controllers
{
    public class ReturnOrderController : Controller
    {
        private readonly DataContext _context;

        public ReturnOrderController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 10;

            var returnOrdersQuery = _context.ReturnOrders
                .OrderByDescending(o => o.ReturnDate);

            var totalOrders = await returnOrdersQuery.CountAsync();
            var totalPages = (int)Math.Ceiling(totalOrders / (double)pageSize);

            var returnOrders = await returnOrdersQuery
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(returnOrders);
        }

        public async Task<IActionResult> Search(string search = "", string startDate = "", string endDate = "")
        {
            var returnOrdersQuery = _context.ReturnOrders
                .Include(o => o.ReturnOrderDetails)
                .ThenInclude(rd => rd.Product)
                .Join(_context.Customers,
                      o => o.CustomerId,
                      c => c.CustomerId,
                      (o, c) => new { ReturnOrder = o, Customer = c })
                .OrderByDescending(o => o.ReturnOrder.ReturnDate)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim().ToLower();
                returnOrdersQuery = returnOrdersQuery.Where(o =>
                    o.Customer.CustomerName.ToLower().Contains(search) ||
                    o.ReturnOrder.ReturnOrderDetails.Any(rd => rd.Product != null && rd.Product.ProductName.ToLower().Contains(search))
                );
            }

            if (DateTime.TryParse(startDate, out DateTime start) && DateTime.TryParse(endDate, out DateTime end))
            {
                end = end.AddDays(1).AddTicks(-1);
                returnOrdersQuery = returnOrdersQuery.Where(o => o.ReturnOrder.ReturnDate >= start && o.ReturnOrder.ReturnDate <= end);
            }

            var returnOrders = await returnOrdersQuery.Select(o => new
            {
                returnOrderId = o.ReturnOrder.ReturnOrderId,
                returnDate = o.ReturnOrder.ReturnDate,
                customerName = o.Customer.CustomerName, 
                totalRefund = o.ReturnOrder.TotalRefund
            }).ToListAsync();

            return Json(returnOrders);
        }

        public async Task<IActionResult> Create(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.Order_Details)
                    .ThenInclude(od => od.Product)
                .FirstOrDefaultAsync(o => o.OrderId == orderId);

            if (order == null)
            {
                return NotFound();
            }

            var viewModel = new ReturnOrderViewModel
            {
                OrderId = orderId,
                CustomerId = order.CustomerId,
                Products = order.Order_Details.Select(od => new ReturnOrderItemViewModel
                {
                    ProductId = od.ProductId,
                    ProductName = od.Product.ProductName,
                    QuantityPurchased = od.Quantity,
                    QuantityToReturn = 0
                }).ToList()
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ProcessReturn(ReturnOrderViewModel model)
        {
            if (model.Products.All(p => p.QuantityToReturn == 0))
            {
                ModelState.AddModelError("", "Bạn chưa chọn sản phẩm để trả.");
                return View("Create", model);
            }

            var order = await _context.Orders
                .Include(o => o.Order_Details)
                .FirstOrDefaultAsync(o => o.OrderId == model.OrderId);

            if (order == null)
            {
                return NotFound();
            }

            var returnOrder = new ReturnOrder
            {
                OrderId = model.OrderId,
                CustomerId = model.CustomerId,
                ReturnDate = DateTime.Now,
                Status = 0, // 0 = Chờ xử lý
                Reason = "Khách hàng yêu cầu đổi/trả hàng",
                TotalRefund = 0
            };

            _context.ReturnOrders.Add(returnOrder);
            await _context.SaveChangesAsync(); 

            decimal totalRefund = 0;

            foreach (var item in model.Products.Where(p => p.QuantityToReturn > 0))
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null) continue; 

                var refundAmount = item.QuantityToReturn * product.Price;

                var returnDetail = new ReturnOrderDetail
                {
                    ReturnOrderId = returnOrder.ReturnOrderId,
                    ProductId = item.ProductId,
                    Quantity = item.QuantityToReturn,
                    RefundAmount = refundAmount
                };
                _context.ReturnOrderDetails.Add(returnDetail);

                // Cập nhật kho
                product.Stock += item.QuantityToReturn;

                // Cập nhật chi tiết đơn hàng
                var orderDetail = order.Order_Details.FirstOrDefault(od => od.ProductId == item.ProductId);
                if (orderDetail != null)
                {
                    orderDetail.Quantity -= item.QuantityToReturn;
                    if (orderDetail.Quantity <= 0)
                    {
                        _context.OrderDetails.Remove(orderDetail);
                    }
                }

                totalRefund += refundAmount;
            }

            // Kiểm tra nếu đơn hàng đã trả hết
            if (!order.Order_Details.Any())
            {
                order.Status = "Đã hoàn trả toàn bộ"; 
                order.TotalAmount = 0;
            }
            else
            {
                order.TotalAmount = order.Order_Details.Sum(od => od.Quantity * od.UnitPrice);
            }

            returnOrder.TotalRefund = totalRefund; 

            await _context.SaveChangesAsync(); 

            TempData["SuccessMessage"] = "Yêu cầu trả hàng đã được xử lý.";
            return RedirectToAction("Details", "Order", new { id = model.OrderId });
        }
        public async Task<IActionResult> Details(int id)
        {
            var returnOrder = await _context.ReturnOrders
                .Include(ro => ro.ReturnOrderDetails)
                    .ThenInclude(rod => rod.Product)
                .FirstOrDefaultAsync(ro => ro.ReturnOrderId == id);

            if (returnOrder == null)
            {
                return NotFound();
            }

            return View(returnOrder);
        }
        public async Task<IActionResult> ExportReturnOrders()
        {
            var returnOrders = await _context.ReturnOrders
                .Include(ro => ro.Customer) 
                .OrderByDescending(ro => ro.ReturnDate)
                .ToListAsync();

            var exportPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "exports");
            if (!Directory.Exists(exportPath))
            {
                Directory.CreateDirectory(exportPath);
            }

            var filePath = Path.Combine(exportPath, "DonTraHang.xlsx");

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Đơn Trả Hàng");

                // Header
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Khách hàng";
                worksheet.Cells[1, 3].Value = "Ngày trả";
                worksheet.Cells[1, 4].Value = "Số tiền hoàn";

                int row = 2;
                foreach (var returnOrder in returnOrders)
                {
                    worksheet.Cells[row, 1].Value = returnOrder.ReturnOrderId;
                    worksheet.Cells[row, 2].Value = returnOrder.Customer != null ? returnOrder.Customer.CustomerName : "Không xác định";
                    worksheet.Cells[row, 3].Value = returnOrder.ReturnDate.ToString("dd/MM/yyyy");
                    worksheet.Cells[row, 4].Value = returnOrder.TotalRefund;
                    row++;
                }

                package.SaveAs(new FileInfo(filePath));
            }

            return PhysicalFile(filePath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DonTraHang.xlsx");
        }
    }
}
