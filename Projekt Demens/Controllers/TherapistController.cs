using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt_Demens.Models;

namespace Projekt_Demens.Controllers
{
    public class TherapistController : Controller
    {
        public List<ChatMessage> AllMessages = new List<ChatMessage>()
        {
            new ChatMessage()
            {
                Id = 1, PatientId = 1, Content = "Jeg har fået problemer med at huske alfabetet", Posted = new DateTime(2017,05,20),
                TerapeutId = 1, TerapeutIsAuthor = false
            },
            new ChatMessage()
            {
                Id = 2, PatientId = 1, TerapeutId = 1, Content = "Har du lavet øvelserne", TerapeutIsAuthor = true, Posted = new DateTime(2017,07,04)
            },

            new ChatMessage()
            {
                Id = 3, PatientId = 1, TerapeutId = 1, Content = "Nej", TerapeutIsAuthor = false, Posted = new DateTime(2017,08,14)
            },
            new ChatMessage()
            {
                Id=4, PatientId = 2, TerapeutId = 1, Content = "Jeg glemte koden til Dankortet idag", TerapeutIsAuthor = false, Posted = new DateTime(2018,01,04)
            },
            new ChatMessage()
            {
                Id = 5, PatientId = 3, Content = "Jeg vil anbefale at du diskuterer øvelsen imorgen med din mand", TerapeutIsAuthor = true, TerapeutId = 1, Posted = new DateTime(2018,02,14)
            }

        };
        public IActionResult Index(int id=1)
        {
            List<ChatMessage> MessageByPatient = new List<ChatMessage>();
            foreach (var i in AllMessages)
            {
                if (i.PatientId == id)
                {
                    MessageByPatient.Add(i);
                }
            }

            ViewBag.TherapistName = "Therapist nr.1";
            ViewBag.PatientName = "Patient nr." + id.ToString();
            return View(MessageByPatient);
        }

        public IActionResult News()
        {
            return View();
        }
    }
}