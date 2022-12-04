using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Journalist.Models.Domain;

namespace Journalist.Models
{
    public class Entry
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Авторы")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string Authors { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("???")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string Post { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Место работы")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string WorkPlace { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Тема")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string ThemeOfWork { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Заголовок")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string WorkHeader { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        [DisplayName("Анотация")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string Annotation { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Путь")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public string Path2Content { get; set; }

        [DisplayName("Тип заявки")]
        [Required(ErrorMessage ="Это поле обязательное")]
        public bool Type { get; set; }

        public List <Mark> Marks { get; set; } = new List<Mark>();
    }
}