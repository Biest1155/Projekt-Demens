using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Demens.Models
{
    public class ChatMessage
    {
        public long Id { get; set; }
        public bool TerapeutIsAuthor { get; set; }
        public long TerapeutId { get; set; }
        public long PatientId { get; set; }
        public string Content { get; set; }
        public DateTime Posted { get; set; }
       

        //Når jeg går ind på chatsiden skal jeg bruge navnene på patienterne, ikke bare Id'et.
        //Denne information skal hentes fra en anden klasse.
        //Patient og terapeut-navnene kan jeg lægge i ViewBag. 
    }
}
