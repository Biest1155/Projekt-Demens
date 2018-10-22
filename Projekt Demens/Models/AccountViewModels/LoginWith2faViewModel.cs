using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models.AccountViewModels
{
    public class LoginWith2faViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "{0} skal være mindst {2} og max {1} tegn lang.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Godkendelseskode")]
        public string TwoFactorCode { get; set; }

        [Display(Name = "Husk denne maskine")]
        public bool RememberMachine { get; set; }

        public bool RememberMe { get; set; }
    }
}
