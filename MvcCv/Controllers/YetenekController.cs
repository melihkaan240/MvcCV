using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Repositories;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
        //DbCvEntities db = new DbCvEntities();
        GenericRepositroy<TblYetenekler> repo = new GenericRepositroy<TblYetenekler>();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(TblYetenekler p)
        {
            repo.TAdd(p);
            return RedirectToAction("index");
        } 
        public ActionResult YetenekSil(int id)
        {
            //repo.TDelete(repo.TGet(id));
            var yetenek = repo.Find(x => x.ID == id);
            repo.TDelete(yetenek);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult YetenekDuzenle(int id)
        {
            //repo.TDelete(repo.TGet(id));
            var yetenek = repo.Find(x => x.ID == id);
            //repo.TDelete(yetenek);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(TblYetenekler t)
        {
            //repo.TDelete(repo.TGet(id));
            var y = repo.Find(x => x.ID == t.ID);
            y.Yetenek = t.Yetenek;
            y.Oran = t.Oran;
            repo.TUpdate(y);
            return RedirectToAction("index");
        }
    }
}