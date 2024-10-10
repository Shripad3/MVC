using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class LoginViewModel
    {
        [StringLength(20, MinimumLength = 5, ErrorMessage = "UserName exceeded 20 characters.")]
        [Required(ErrorMessage = "UserName or Email required.")]
        [DisplayName("UserName or Email")]
        public string UserNameOrEmail { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password exceeded 20 characters.")]
        [DataType(DataType.Password)]
        //[DataType(DataType.Password)] since entity class is not directly being used by view.
        [Required(ErrorMessage = "Password required.")]
        public string Password { get; set; }
    }
}
