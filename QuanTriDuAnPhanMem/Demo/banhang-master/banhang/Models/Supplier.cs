using System.ComponentModel.DataAnnotations;

namespace banhang.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Tên nhà cung cấp không được để trống")]
        [MinLength(3, ErrorMessage = "Tên nhà cung cấp phải có ít nhất 3 ký tự")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^(0[0-9]{9,10})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        public bool Status { get; set; }

        [Required(ErrorMessage = "Fax không được để trống")]
        [RegularExpression(@"^\+?[0-9]{6,15}$", ErrorMessage = "Fax không hợp lệ")]
        public string FaxNumber { get; set; }

        // Địa chỉ
        [Required(ErrorMessage = "Vui lòng chọn tỉnh/thành phố")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn quận/huyện")]
        public string District { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn phường/xã")]
        public string Ward { get; set; }
        public ICollection<PurchaseOrderDetail>? PurchaseOrderDetails { get; set; }
    }
}
