using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Journalist.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Логин")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Пароль")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [DisplayName("Уровень доступа")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string AcessLevel { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public bool EmailVerefied { get; set; }

        public Entry Entry { get; set; }
    }
}