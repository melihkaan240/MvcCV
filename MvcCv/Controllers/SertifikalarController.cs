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
    }
}