using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartialViewHomework.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _LoginPartial()
        {
            return PartialView();
        }
        public IActionResult _sign()
        {
            return PartialView();
        }
    }
}