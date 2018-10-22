using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models.AccountViewModels
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} skal være mindst {2} og max {1} tegn lang.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Ny Adgangskode")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekræft adgangskode")]
        [Compare("Password", ErrorMessage = "Den nye adgangskode og den bekræftede adgangskode matcher ikke.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
