using System;
using System.ComponentModel.DataAnnotations;

namespace banhang.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }


        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [MinLength(3, ErrorMessage = "Tên sản phẩm phải có ít nhất 3 ký tự")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Mô tả sản phẩm không được để trống")]
        [MinLength(10, ErrorMessage = "Mô tả sản phẩm phải có ít nhất 10 ký tự")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Tồn kho không được để trống")]
        [Range(0, int.MaxValue, ErrorMessage = "Tồn kho phải lớn hơn hoặc bằng 0")]
        public int Stock { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedAtProduct { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
