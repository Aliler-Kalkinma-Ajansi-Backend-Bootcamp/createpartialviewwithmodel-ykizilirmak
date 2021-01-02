using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartialView.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Parcali()
        {
            return View();
        }
        public ActionResult _Layout()
        {
            return View();
        }
        public ActionResult _Menu()
        {
            return PartialView();
        }
    }
}