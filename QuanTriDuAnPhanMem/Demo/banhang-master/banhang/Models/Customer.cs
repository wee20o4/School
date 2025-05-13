using System.ComponentModel.DataAnnotations;

namespace banhang.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required, MinLength(7, ErrorMessage = "Yêu cầu nhập tên khách hàng")]
        public string CustomerName { get; set; }
        [Required, MinLength(7, ErrorMessage = "Yêu cầu nhập email khách hàng")]
        public string? CustomerEmail { get; set; }
        [Required, MinLength(7, ErrorMessage = "Yêu cầu nhập số điện thoại khách hàng")]
        public string? CustomerPhone { get; set; }
        [Required, MinLength(7, ErrorMessage = "Yêu cầu nhập địa chỉ khách hàng")]
        public string? CustomerAddress { get; set; }
        public DateTime CreatedAtCustomer { get; set; }
    }
}
