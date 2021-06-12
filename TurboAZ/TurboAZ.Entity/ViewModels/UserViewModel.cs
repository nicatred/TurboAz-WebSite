using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Entity.ViewModels
{
  public class UserViewModel
    {
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public string Name { get; set; }
    }
}
