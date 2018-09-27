using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt_Demens.Models;

namespace Projekt_Demens.Controllers
{
    public class HomeController : Controller
    {
        public List<ChatMessage> AllMessages = new List<ChatMessage>()
        {
            new ChatMessage()
            {
                Id = 1, PatientId = 1, Content = "Jeg har fået problemer med at huske alfabetet", Posted = DateTime.Now,
                TerapeutId = 1, TerapeutIsAuthor = false
            },
            new ChatMessage()
            {
                Id = 2, PatientId = 1, TerapeutId = 1, Content = "Har du lavet øvelserne", TerapeutIsAuthor = true, Posted = DateTime.Now
            },

            new ChatMessage()
            {
                Id = 3, PatientId = 1, TerapeutId = 1, Content = "Nej", TerapeutIsAuthor = false, Posted = DateTime.Now
            },
            new ChatMessage()
            {
                Id=4, PatientId = 2, TerapeutId = 1, Content = "Jeg glemte koden til Dakortet idag", TerapeutIsAuthor = false, Posted = DateTime.Now
            }
            
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StartPage()
        {
            return View();
        }
    }
}
