using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public bool TerapeutIsAuthor { get; set; }
        public int TerapeutId { get; set; }
        public int PatientId { get; set; }
        public string Content { get; set; }
        public DateTime Posted { get; set; }
       

        //Når jeg går ind på chatsiden skal jeg bruge navnene på patienterne, ikke bare Id'et.
        //Denne information skal hentes fra en anden klasse.
    }
}
