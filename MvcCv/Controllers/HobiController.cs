using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;
namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepositroy<TblHobilerim> repo = new GenericRepositroy<TblHobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpPost]
        public ActionResult Index(TblHobilerim p)
        {
            //TblHobilerim t = new TblHobilerim();
            var t = repo.Find(x => x.ID==2);
            t.Aciklama1 = p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        } 
    }
}