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
    public class ComissaoTecnicasController : Controller
    {
        private ComissaoTecnicaDBContext db = new ComissaoTecnicaDBContext();

        // GET: ComissaoTecnicas
        public ActionResult Index()
        {
            var comissaoTecnicas = db.ComissaoTecnicas.Include(c => c.Time);
            return View(comissaoTecnicas.ToList());
        }

        // GET: ComissaoTecnicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissaoTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Create
        public ActionResult Create()
        {
            ViewBag.TimeFutebolId = new SelectList(db.TimeFutebols, "TimeFutebolId", "Nome");
            return View();
        }

        // POST: ComissaoTecnicas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Cargo,DataNascimento,TimeFutebolId")] ComissaoTecnica comissaoTecnica)
        {
            if (ModelState.IsValid)
            {
                db.ComissaoTecnicas.Add(comissaoTecnica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TimeFutebolId = new SelectList(db.TimeFutebols, "TimeFutebolId", "Nome", comissaoTecnica.TimeFutebolId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissaoTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            ViewBag.TimeFutebolId = new SelectList(db.TimeFutebols, "TimeFutebolId", "Nome", comissaoTecnica.TimeFutebolId);
            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnicas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Cargo,DataNascimento,TimeFutebolId")] ComissaoTecnica comissaoTecnica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comissaoTecnica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TimeFutebolId = new SelectList(db.TimeFutebols, "TimeFutebolId", "Nome", comissaoTecnica.TimeFutebolId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComissaoTecnica comissaoTecnica = db.ComissaoTecnicas.Find(id);
            if (comissaoTecnica == null)
            {
                return HttpNotFound();
            }
            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComissaoTecnica comissaoTecnica = db.ComissaoTecnicas.Find(id);
            db.ComissaoTecnicas.Remove(comissaoTecnica);
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
