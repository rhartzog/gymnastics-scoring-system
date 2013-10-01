using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GSS.UI.Core.Entities;
using Microsoft.Ajax.Utilities;
using Raven.Client;
using Raven.Client.Document;

namespace GSS.UI.Controllers
{
    public class MeetsController : Controller
    {
        private IDocumentStore _documentStore;

        public MeetsController(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        //
        // GET: /Meets/

        public ActionResult Index()
        {
            List<Meet> meets;
            using (var session = _documentStore.OpenSession())
            {
                meets = session.Query<Meet>()
                    .Where(x => x.StartDate >= DateTime.Now)
                    .ToList();
            }

            return View(meets);
        }

        [HttpGet]
        public ActionResult AddMeet()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMeet(Meet input)
        {
            var meet = new Meet
            {
                Name = input.Name,
                StartDate = input.StartDate,
                EndDate = input.StartDate.AddDays(2)
            };

            using (var session = _documentStore.OpenSession())
            {
                session.Store(meet);
                session.SaveChanges();
            }

            return RedirectToAction("Index", "Meets");
        }

        public ActionResult MeetDetails(string id)
        {
            Meet meet;
            using (var session = _documentStore.OpenSession())
            {
                meet = session.Load<Meet>(id);
            }
            

            return View(meet);
        }

        public ActionResult AddGymnast(string meetId)
        {
            throw new NotImplementedException();
        }
    }
}
