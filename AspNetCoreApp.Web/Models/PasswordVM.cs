using CoreLayer.Entities;

namespace AspNetCoreApp.Web.Models
{
    public class PasswordVM
    {
        public string Email { get; set; }
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set; }

       
    }
}
