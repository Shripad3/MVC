using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Enities
{
    [Index(nameof(Email),IsUnique =true)]
    [Index(nameof(UserName),IsUnique =true)]
    public class UserAccount
    {
        [Required(ErrorMessage ="FirstName required.")]
        [MaxLength(50,ErrorMessage ="FirstName exceeded 50 characters.")]
        public string FirstName { get; set; }
        [MaxLength(50, ErrorMessage = "LastName exceeded 50 characters.")]
        [Required(ErrorMessage = "LastName required.")]
        
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
        [MaxLength(100, ErrorMessage = "Email exceeded 100 characters.")]
        //[DataType(DataType.EmailAddress)] since entity class is not directly being used by view.
        [Required(ErrorMessage = "Email required.")]
        public string Email { get; set; }
        [MaxLength(20, ErrorMessage = "UserName exceeded 20 characters.")]
        [Required(ErrorMessage = "UserName required.")]
        [Key]
        public string UserName {  get; set; }
        [MaxLength(20, ErrorMessage = "Password exceeded 20 characters.")]
        //[DataType(DataType.Password)] since entity class is not directly being used by view.
        [Required(ErrorMessage = "Password required.")]
        public string Password { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Skills { get; set; }
    }
}
