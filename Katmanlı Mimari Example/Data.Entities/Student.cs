using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Student")]
    public class Student:Base
    {
        [Required(ErrorMessage ="Lütfen bir ad soyad giriniz!."),
            StringLength(50,ErrorMessage ="Öğrenci Adı max 50 karakter olabilir.")]
        public string Name { get; set; }
    }
}
