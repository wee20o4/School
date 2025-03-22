using System.ComponentModel.DataAnnotations;

namespace JOBBVU.Models
{
    public class User
    {
        [Key] // Khóa chính
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; } // Lưu hash password

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
