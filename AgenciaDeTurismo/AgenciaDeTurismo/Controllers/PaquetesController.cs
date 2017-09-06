using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgenciaDeTurismo.Controllers
{
    public class PaquetesController : Controller
    {
        // GET: Paquetes
        public ActionResult Detalle()
        {
            return View();
        }

        public ActionResult Reservar()
        {
            return View();
        }


        public ActionResult Historial()
        {
            return View();
        }
    }
}