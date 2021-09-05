using System.ComponentModel.DataAnnotations;

namespace SoulMate.Shared.UserModule
{
    public class LoginDto
    {
        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "密码")]
        public string Password { get; set; }
    }
}
