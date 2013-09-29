using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymnasticsScoringSystem.Core.Entities;
using Raven.Client.Document;

namespace GymnasticsScoringSystem.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            var meets = _repository<Meet>.Execute();

            return View(meets);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
