using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using banhang.Models;  // Import model Supplier
using static banhang.Models.tinhthanh.ProvinceModel;
using banhang.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace banhang.Controllers
{

    public class SuppliersController : Controller
    {

        private readonly DataContext _context;

        public SuppliersController(DataContext context)
        {
            _context = context;
        }
        private List<Province> LoadProvinces()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/vietnamAddress.json");
            var json = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Province>>(json);
        }

        // Hiển thị danh sách nhà cung cấp
        [Authorize]
        [Authorize]
        public IActionResult Index(int page = 1, string search = "")
        {
            int pageSize = 5; // Số lượng nhà cung cấp trên mỗi trang

            var provinces = LoadProvinces();
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name");

            // Lấy danh sách nhà cung cấp từ DB và lọc theo từ khóa tìm kiếm
            var suppliersQuery = _context.Suppliers.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                suppliersQuery = suppliersQuery.Where(s => s.SupplierName.Contains(search) || s.Email.Contains(search));
            }

            int totalSuppliers = suppliersQuery.Count();
            var suppliers = suppliersQuery.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            // Ánh xạ ID -> Tên cho từng nhà cung cấp
            foreach (var supplier in suppliers)
            {
                supplier.Province = provinces.FirstOrDefault(p => p.Id == supplier.Province)?.Name ?? "N/A";
                supplier.District = provinces.SelectMany(p => p.Districts)
                                             .FirstOrDefault(d => d.Id == supplier.District)?.Name ?? "N/A";
                supplier.Ward = provinces.SelectMany(p => p.Districts)
                                         .SelectMany(d => d.Wards)
                                         .FirstOrDefault(w => w.Id == supplier.Ward)?.Name ?? "N/A";
            }

            ViewBag.TotalPages = (int)Math.Ceiling((double)totalSuppliers / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.Search = search;

            return View(suppliers);
        }

        [HttpGet]
        public IActionResult Search(string search, int page = 1)
        {
            int pageSize = 5;

            var suppliersQuery = _context.Suppliers.AsQueryable();

            // Tìm kiếm theo tên hoặc email nhà cung cấp
            if (!string.IsNullOrEmpty(search))
            {
                suppliersQuery = suppliersQuery.Where(s => s.SupplierName.Contains(search) || s.Email.Contains(search));
            }

            int totalSuppliers = suppliersQuery.Count();
            var suppliers = suppliersQuery.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            // Trả về JSON để cập nhật bảng dữ liệu bằng AJAX
            return Json(new
            {
                suppliers = suppliers,
                totalPages = (int)Math.Ceiling((double)totalSuppliers / pageSize),
                currentPage = page
            });
        }

        // 🟢 Hiển thị form thêm nhà cung cấp
        [Authorize(Roles = "Admin")]
        public IActionResult AddSuppliers()
        {
            var provinces = LoadProvinces();
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name");

            return View();
        }

        // 🟢 Xử lý khi người dùng submit form thêm nhà cung cấp
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddSuppliers(Supplier model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                Console.WriteLine(string.Join("\n", errors)); // In lỗi ra console
            }

            if (ModelState.IsValid)
            {
                _context.Suppliers.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            var provinces = LoadProvinces();
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name");

            return View(model);
        }

        [HttpGet]
        public JsonResult GetDistricts(string provinceId)
        {
            var provinces = LoadProvinces();
            var districts = provinces.FirstOrDefault(p => p.Id == provinceId)?.Districts;

            return Json(districts ?? new List<District>());
        }

        [HttpGet]
        public JsonResult GetWards(string districtId)
        {
            var provinces = LoadProvinces();
            var districts = provinces.SelectMany(p => p.Districts);
            var wards = districts.FirstOrDefault(d => d.Id == districtId)?.Wards;

            return Json(wards ?? new List<Ward>());
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Detail(int id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(s => s.SupplierId == id);
            if (supplier == null)
            {
                return NotFound();
            }

            // Lấy danh sách địa phương từ file JSON
            var provinces = LoadProvinces();

            // Tìm tên tỉnh/thành
            var province = provinces.FirstOrDefault(p => p.Id == supplier.Province);
            ViewBag.ProvinceName = province?.Name ?? "N/A";

            // Tìm tên quận/huyện
            var district = province?.Districts.FirstOrDefault(d => d.Id == supplier.District);
            ViewBag.DistrictName = district?.Name ?? "N/A";

            // Tìm tên phường/xã
            var ward = district?.Wards.FirstOrDefault(w => w.Id == supplier.Ward);
            ViewBag.WardName = ward?.Name ?? "N/A";

            // Lấy danh sách đơn hàng của nhà cung cấp
            var purchaseOrders = _context.PurchaseOrders
                .Where(po => po.SupplierId == id)
                .Include(po => po.PurchaseOrderDetails)
                .ThenInclude(pod => pod.Product) // Lấy thông tin sản phẩm
                .ToList();

            // Tính tổng tiền của tất cả đơn hàng
            decimal totalAmount = purchaseOrders
                .Sum(po => po.PurchaseOrderDetails.Sum(pod => (pod.Product != null ? pod.Product.Price : 0) * pod.Quantity));

            ViewBag.TotalAmount = totalAmount;
            ViewBag.PurchaseOrders = purchaseOrders;

            return View(supplier);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(s => s.SupplierId == id);
            if (supplier == null)
            {
                return NotFound();
            }

            var provinces = LoadProvinces();
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name", supplier.Province ?? "");

            var districts = new List<District>();
            var wards = new List<Ward>();

            if (!string.IsNullOrEmpty(supplier.Province))
            {
                var selectedProvince = provinces.FirstOrDefault(p => p.Id == supplier.Province);
                districts = selectedProvince?.Districts ?? new List<District>();
            }

            if (!string.IsNullOrEmpty(supplier.District))
            {
                var selectedDistrict = districts.FirstOrDefault(d => d.Id == supplier.District);
                wards = selectedDistrict?.Wards ?? new List<Ward>();
            }

            ViewBag.Districts = new SelectList(districts, "Id", "Name", supplier.District ?? "");
            ViewBag.Wards = new SelectList(wards, "Id", "Name", supplier.Ward ?? "");

            return View(supplier);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Supplier model)
        {
            if (id != model.SupplierId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Có lỗi xảy ra khi cập nhật: " + ex.Message);
                }
            }

            var provinces = LoadProvinces();
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name", model.Province ?? "");

            var districts = new List<District>();
            var wards = new List<Ward>();

            if (!string.IsNullOrEmpty(model.Province))
            {
                var selectedProvince = provinces.FirstOrDefault(p => p.Id == model.Province);
                districts = selectedProvince?.Districts ?? new List<District>();
            }

            if (!string.IsNullOrEmpty(model.District))
            {
                var selectedDistrict = districts.FirstOrDefault(d => d.Id == model.District);
                wards = selectedDistrict?.Wards ?? new List<Ward>();
            }

            ViewBag.Districts = new SelectList(districts, "Id", "Name", model.District ?? "");
            ViewBag.Wards = new SelectList(wards, "Id", "Name", model.Ward ?? "");

            return View(model);
        }

    }
}
