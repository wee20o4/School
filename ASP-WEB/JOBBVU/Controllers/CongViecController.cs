using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using JOBBVU.Data;
using JOBBVU.Models;
using System.Linq;
using System.Threading.Tasks;

namespace JOBBVU.Controllers
{
    [Authorize] // Chỉ cho phép người dùng đã đăng nhập quản lý công việc
    public class CongViecController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CongViecController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hiển thị danh sách công việc
        public IActionResult Index()
        {
            var jobs = _context.CongViecs.ToList();
            return View(jobs);
        }

        // Hiển thị form đăng công việc
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý đăng công việc
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CongViec job)
        {
            if (ModelState.IsValid)
            {
                job.NgayDang = DateTime.Now;
                job.TrangThai = "Đang tuyển";

                _context.CongViecs.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // Xem chi tiết công việc
        public IActionResult Details(int id)
        {
            var job = _context.CongViecs.FirstOrDefault(j => j.MaCV == id);
            if (job == null) return NotFound();
            return View(job);
        }

        // Hiển thị form chỉnh sửa công việc
        public IActionResult Edit(int id)
        {
            var job = _context.CongViecs.FirstOrDefault(j => j.MaCV == id);
            if (job == null) return NotFound();
            return View(job);
        }

        // Xử lý cập nhật công việc
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CongViec job)
        {
            if (id != job.MaCV) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // Xóa công việc
        public IActionResult Delete(int id)
        {
            var job = _context.CongViecs.FirstOrDefault(j => j.MaCV == id);
            if (job == null) return NotFound();
            return View(job);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = _context.CongViecs.FirstOrDefault(j => j.MaCV == id);
            if (job == null) return NotFound();

            _context.CongViecs.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
