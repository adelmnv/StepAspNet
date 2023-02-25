using StepAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace StepAspNet.Controllers
{
    public class QuestController : Controller
    {
        // GET: Quest
        private QuestContext db = new QuestContext();
        public ActionResult Index()
        {
            var quests = db.QuestList.ToList();
            return View(quests);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quest quest = db.QuestList.Find(id);
            if (quest == null)
            {
                return HttpNotFound();
            }
            return View(quest);
        }

        
    }
}