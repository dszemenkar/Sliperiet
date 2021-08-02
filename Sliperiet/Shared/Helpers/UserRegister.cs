using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliperiet.Shared.Helpers
{
    public class UserRegister
    {
        [Required, EmailAddress, Display(Name = "Epost")]
        public string Email { get; set; }
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(Name = "Lösenord"), Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [Display(Name = "Bekräfta lösenord"), Compare("Password", ErrorMessage = "Lösenorden stämmer inte överens.")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Födelsedag")]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Display(Name = "Allmänna villkor"), Range(typeof(bool), "true", "true", ErrorMessage = "Godkänn villkor.")]
        public bool IsConfirmed { get; set; } = true;
    }
}
