using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using banhang.Models;
using static banhang.Models.tinhthanh.ProvinceModel;

public class LocationController : Controller
{
    private readonly IWebHostEnvironment _env;

    public LocationController(IWebHostEnvironment env)
    {
        _env = env;
    }

    private async Task<List<Province>> LoadProvinces()
    {
        var filePath = Path.Combine(_env.WebRootPath, "data/tinhthanh.json");

        if (System.IO.File.Exists(filePath))
        {
            var json = await System.IO.File.ReadAllTextAsync(filePath);
            return JsonConvert.DeserializeObject<List<Province>>(json);
        }

        return new List<Province>();
    }

    [HttpGet]
    public async Task<IActionResult> GetProvinces()
    {
        var provinces = await LoadProvinces();
        return Json(provinces);
    }

    [HttpGet]
    public async Task<IActionResult> GetDistricts(string provinceId)
    {
        var provinces = await LoadProvinces();
        var province = provinces.Find(p => p.Id == provinceId);

        return Json(province?.Districts ?? new List<District>());
    }

    [HttpGet]
    public async Task<IActionResult> GetWards(string districtId)
    {
        var provinces = await LoadProvinces();
        foreach (var province in provinces)
        {
            var district = province.Districts.Find(d => d.Id == districtId);
            if (district != null)
            {
                return Json(district.Wards);
            }
        }

        return Json(new List<Ward>());
    }
}
