using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StepAspNet.Models;

namespace StepAspNet.Controllers
{
    public class AdminController : Controller
    {
        private QuestContext db = new QuestContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.QuestList.ToList());
        }

        // GET: Admin/Details/5
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

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Duration,TeamNum,PlayerAge,Address,Phone,Email,Company,Raiting,FearLevel,DifficultyLevel,LogoImg")] Quest quest)
        {
            if (ModelState.IsValid)
            {
                db.QuestList.Add(quest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quest);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Admin/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Duration,TeamNum,PlayerAge,Address,Phone,Email,Company,Raiting,FearLevel,DifficultyLevel,LogoImg")] Quest quest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quest);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quest quest = db.QuestList.Find(id);
            db.QuestList.Remove(quest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
