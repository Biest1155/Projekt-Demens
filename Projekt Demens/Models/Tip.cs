using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models
{
    public class Tip
    {
        public long Id { get; set; }
        public enum TipType { patient, relative}

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Titlen skal være på mindst 3 tegn")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; } 
        [Required]
        public TipType Type { get; set; }
    }
}
