using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartialViewHW.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult Detay(Models.urun data)
        {
            var veri=new Models.urun();
            veri.adi = "bot";
            veri.fiyati = 150;
            veri.kullanilmamislikdurumu = true;
            return View(veri);
        }
    }
}