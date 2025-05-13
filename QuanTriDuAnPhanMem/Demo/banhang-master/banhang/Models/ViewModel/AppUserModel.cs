using Microsoft.AspNetCore.Identity;

namespace banhang.Models.ViewModel
{
    public class AppUserModel:IdentityUser
    {
        public string Occupation { get; set; } = "User";
        public string FullName { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Gender { get; set; }
        public string? ProfileImage { get; set; }
    }
}
