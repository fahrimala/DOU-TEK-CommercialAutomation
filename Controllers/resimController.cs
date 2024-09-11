using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class resimController : Controller
    {
        // GET: resim
        Context c = new Context();
        public ActionResult ResimYukle()
        {
            return View();
        }
        public ActionResult ResimYukle(HttpPostedFileBase httpPostedFileBase)
        {
            if (httpPostedFileBase.ContentLength > 0)
            {
                string isim = Path.GetFileName(httpPostedFileBase.FileName);
                string yol = Path.Combine(Server.MapPath("~/Image/"), isim);
                httpPostedFileBase.SaveAs(yol);
            }

            return View();
        }
        [HttpGet]
        public ActionResult Res2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Res2(Personel p)
        {
            //string isim = Path.GetFileName(p.ImageFile.FileName);
            //p.PersonelGorsel = "~/Image/" + isim;
            //isim = Path.Combine(Server.MapPath("~/Image/"), isim);
            //p.ImageFile.SaveAs(isim);
            //c.Personels.Add(p);
            //c.SaveChanges();
            return View();
        }
    }
}