using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models
{
    public class Tip
    {
        public enum TipType { patient, relative}
        public string Title { get; set; }
        public string Body { get; set; } 
        public TipType Type { get; set; }
    }
}
