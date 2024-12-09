using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SertifikalarController : Controller
    {
        // GET: Sertifikalar
        GenericRepositroy<TblSertifikalarım> repo = new GenericRepositroy<TblSertifikalarım>();
        public ActionResult Index()
        {
            var sertifikalar = repo.List();
            return View(sertifikalar);
        }

        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }

        [HttpPost]
        public ActionResult SertifikaGetir(TblSertifikalarım t)
        {
            var sertifika = repo.Find(x => x.ID == t.ID);
            sertifika.Aciklama = t.Aciklama;
            sertifika.Tarih = t.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(TblSertifikalarım t)
        {
           repo.TAdd(t);
            return RedirectToAction("Index");
        }

        public ActionResult SertifikaSil(int id)
        {
            TblSertifikalarım t = repo.TGet(id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
    }

}