using System.ComponentModel.DataAnnotations;

namespace Гостевая_книга_Guest_Book.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина логина должна быть от 3 до 25 символов")]
        [Display(Name = "Логин:")]
        public string? Login { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Длина пароля должна быть от 3 до 20 символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль:")]
        public string? Password { get; set; }
    }
}
