using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace banhang.Models.ViewModel
{
    public class ProfileManagementViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [ValidateNever] // Không bắt buộc nhập
        [DataType(DataType.Password)]
        public string? OldPassword { get; set; }

        [ValidateNever]
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }

        [ValidateNever]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Xác nhận mật khẩu không khớp.")]
        public string? ConfirmPassword { get; set; }
    }
}
