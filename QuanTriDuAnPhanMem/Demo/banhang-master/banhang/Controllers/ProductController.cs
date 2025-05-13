using banhang.Models;
using banhang.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Globalization;

namespace banhang.Controllers
{

    public class ProductController : Controller
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        // 
        [Authorize]
        public IActionResult Index(string sortOrder)
        {
            ViewBag.SortOrder = sortOrder;

            var products = _context.Products
                   .Include(p => p.Category)
                   .AsQueryable();
            if (sortOrder == "asc")
            {
                products = products.OrderBy(p => p.CreatedAtProduct);
            }
            else
            {
                products = products.OrderByDescending(p => p.CreatedAtProduct);
            }

            return View(products.ToList());
        }
        [HttpGet]
        public async Task<IActionResult> Search(string keyword = "", int page = 1)
        {
            int pageSize = 10; // Số sản phẩm mỗi trang
            var productsQuery = _context.Products.AsNoTracking(); // Tăng hiệu suất với AsNoTracking

            // Lọc sản phẩm theo ID hoặc tên sản phẩm
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();

                if (int.TryParse(keyword, out int productId))
                {
                    productsQuery = productsQuery.Where(p => p.ProductId == productId);
                }
                else
                {
                    productsQuery = productsQuery.Where(p => EF.Functions.Like(p.ProductName, $"%{keyword}%"));
                }
            }

            int totalProducts = await productsQuery.CountAsync();
            int totalPages = totalProducts == 0 ? 1 : (int)Math.Ceiling((double)totalProducts / pageSize);
            page = Math.Max(1, Math.Min(page, totalPages));

            var products = await productsQuery
                .OrderByDescending(p => p.CreatedAtProduct)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;
            ViewData["Keyword"] = keyword;

            return PartialView("_ProductTable", products);
        }

        [Authorize]
        public IActionResult ProductDetails(int id)
        {
            var product = _context.Products
                                  .Include(p => p.Category)
                                  .FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // 
        [Authorize(Roles = "Admin")]
        public IActionResult AddProduct()
        {
            LoadCategories(); 
            return View();
        }

        // 
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View(product);
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Thêm sản phẩm thành công!";
            return RedirectToAction("Index");
        }
        //
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditProduct(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            var product = _context.Products
                                  .Include(p => p.Category)
                                  .FirstOrDefault(p => p.ProductId == id.Value);

            if (product == null)
            {
                return NotFound();
            }

            LoadCategories();
            return View(product);
        }
        //
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View(product);
            }

            var existingProduct = await _context.Products.FindAsync(product.ProductId);
            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.ProductName = product.ProductName;
            existingProduct.ProductDescription = product.ProductDescription;
            existingProduct.Price = product.Price;
            existingProduct.ImageUrl = product.ImageUrl;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.Stock = product.Stock;
            existingProduct.CreatedAtProduct = product.CreatedAtProduct;

            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Cập nhật sản phẩm thành công!";
            return RedirectToAction("Index");
        }
        //
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); 
        }

		private void LoadCategories()
        {
            ViewData["CategoryList"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
        }
        //xuất
        public IActionResult ExportToExcel()
        {
            var products = _context.Products.ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Products");

                worksheet.Cells[1, 1].Value = "Mã SP";
                worksheet.Cells[1, 2].Value = "Tên SP";
                worksheet.Cells[1, 3].Value = "Giá";
                worksheet.Cells[1, 4].Value = "Số lượng";
                worksheet.Cells[1, 5].Value = "Mô tả";
                worksheet.Cells[1, 6].Value = "Đường dẫn ảnh";
                worksheet.Cells[1, 7].Value = "Ngày tạo";

                using (var range = worksheet.Cells[1, 1, 1, 7])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                int row = 2;
                foreach (var product in products)
                {
                    worksheet.Cells[row, 1].Value = product.ProductId;
                    worksheet.Cells[row, 2].Value = product.ProductName;
                    worksheet.Cells[row, 3].Value = product.Price;
                    worksheet.Cells[row, 4].Value = product.Stock;
                    worksheet.Cells[row, 5].Value = product.ProductDescription;
                    worksheet.Cells[row, 6].Value = product.ImageUrl;
                    worksheet.Cells[row, 7].Value = product.CreatedAtProduct;
                    worksheet.Cells[row, 7].Style.Numberformat.Format = "dd/MM/yyyy";
                    row++;
                }

                worksheet.Cells.AutoFitColumns();

                string exportPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "exports");
                if (!Directory.Exists(exportPath))
                {
                    Directory.CreateDirectory(exportPath);
                }

                string fileName = $"Products_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string filePath = Path.Combine(exportPath, fileName);

                System.IO.File.WriteAllBytes(filePath, package.GetAsByteArray());

                var stream = new MemoryStream(System.IO.File.ReadAllBytes(filePath));
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
        //nhập
        [HttpPost]
        public async Task<IActionResult> ImportFromExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                TempData["ErrorMessage"] = "Vui lòng chọn file!";
                return RedirectToAction("Index");
            }

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null)
                    {
                        TempData["ErrorMessage"] = "File không hợp lệ!";
                        return RedirectToAction("Index");
                    }

                    var rowCount = worksheet.Dimension.Rows;
                    var products = new List<Product>();

                    for (int row = 2; row <= rowCount; row++) 
                    {
                        var productName = worksheet.Cells[row, 2].Value?.ToString();
                        var price = decimal.TryParse(worksheet.Cells[row, 3].Value?.ToString(), out var p) ? p : 0;
                        var stock = int.TryParse(worksheet.Cells[row, 4].Value?.ToString(), out var s) ? s : 0;
                        var description = worksheet.Cells[row, 5].Value?.ToString();
                        var imageUrl = worksheet.Cells[row, 6].Value?.ToString();
                        var createdAt = ConvertExcelDate(worksheet.Cells[row, 7].Value);

                        if (string.IsNullOrWhiteSpace(productName))
                            continue; 

                        var product = new Product
                        {
                            ProductName = productName,
                            Price = price,
                            Stock = stock,
                            ProductDescription = description,
                            ImageUrl = imageUrl,
                            CreatedAtProduct = createdAt
                        };

                        products.Add(product);
                    }

                    _context.Products.AddRange(products);
                    await _context.SaveChangesAsync();
                }
            }

            TempData["SuccessMessage"] = "Nhập sản phẩm thành công!";
            return RedirectToAction("Index");
        }

        private DateTime ConvertExcelDate(object value)
        {
            if (value == null) return DateTime.Now;

            if (value is double excelDate)
            {
                return DateTime.FromOADate(excelDate); // Chuyển số serial thành DateTime
            }
            else if (DateTime.TryParse(value.ToString(), out DateTime dateTime))
            {
                return dateTime; // Nếu là chuỗi hợp lệ, parse bình thường
            }

            return DateTime.Now; // Trả về ngày hiện tại nếu không thể parse
        }
    }
}
