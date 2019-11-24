using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "The password length must not be less than 4")]
        public string Password { get; set; }
    }

}