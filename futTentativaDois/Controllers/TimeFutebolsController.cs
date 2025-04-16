using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using futTentativaDois.Models;

namespace futTentativaDois.Controllers
{
    public class TimeFutebolsController : Controller
    {
        private TimeFutebolDBContext db = new TimeFutebolDBContext();

        // GET: TimeFutebols
        public ActionResult Index()
        {
            return View(db.TimeFutebols.ToList());
        }

        // GET: TimeFutebols/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeFutebol timeFutebol = db.TimeFutebols.Find(id);
            if (timeFutebol == null)
            {
                return HttpNotFound();
            }
            return View(timeFutebol);
        }

        // GET: TimeFutebols/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeFutebols/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TimeFutebolId,Nome,Cidade,Estado,AnoFundacao,Estadio,CapacidadeEstadio,CorPrimaria,CorSecundaria,Status")] TimeFutebol timeFutebol)
        {
            if (ModelState.IsValid)
            {
                db.TimeFutebols.Add(timeFutebol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timeFutebol);
        }

        // GET: TimeFutebols/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeFutebol timeFutebol = db.TimeFutebols.Find(id);
            if (timeFutebol == null)
            {
                return HttpNotFound();
            }
            return View(timeFutebol);
        }

        // POST: TimeFutebols/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TimeFutebolId,Nome,Cidade,Estado,AnoFundacao,Estadio,CapacidadeEstadio,CorPrimaria,CorSecundaria,Status")] TimeFutebol timeFutebol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeFutebol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timeFutebol);
        }

        // GET: TimeFutebols/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeFutebol timeFutebol = db.TimeFutebols.Find(id);
            if (timeFutebol == null)
            {
                return HttpNotFound();
            }
            return View(timeFutebol);
        }

        // POST: TimeFutebols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeFutebol timeFutebol = db.TimeFutebols.Find(id);
            db.TimeFutebols.Remove(timeFutebol);
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
