using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoMVC.EDMX;

namespace ProjetoMVC.Controllers
{
    public class TipologiaController : Controller
    {
        private DB_SISCODHABEntities db = new DB_SISCODHABEntities();

        //
        // GET: /Tipologia/

        public ActionResult Index()
        {
            return View(db.TB_TIPOLOGIA.ToList());
        }

        //
        // GET: /Tipologia/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_TIPOLOGIA tb_tipologia = db.TB_TIPOLOGIA.Find(id);
            if (tb_tipologia == null)
            {
                return HttpNotFound();
            }
            return View(tb_tipologia);
        }

        //
        // GET: /Tipologia/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tipologia/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TB_TIPOLOGIA tb_tipologia)
        {
            if (ModelState.IsValid)
            {
                db.TB_TIPOLOGIA.Add(tb_tipologia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_tipologia);
        }

        //
        // GET: /Tipologia/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_TIPOLOGIA tb_tipologia = db.TB_TIPOLOGIA.Find(id);
            if (tb_tipologia == null)
            {
                return HttpNotFound();
            }
            return View(tb_tipologia);
        }

        //
        // POST: /Tipologia/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TB_TIPOLOGIA tb_tipologia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_tipologia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_tipologia);
        }

        //
        // GET: /Tipologia/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_TIPOLOGIA tb_tipologia = db.TB_TIPOLOGIA.Find(id);
            if (tb_tipologia == null)
            {
                return HttpNotFound();
            }
            return PartialView(tb_tipologia);
        }

        //
        // POST: /Tipologia/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_TIPOLOGIA tb_tipologia = db.TB_TIPOLOGIA.Find(id);
            db.TB_TIPOLOGIA.Remove(tb_tipologia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}