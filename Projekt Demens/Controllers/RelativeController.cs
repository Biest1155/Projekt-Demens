using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt_Demens.Models;

namespace Projekt_Demens.Controllers
{
    public class RelativeController : Controller
    {
        private readonly DataContext _db;

        public RelativeController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tips()
        {
            var tips = _db.GetRelativeTips();
            return View(tips);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Stats()
        {
            var patient = _db.Patients.FirstOrDefault(x => x.Name == x.Name);
            var stats = _db.Stats.Where(x => x.PatientId == patient.Id).OrderByDescending(x => x.Date);
            ViewBag.PatientName = patient.Name;
            return View(stats);
        }
    }
}