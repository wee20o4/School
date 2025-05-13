using System.ComponentModel.DataAnnotations;

namespace banhang.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required, MinLength(7, ErrorMessage = "Yêu cầu nhập tên danh mục sản phẩm")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime CreatedAtCategory { get; set; }=DateTime.Now;
    }
}
