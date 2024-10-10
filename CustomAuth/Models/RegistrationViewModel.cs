using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "FirstName required.")]
        [MaxLength(50, ErrorMessage = "FirstName exceeded 50 characters.")]
        public string FirstName { get; set; }
        [MaxLength(50, ErrorMessage = "LastName exceeded 50 characters.")]
        [Required(ErrorMessage = "LastName required.")]
        public string LastName { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [MaxLength(100, ErrorMessage = "Email exceeded 100 characters.")]
        //[DataType(DataType.EmailAddress)] since entity class is not directly being used by view.
        [Required(ErrorMessage = "Email required.")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Enter valid Email.")]
        
        public string Email { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "UserName should be between 5 & 20 characters.")]
        [Required(ErrorMessage = "UserName required.")]
        public string UserName { get; set; }
        [StringLength(20,MinimumLength =5, ErrorMessage = "Password should be between 5 & 20 characters.")]
        [DataType(DataType.Password)]
        //[DataType(DataType.Password)] since entity class is not directly being used by view.
        [Required(ErrorMessage = "Password required.")]
        public string Password { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password should be between 5 & 20 characters.")]
        [DataType(DataType.Password)]
        //[DataType(DataType.Password)] since entity class is not directly being used by view.
        [Required(ErrorMessage = "Password required.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="This field is required*")]
        public string Designation { get; set; }
        public string C { get; set; }
        public string Python { get; set; }
        public string Java {  get; set; }
         
    }
    
}
