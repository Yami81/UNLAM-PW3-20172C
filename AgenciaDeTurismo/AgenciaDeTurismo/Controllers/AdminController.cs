using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgenciaDeTurismo.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Paquete(string subaction, int id)
        {
            ViewBag.subaccion = subaction;
            return View();
        }


    }
}