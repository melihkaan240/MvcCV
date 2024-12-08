using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepositroy<TblSertifikalarım> repo = new GenericRepositroy<TblSertifikalarım>();
        public ActionResult Index()
        {
            var sertifikalar = repo.List();
            return View(sertifikalar);
        }
    }
}