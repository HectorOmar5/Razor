using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        /* Dentro de la aplicación anterior, crear un controlador con los siguientes
        Métodos de Acción y Vistas */
        public ActionResult Accion()
        {
            return View();
        }
        public ActionResult Vista()
        {
            return View();
        }

        public ActionResult HolaMundo()
        {
            return View();
        }

        public ActionResult Ciclos()
        {
            return View();
        }
    }
}