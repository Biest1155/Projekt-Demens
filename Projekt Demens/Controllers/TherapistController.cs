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
        private readonly DataContext _db;

        public TherapistController(DataContext db)
        {
            _db = db;
        }
        public List<ChatMessage>AllMessages { get; set; } = new List<ChatMessage>()
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
            ViewBag.PatientId = id;
            return View(MessageByPatient);
        }

        [HttpPost]
        public IActionResult Index(int id, string message)
        {
            DateTime _now = DateTime.Now;
            ChatMessage _newMessage = new ChatMessage()
            {
              PatientId=id,
                Posted=_now,
                Content=message,
                TerapeutId=1,
                TerapeutIsAuthor=true

            };

            AllMessages.Add(_newMessage);
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
            ViewBag.PatientId = id;

            return View(MessageByPatient);
        }

        public IActionResult News()
        {
            return View(_db.News.ToArray());
        }

        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNews(News _news)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            _news.Posted=DateTime.Now;
            _db.Add(_news);
            _db.SaveChanges();
           
           
            return RedirectToAction("News", "Therapist");
        }

        public IActionResult Tips()
        {
            var tips = _db.GetPatientTips();
            tips.AddRange(_db.GetRelativeTips());
            return View(tips);
        }

        public IActionResult EditTip(int id)
        {
            var tip = _db.Tips.FirstOrDefault(x => x.Id == id);
            return View(tip);
        }

        public IActionResult NewsTestData()
        {
            var news = new News
            {
                HeadLine = "Article 1",
                Posted = DateTime.Now
            };
            _db.Add(news);
            news = new News
            {
                HeadLine = "Article 2",
                Posted = DateTime.Now
            };
            _db.Add(news);
            _db.SaveChanges();

            return RedirectToAction("News");

        }
    }
}