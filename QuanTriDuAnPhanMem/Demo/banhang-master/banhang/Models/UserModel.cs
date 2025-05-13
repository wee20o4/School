using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace banhang.Models
{
    public class UserModel
    {
        public string? Id { get; set; }
        [Required(ErrorMessage ="Hãy nhập tên tài khoản")]
        public string Username { get; set; }
        [Required]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Hãy nhập email"),EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password),Required(ErrorMessage ="Hãy nhập mật khẩu")]
        public string Password { get; set; } 
        public string Role { get; set; }

        public bool RememberMe { get; set; } // 🆕 Thêm "Remember Me"

        // Địa chỉ
        [Required(ErrorMessage = "Vui lòng chọn tỉnh/thành phố")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn quận/huyện")]
        public string District { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn phường/xã")]
        public string Ward { get; set; }
        [Required]
        public string Gender { get; set; }
        public string? ProfileImage { get; set; }  // 🆕 Thêm dòng này
        [NotMapped]
        public IFormFile? ProfileImageFile { get; set; } // Bỏ `[Required]` nếu không cần bắt buộc
    }
}
