using banhang.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace banhang.Controllers
{
    public class FileController : Controller
    {
        private readonly string _exportPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "exports");

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search(string search, string startDate, string endDate, int page = 1, int pageSize = 10)
        {
            if (!Directory.Exists(_exportPath))
            {
                Directory.CreateDirectory(_exportPath);
            }

            var files = new DirectoryInfo(_exportPath)
                .GetFiles("*.xlsx")
                .Select(file => new FileViewModel
                {
                    FileName = file.Name,
                    LastModified = file.LastWriteTime.ToString("dd/MM/yyyy HH:mm"),
                    LastModifiedDate = file.LastWriteTime 
                })
                .OrderByDescending(f => f.LastModifiedDate)
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                files = files.Where(f => f.FileName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (DateTime.TryParse(startDate, out DateTime start) && DateTime.TryParse(endDate, out DateTime end))
            {
                end = end.AddDays(1).AddSeconds(-1); // Lấy hết ngày cuối cùng
                files = files.Where(f => f.LastModifiedDate >= start && f.LastModifiedDate <= end).ToList();
            }

            int totalFiles = files.Count;
            int totalPages = (int)Math.Ceiling((double)totalFiles / pageSize);
            var pagedFiles = files.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return Json(new
            {
                files = pagedFiles,
                totalPages,
                currentPage = page
            });
        }

        public IActionResult DownloadFile(string fileName)
        {
            var filePath = Path.Combine(_exportPath, fileName);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File không tồn tại!");
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        [HttpPost]
        public IActionResult DeleteFile(string fileName)
        {
            var filePath = Path.Combine(_exportPath, fileName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
                return Json(new { success = true, message = "Xóa file thành công!" });
            }
            return Json(new { success = false, message = "File không tồn tại!" });
        }
    }
}
