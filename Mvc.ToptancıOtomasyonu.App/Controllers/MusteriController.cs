using Mvc.ToptancıOtomasyonu.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.ToptancıOtomasyonu.App.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Uyelik()
        {
            List<Musteri> lst = new List<Musteri>()
            {
                new Musteri{Musteri_ID=1,AD="Ali",SOYAD="Can",Telefon="5271562306",Sifre="ndyefsxk57",TCKNo="58683218942" },
                new Musteri{Musteri_ID=1,AD="Veli",SOYAD="Can",Telefon="5271566803",Sifre="ndye45xk57",TCKNo="12383218942" }
            };
            return View(lst);
        }
    }
}