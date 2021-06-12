using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.IdentityModel
{
   public class AdminLoginModelView
    {
        [Required(ErrorMessage = "Elektron poçt daxil edin")]
        [EmailAddress(ErrorMessage ="Düzgün elektron poçt daxil edin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifrə daxil edin")]
        [MinLength(6,ErrorMessage ="Şifrə 6 simvoldan kiçik ola bilməz")]

        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}
