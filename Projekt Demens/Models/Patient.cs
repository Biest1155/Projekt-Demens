using System.Collections;
using System.Collections.Generic;

namespace Projekt_Demens.Models
{
    public class Patient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CPR { get; set; }
        public List<Stat> Stats { get; set; }
    }
}