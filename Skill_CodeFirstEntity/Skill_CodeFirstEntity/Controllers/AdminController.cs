using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.siniflar;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        CONTEXT c = new CONTEXT();
        public ActionResult Index()
        {
            var degerler = c.YETENEK.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult YeniYetenek(YETENEKLER y)
        {
            c.YETENEK.Add(y);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = c.YETENEK.Find(id);
            c.YETENEK.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var deger = c.YETENEK.Find(id);
            return View("YetenekGetir", deger);
        }
        [HttpPost]
        public ActionResult YetenekGetir(YETENEKLER y)
        {
            var x = c.YETENEK.Find(y.ID);
            x.ACIKLAMA = y.ACIKLAMA;
            x.DEGER = y.DEGER;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}