using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using banhang.Models;
using banhang.Repository;
using banhang.Models.ViewModel;
using static banhang.Models.tinhthanh.ProvinceModel;

namespace banhang.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUserModel> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly DataContext _context;

        public AdminController(UserManager<AppUserModel> userManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment webHostEnvironment, DataContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        private List<Province> LoadProvinces()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/vietnamAddress.json");
            var json = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Province>>(json);
        }

        public IActionResult AddAcc()
        {
            ViewBag.Provinces = new SelectList(LoadProvinces(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAcc(UserModel model, IFormFile ProfileImageFile)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Provinces = new SelectList(LoadProvinces(), "Id", "Name");
                return View(model);
            }

            string imagePath = null;
            if (ProfileImageFile != null)
            {
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
                var fileExtension = Path.GetExtension(ProfileImageFile.FileName).ToLower();

                if (!allowedExtensions.Contains(fileExtension))
                {
                    ModelState.AddModelError("ProfileImageFile", "Chỉ chấp nhận .jpg, .jpeg, .png.");
                    ViewBag.Provinces = new SelectList(LoadProvinces(), "Id", "Name");
                    return View(model);
                }

                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                Directory.CreateDirectory(uploadsFolder);
                string uniqueFileName = Guid.NewGuid().ToString() + fileExtension;
                imagePath = Path.Combine("uploads", uniqueFileName);

                using (var fileStream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, imagePath), FileMode.Create))
                {
                    await ProfileImageFile.CopyToAsync(fileStream);
                }
            }

            var user = new AppUserModel
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.FullName,
                Province = model.Province,
                District = model.District,
                Ward = model.Ward,
                Gender = model.Gender,
                ProfileImage = imagePath
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, model.Role);
                return RedirectToAction("ListAcc");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            ViewBag.Provinces = new SelectList(LoadProvinces(), "Id", "Name");
            return View(model);
        }

        public async Task<IActionResult> ListAcc()
        {
            var users = await _userManager.Users.ToListAsync();
            var userList = users.Select(user => new UserModel
            {
                Id = user.Id,
                Username = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                Role = _userManager.GetRolesAsync(user).Result.FirstOrDefault(),
                Province = user.Province,
                District = user.District,
                Ward = user.Ward,
                Gender = user.Gender,
                ProfileImage = user.ProfileImage
            }).ToList();

            return View(userList);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var model = new UserModel
            {
                Id = user.Id,
                Username = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault(),
                Province = user.Province,
                District = user.District,
                Ward = user.Ward,
                Gender = user.Gender,
                ProfileImage = user.ProfileImage
            };

            ViewBag.Provinces = new SelectList(LoadProvinces(), "Id", "Name");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserModel model, IFormFile ProfileImageFile)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null) return NotFound();

            if (ProfileImageFile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                Directory.CreateDirectory(uploadsFolder);
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(ProfileImageFile.FileName);
                string newImagePath = Path.Combine("uploads", uniqueFileName);

                using (var fileStream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, newImagePath), FileMode.Create))
                {
                    await ProfileImageFile.CopyToAsync(fileStream);
                }

                if (!string.IsNullOrEmpty(user.ProfileImage))
                {
                    string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, user.ProfileImage);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                user.ProfileImage = newImagePath;
            }

            user.FullName = model.FullName;
            user.Province = model.Province;
            user.District = model.District;
            user.Ward = model.Ward;
            user.Gender = model.Gender;
            user.Email = model.Email;

            await _userManager.UpdateAsync(user);
            return RedirectToAction("ListAcc");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!string.IsNullOrEmpty(user.ProfileImage))
            {
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, user.ProfileImage);
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            await _userManager.DeleteAsync(user);
            return RedirectToAction("ListAcc");
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

    }
}
