using System.Data;

namespace MaThEmAtIc.Models
{
    public class RegisterModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string RoleId { get; set; }

        public Role Role { get; set; }
    }
}
