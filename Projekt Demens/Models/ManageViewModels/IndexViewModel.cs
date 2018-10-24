using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models.ManageViewModels
{
    public class IndexViewModel
    {
        [Display(Name = "Brugernavn")]
        public string Username { get; set; }

        [Display(Name = "Fornavn")]
        public string Firstname { get; set; }

        [Display(Name = "Efternavn")]
        public string Lastname { get; set; }


        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail adresse")]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Telefonnummer")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
