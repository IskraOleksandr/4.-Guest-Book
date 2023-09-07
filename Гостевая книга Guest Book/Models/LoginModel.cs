using System.ComponentModel.DataAnnotations;

namespace Гостевая_книга_Guest_Book.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Логин:")]
        public string? Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль:")]
        public string? Password { get; set; }
    }
}
