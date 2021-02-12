using Kindergarden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kindergarden.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Users user)
        {
            using (AnaokuluBilgiSistemiEntities5 db = new AnaokuluBilgiSistemiEntities5())
            {

                var usr = db.Users.Single(u => u.Email == user.Email && u.Sifre == user.Sifre && u.Admin == user.Admin);
                if (usr != null)
                {
                    if (user.Admin == "Evet")
                    {
                        return RedirectToAction(nameof(AdminIndex));
                    }
                    if (user.Admin == "Hayır")
                    {
                        return RedirectToAction(nameof(VeliIndex));
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Username or password is wrong.");
                    return View();
                }
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Users user)
        {
            if (ModelState.IsValid)
            {
                using (AnaokuluBilgiSistemiEntities5 db = new AnaokuluBilgiSistemiEntities5())
                {
                    db.Users.Add(user);
                    db.SaveChanges();

                }
                ModelState.Clear();
                ViewBag.message = "Başarılı";

            }
            return RedirectToAction(nameof(Index));
        }

        public ActionResult AdminIndex()
        {
            return View();
        }
        public ActionResult VeliIndex()
        {
            return View();
        }
        public ActionResult OgrenciKayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OgrenciKayit(Cocuk cocuk)
        {
            if (ModelState.IsValid)
            {
                using (AnaokuluBilgiSistemiEntities5 db = new AnaokuluBilgiSistemiEntities5())
                {
                    db.Cocuk.Add(cocuk);
                    db.SaveChanges();

                }
                ModelState.Clear();
                ViewBag.message = "Başarılı";

            }
            return RedirectToAction(nameof(AdminIndex));
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CocukBilgileri(string searchString)
        {

            using (AnaokuluBilgiSistemiEntities5 db = new AnaokuluBilgiSistemiEntities5())
            {
                var kid = (from r in db.Cocuk where r.Cad.Contains(searchString) select r).ToList();

                return View(kid);
            }
        }
        public ActionResult GelenMesaj(string searchString)
        {

            using (AnaokuluBilgiSistemiEntities5 db = new AnaokuluBilgiSistemiEntities5())
            {
                var msg = (from r in db.Mesaj where r.Email.Contains(searchString) select r).ToList();

                return View(msg);
            }
        }
        public ActionResult Listele()
        {
            using (AnaokuluBilgiSistemiEntities5 db = new AnaokuluBilgiSistemiEntities5())
            {
                return View(db.Cocuk.ToList());
            }


        }
        public ActionResult MesajGonder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MesajGonder(Mesaj messages)
        {
            
                if (ModelState.IsValid)
                {
                using (AnaokuluBilgiSistemiEntities5 db = new AnaokuluBilgiSistemiEntities5())
                {
                        db.Mesaj.Add(messages);
                        db.SaveChanges();

                    }
                    ModelState.Clear();
                    ViewBag.message = "Başarılı";

                }
                return RedirectToAction(nameof(AdminIndex));
            
        }
    }
}