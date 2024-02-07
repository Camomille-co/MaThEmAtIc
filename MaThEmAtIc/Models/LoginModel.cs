using System.ComponentModel.DataAnnotations;

namespace MaThEmAtIc.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string? Result {  get; set; }
    }
}
