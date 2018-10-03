using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projekt_Demens.Models
{
    public class News
    {
        public long Id { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Må max være 100 tegn og min. 3 ")]
        public string HeadLine { get; set; }
        public DateTime Posted { get; set; }

    }
}
