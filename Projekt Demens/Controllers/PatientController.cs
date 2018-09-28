using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt_Demens.Models;

namespace Projekt_Demens.Controllers
{
    public class PatientController : Controller
    {
        private readonly TipDataContext _db;

        public PatientController(TipDataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tips()
        {
            var tips = _db.GetPatientTips();
            return View(tips);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Stats()
        {
            return View();
        }

        public IActionResult TipsTestData()
        {
            if(_db.GetPatientTips().Count == 0)
            {
                var tip = new Tip
                {
                    Title = "Mad",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean lobortis ex sit amet auctor vestibulum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut quis leo porttitor, luctus sapien ut, lacinia purus. Mauris vulputate metus sed bibendum semper. Mauris tincidunt non lacus in venenatis. Sed gravida magna nec mollis pulvinar. Nam dapibus consectetur nunc, eu vehicula velit tincidunt vel. Phasellus auctor ligula eu mi vehicula, nec scelerisque nisi commodo. Pellentesque tempor volutpat justo at faucibus. Duis non est sit amet lectus pretium feugiat a et mauris. Nulla rhoncus faucibus pellentesque. Maecenas quis nisi interdum, dapibus nulla in, suscipit urna. In ac urna non ex aliquam egestas. Aliquam ligula libero, sollicitudin efficitur fringilla ac, malesuada nec ipsum. In fermentum risus ac facilisis porttitor. Proin pellentesque faucibus viverra. Sed rhoncus, dolor maximus tincidunt luctus, metus elit facilisis nisi, vitae tincidunt risus leo ut odio. Sed at purus urna. Fusce vel aliquet lacus. In varius ex at nisi varius, eget eleifend sem rutrum. Sed interdum eu tellus commodo rutrum. Proin suscipit fermentum lacus, ac commodo orci sollicitudin eu. Fusce lobortis ac libero ac sagittis. Aliquam nec nisi sit amet augue dignissim lacinia. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam leo lectus, feugiat cursus laoreet ac, congue molestie libero.",
                    Type = Tip.TipType.patient
                };
                _db.Tips.Add(tip);
                tip = new Tip
                {
                    Title = "Øvelse",
                    Body = "Fusce facilisis velit vel cursus tincidunt. Ut porta sodales felis sit amet finibus. Quisque efficitur condimentum sapien non vehicula. Cras fringilla enim ac nibh congue elementum. Pellentesque et purus eros. Quisque neque ante, pretium ac vehicula at, suscipit sit amet leo. Aliquam dui sem, hendrerit sed maximus lacinia, tempor ac metus. Nullam nibh nunc, venenatis at laoreet vel, pretium et ligula. Mauris pharetra nisi ac tellus facilisis, et porta leo molestie. Maecenas posuere velit nibh, vel mollis nunc facilisis quis. Integer pulvinar purus in leo rhoncus pharetra. Donec consectetur in neque eu auctor. Nam ultricies dictum nibh, vel ultrices nisl accumsan at. Ut vestibulum placerat vulputate. Ut placerat convallis dictum. Mauris dignissim, tellus et dictum scelerisque, ipsum eros elementum felis, ut porttitor neque nisi vel nibh. In malesuada tempus dui, at imperdiet nulla. Nulla facilisi. Suspendisse efficitur mauris nec quam ultrices sodales. Phasellus posuere maximus odio, a hendrerit ante varius vitae. Sed eget tortor nec ante congue hendrerit. Suspendisse id imperdiet lacus. Praesent eu neque euismod, ultrices lacus a, ullamcorper nibh. Praesent blandit, arcu vitae suscipit viverra, nunc augue faucibus diam, quis rhoncus dolor felis non arcu. Quisque luctus molestie nulla, eget faucibus felis tempus sit amet. Donec et massa facilisis, interdum magna in, elementum felis. Proin rutrum erat metus, nec maximus nisl mollis id.",
                    Type = Tip.TipType.patient
                };
                _db.Tips.Add(tip);
                _db.SaveChanges();
            }

            return RedirectToAction("Tips");
        }
    }
}