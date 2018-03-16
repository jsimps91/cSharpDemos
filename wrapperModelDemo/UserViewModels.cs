using System.ComponentModel.DataAnnotations;
namespace wrapperModelDemo.Models
{
    public abstract class BaseEntity{}
    public class UserViewModels : BaseEntity
    {
        public class Reg
        {
            [Required]
            [EmailAddress] 
            public string Email {get;set;}

            [Required]
            [DataType(DataType.Password)]
            public string Password {get;set;}

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage="Password and password confirmation must match")]
            public string PasswordConfirm {get;set;}
 
        }

        public class Login : BaseEntity
        {
            [Required]
            string Email {get;set;}

            [Required]
            [DataType(DataType.Password)]
            string Password {get;set;}
        }
    }
}