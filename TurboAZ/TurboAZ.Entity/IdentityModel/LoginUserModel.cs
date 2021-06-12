using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.IdentityModel
{
    public class LoginUserModel
    {
        [Required(ErrorMessage ="Telefon nömrəsini daxil edin")]
        [Phone(ErrorMessage ="Telefon nömrəsini düzgün daxil edin")]
        public string PhoneNumber { get; set; }
    }
}
