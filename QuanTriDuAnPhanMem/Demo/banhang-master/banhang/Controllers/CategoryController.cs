using banhang.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Globalization;
using banhang.Repository;

namespace banhang.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _context;

        public CategoryController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.AsNoTracking().ToListAsync();
            return View(categories);
        }
        [HttpGet]
        public async Task<IActionResult> SearchCategory(string search = "", string startDate = "", string endDate = "", int page = 1)
        {
            int pageSize = 10;
            var categoriesQuery = _context.Categories.AsQueryable();

            // Lọc theo tên danh mục
            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim().ToLower();
                categoriesQuery = categoriesQuery.Where(c => c.CategoryName.ToLower().Contains(search));
            }

            // Lọc theo ngày tạo
            if (DateTime.TryParse(startDate, out DateTime start) && DateTime.TryParse(endDate, out DateTime end))
            {
                end = end.AddDays(1).AddTicks(-1); // Lấy hết ngày
                categoriesQuery = categoriesQuery.Where(c => c.CreatedAtCategory >= start && c.CreatedAtCategory <= end);
            }

            // Lấy tổng số danh mục
            var totalCategories = await categoriesQuery.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCategories / (double)pageSize);

            // Lấy danh mục theo trang
            var categories = await categoriesQuery
                .OrderByDescending(c => c.CreatedAtCategory)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new
                {
                    categoryId = c.CategoryId,
                    categoryName = c.CategoryName,
                    createdAt = c.CreatedAtCategory.ToString("dd/MM/yyyy")
                })
                .ToListAsync();

            return Json(new { categories, totalPages, currentPage = page });
        }

        public IActionResult AddCategory()
        {
            return View(new Category());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCategory([Bind("CategoryName,CategoryDescription")] Category category)
        {
            if (!ModelState.IsValid) return View(category);

            try
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Thêm danh mục thành công!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu vào CSDL: {ex}");
                ModelState.AddModelError("", "Lỗi hệ thống, vui lòng thử lại!");
                return View(category);
            }
        }

        public async Task<IActionResult> EditCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                TempData["ErrorMessage"] = "Danh mục không tồn tại!";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(int id, [Bind("CategoryId,CategoryName,CategoryDescription")] Category category)
        {
            if (id != category.CategoryId)
            {
                TempData["ErrorMessage"] = "Dữ liệu không hợp lệ!";
                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid) return View(category);

            try
            {
                _context.Update(category);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Cập nhật danh mục thành công!";
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật CSDL: {ex}");
                ModelState.AddModelError("", "Lỗi hệ thống, vui lòng thử lại!");
                return View(category);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                TempData["ErrorMessage"] = "Danh mục không tồn tại!";
                return RedirectToAction("Index");
            }

            try
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Xóa danh mục thành công!";
                return RedirectToAction("Index");
            }
            catch (DbUpdateException)
            {
                TempData["ErrorMessage"] = "Không thể xóa danh mục này vì nó có liên kết với sản phẩm!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa danh mục: {ex}");
                TempData["ErrorMessage"] = "Lỗi hệ thống, vui lòng thử lại!";
                return RedirectToAction("Index");
            }
        }

        public IActionResult ExportToExcel()
        {
            var categories = _context.Categories.ToList();
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Categories");

            string[] headers = { "Mã Loại", "Tên Loại Sp", "Mô tả", "Ngày Khởi Tạo" };
            for (int i = 0; i < headers.Length; i++) worksheet.Cells[1, i + 1].Value = headers[i];

            using (var range = worksheet.Cells[1, 1, 1, headers.Length])
            {
                range.Style.Font.Bold = true;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
            }

            int row = 2;
            foreach (var category in categories)
            {
                worksheet.Cells[row, 1].Value = category.CategoryId;
                worksheet.Cells[row, 2].Value = category.CategoryName;
                worksheet.Cells[row, 3].Value = category.CategoryDescription;
                worksheet.Cells[row, 4].Value = category.CreatedAtCategory.ToString("dd/MM/yyyy");
                row++;
            }

            worksheet.Cells.AutoFitColumns();
            var stream = new MemoryStream();
            package.SaveAs(stream);
            stream.Position = 0;

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Categories.xlsx");
        }
        [HttpPost]
        public async Task<IActionResult> ImportFromExcelCategory(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                TempData["ErrorMessage"] = "Vui lòng chọn file!";
                return RedirectToAction("Index");
            }

            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            using var package = new ExcelPackage(stream);
            var worksheet = package.Workbook.Worksheets.FirstOrDefault();
            if (worksheet == null)
            {
                TempData["ErrorMessage"] = "File không hợp lệ!";
                return RedirectToAction("Index");
            }

            var categories = new List<Category>();
            int rowCount = worksheet.Dimension.Rows;
            for (int row = 2; row <= rowCount; row++)
            {
                var categoryName = worksheet.Cells[row, 2].Value?.ToString()?.Trim();
                if (string.IsNullOrEmpty(categoryName) || _context.Categories.Any(c => c.CategoryName == categoryName)) continue;

                categories.Add(new Category
                {
                    CategoryName = categoryName,
                    CategoryDescription = worksheet.Cells[row, 3].Value?.ToString(),
                    CreatedAtCategory = ConvertExcelDate(worksheet.Cells[row, 4].Value)
                });
            }

            if (categories.Any())
            {
                _context.Categories.AddRange(categories);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Nhập danh mục thành công!";
            }
            else
            {
                TempData["ErrorMessage"] = "Không có danh mục mới nào được nhập!";
            }
            return RedirectToAction("Index");
        }

        private DateTime ConvertExcelDate(object value)
        {
            if (value == null) return DateTime.Now;
            return value is double excelDate ? DateTime.FromOADate(excelDate) : DateTime.TryParse(value.ToString(), out var date) ? date : DateTime.Now;
        }
    }
}
