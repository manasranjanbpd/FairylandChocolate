using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FairylandChocolate.Controllers
{
    public class ChocolatesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
