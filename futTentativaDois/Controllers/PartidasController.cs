﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using futTentativaDois.Data;
using futTentativaDois.Models;

namespace futTentativaDois.Controllers
{
    public class PartidasController : Controller
    {
        private futTentativaDoisContext db = new futTentativaDoisContext();
        private TimeFutebolDBContext dbTime = new TimeFutebolDBContext();
        

        

        // GET: Partidas
        public ActionResult Index()
        {

            

            return View(db.Partidas.ToList());
        }

        // GET: Partidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partidas.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // GET: Partidas/Create
        public ActionResult Create()
        {
            var TimeMandanteList = dbTime.TimeFutebols.ToList()
                .Select(s => new SelectListItem
                {
                    Value = s.TimeFutebolId.ToString(),
                    Text = s.Nome
                }).ToList();

            ViewBag.TimeMandanteList = TimeMandanteList;

            // Aqui você cria um novo objeto Partida vazio e passa para a View
            return View(new Partida());
        }

        // POST: Partidas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DataHora,Estadio,TimeMandanteId,TimeVisitanteId,GolsMandante,GolsVisitante,Status")] Partida partida)
        {
            if (ModelState.IsValid)
            {
                db.Partidas.Add(partida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(partida);
        }

        // GET: Partidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partidas.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // POST: Partidas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DataHora,Estadio,TimeMandanteId,TimeVisitanteId,GolsMandante,GolsVisitante,Status")] Partida partida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partida);
        }

        // GET: Partidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partidas.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // POST: Partidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Partida partida = db.Partidas.Find(id);
            db.Partidas.Remove(partida);
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
