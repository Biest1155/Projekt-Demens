using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models
{
    public class Stat
    {
        public long Id { get; set; }
        public long PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public string ExerciseName { get; set; }
        public int result { get; set; }
    }
}
