using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using banhang.Models;
using Microsoft.AspNetCore.Authorization;
using banhang.Repository;
using Microsoft.AspNetCore.Hosting;
using OfficeOpenXml;

namespace banhang.Controllers
{

    public class PurchaseOrderController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PurchaseOrderController(DataContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [Authorize]
        public IActionResult Index()
        {

            var purchaseOrders = _context.PurchaseOrders
                .Include(po => po.Supplier)
                .OrderByDescending(po => po.PurchaseOrderId)
                .ToList();


            return View(purchaseOrders);
        }
        [HttpGet]
        public async Task<IActionResult> Search(string search = "", string startDate = "", string endDate = "", int page = 1)
        {
            int pageSize = 10;
            var query = _context.PurchaseOrders.Include(p => p.Supplier).AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(p =>
                    p.PurchaseOrderId.ToString().Contains(search) ||
                    (p.Supplier != null && p.Supplier.SupplierName.ToLower().Contains(search))
                );
            }

            if (DateTime.TryParse(startDate, out DateTime start))
            {
                query = query.Where(p => p.PurchaseOrderDate.Date >= start.Date);
            }
            if (DateTime.TryParse(endDate, out DateTime end))
            {
                query = query.Where(p => p.PurchaseOrderDate.Date <= end.Date);
            }

            int totalOrders = await query.CountAsync();
            int totalPages = (int)Math.Ceiling((double)totalOrders / pageSize);
            if (page > totalPages) page = totalPages;
            if (page < 1) page = 1;

            var orders = await query
                .OrderByDescending(p => p.PurchaseOrderDate)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Json(new
            {
                orders = orders.Select(o => new
                {
                    orderId = o.PurchaseOrderId,
                    orderDate = o.PurchaseOrderDate.ToString("yyyy-MM-dd"),
                    supplierName = o.Supplier != null ? o.Supplier.SupplierName : "Không xác định",
                    status = "Hoàn thành"
                }),
                totalPages,
                currentPage = page
            });
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddPO()
        {
            ViewData["Suppliers"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName");
            ViewData["Products"] = new SelectList(_context.Products, "ProductId", "ProductName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPO(PurchaseOrder model, string ProductIds, string Quantities)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.PurchaseOrders.Add(model);
                        await _context.SaveChangesAsync();

                        var productIds = string.IsNullOrWhiteSpace(ProductIds) ? new List<int>() : ProductIds.Split(',').Select(int.Parse).ToList();
                        var quantities = string.IsNullOrWhiteSpace(Quantities) ? new List<int>() : Quantities.Split(',').Select(int.Parse).ToList();

                        for (int i = 0; i < productIds.Count; i++)
                        {
                            var orderDetail = new PurchaseOrderDetail
                            {
                                PurchaseOrderId = model.PurchaseOrderId,
                                ProductId = productIds[i],
                                Quantity = quantities[i],
                                SupplierId = model.SupplierId
                            };

                            _context.PurchaseOrderDetails.Add(orderDetail);

                            // Cập nhật số lượng tồn kho
                            var product = _context.Products.FirstOrDefault(p => p.ProductId == productIds[i]);
                            if (product != null)
                            {
                                product.Stock += quantities[i];
                                _context.Entry(product).State = EntityState.Modified;
                            }
                        }

                        await _context.SaveChangesAsync();
                        transaction.Commit();

                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ModelState.AddModelError("", $"Lỗi: {ex.Message}");
                    }
                }
            }

            ViewData["Suppliers"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName");
            ViewData["Products"] = new SelectList(_context.Products, "ProductId", "ProductName");

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditPO(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders
                .Include(po => po.PurchaseOrderDetails)
                .FirstOrDefaultAsync(po => po.PurchaseOrderId == id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            ViewData["Suppliers"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", purchaseOrder.SupplierId);
            ViewData["Products"] = new SelectList(_context.Products, "ProductId", "ProductName");

            return View(purchaseOrder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPO(PurchaseOrder model, string ProductIds, string Quantities)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var existingOrder = await _context.PurchaseOrders
                            .Include(po => po.PurchaseOrderDetails)
                            .FirstOrDefaultAsync(po => po.PurchaseOrderId == model.PurchaseOrderId);

                        if (existingOrder == null)
                        {
                            return NotFound();
                        }

                        existingOrder.SupplierId = model.SupplierId;
                        existingOrder.PurchaseOrderDate = model.PurchaseOrderDate;

                        foreach (var detail in existingOrder.PurchaseOrderDetails)
                        {
                            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == detail.ProductId);
                            if (product != null)
                            {
                                product.Stock -= detail.Quantity; 
                            }
                            _context.PurchaseOrderDetails.Remove(detail);
                        }

                        await _context.SaveChangesAsync();

                        var productIds = string.IsNullOrWhiteSpace(ProductIds) ? new List<int>() : ProductIds.Split(',').Select(int.Parse).ToList();
                        var quantities = string.IsNullOrWhiteSpace(Quantities) ? new List<int>() : Quantities.Split(',').Select(int.Parse).ToList();

                        for (int i = 0; i < productIds.Count; i++)
                        {
                            var newDetail = new PurchaseOrderDetail
                            {
                                PurchaseOrderId = model.PurchaseOrderId,
                                ProductId = productIds[i],
                                Quantity = quantities[i],
                                SupplierId = model.SupplierId
                            };

                            _context.PurchaseOrderDetails.Add(newDetail);

                            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productIds[i]);
                            if (product != null)
                            {
                                product.Stock += quantities[i];
                            }
                        }

                        await _context.SaveChangesAsync();
                        transaction.Commit();

                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ModelState.AddModelError("", $"Lỗi khi cập nhật đơn nhập: {ex.Message}");
                    }
                }
            }

            ViewData["Suppliers"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", model.SupplierId);
            ViewData["Products"] = new SelectList(_context.Products, "ProductId", "ProductName");

            return View(model);
        }
        [HttpGet]
        public IActionResult ExportToExcel()
        {
            var orders = _context.PurchaseOrders.Include(p => p.Supplier).ToList();

            string exportPath = Path.Combine(_webHostEnvironment.WebRootPath, "exports");
            if (!Directory.Exists(exportPath))
            {
                Directory.CreateDirectory(exportPath);
            }

            string filePath = Path.Combine(exportPath, "DonNhapHang.xlsx");

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Đơn nhập hàng");

                // Header
                worksheet.Cells[1, 1].Value = "Mã đơn nhập";
                worksheet.Cells[1, 2].Value = "Nhà cung cấp";
                worksheet.Cells[1, 3].Value = "Ngày nhập";
                worksheet.Cells[1, 4].Value = "Trạng thái";

                int row = 2;
                foreach (var order in orders)
                {
                    worksheet.Cells[row, 1].Value = order.PurchaseOrderId;
                    worksheet.Cells[row, 2].Value = order.Supplier?.SupplierName ?? "Không xác định";
                    worksheet.Cells[row, 3].Value = order.PurchaseOrderDate.ToString("dd/MM/yyyy");
                    worksheet.Cells[row, 4].Value = "Hoàn thành";
                    row++;
                }

                package.SaveAs(new FileInfo(filePath));
            }

            return PhysicalFile(filePath, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DonNhapHang.xlsx");
        }
    }
}
