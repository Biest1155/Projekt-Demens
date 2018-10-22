using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models.ManageViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nuværende adgangskode")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Den {0} skal være mindst {2} og max {1} tegn lang.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Ny adgangskode")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekræft ny adgangskode")]
        [Compare("NewPassword", ErrorMessage = "Den nye adgangskode matcher ikke den bekræftede adgangskode.")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
