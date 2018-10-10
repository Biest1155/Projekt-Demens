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
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Stats()
        {
            return View();
        }
    }
}