using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class LoginUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz!."), StringLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz!."),DataType(DataType.Password),StringLength(50)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen bir Rol Seçiniz!."), DataType(DataType.Password), StringLength(50)]
        public string UserRole { get; set; }
    }
}
