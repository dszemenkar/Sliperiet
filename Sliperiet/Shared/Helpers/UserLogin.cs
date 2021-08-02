using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliperiet.Shared.Helpers
{
    public class UserLogin
    {
        [Display(Name = "Epost"), Required]
        public string Email { get; set; }
        [Display(Name = "Lösenord"), Required]
        public string Password { get; set; }
    }
}
