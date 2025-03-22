using Microsoft.AspNetCore.Mvc;
using ASP_WEB.Models;
using System.Linq;

namespace ASP_WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("all")]
        public IActionResult GetAllProducts()
        {
            var products = ProductRepository.GetProducts();
            if (products == null || !products.Any())
            {
                return NotFound("Không có sản phẩm.");
            }

            return Ok(products.Select(p => new
            {
                p.ID,
                p.Name,
                p.Price,
                p.ImageURL,
                p.ShortDescription
            }));
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = ProductRepository.GetProductById(id);
            if (product == null)
                return NotFound("Sản phẩm không tồn tại.");

            return Ok(product);
        }
    }
}