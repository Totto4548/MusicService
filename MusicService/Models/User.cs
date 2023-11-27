using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MusicService.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Введите фамилию")]
        [Display(Name = "Фамилия")]
        public int LastName { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public int FirstName { get; set; }

        [Required(ErrorMessage = "Введите отчетво")]
        [Display(Name = "Отчество")]
        public int Patronymic { get; set; }


    }
}
