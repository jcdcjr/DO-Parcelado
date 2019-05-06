using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOParcelado.Controllers
{
    public class Fase1Controller : Controller
    {
        // GET: Default
        public ActionResult Processamento()
        {
            return View();
        }

        //ToDO
        [HttpPost]
        public ActionResult Processamento(string todo)
        {
            return View();
        }

        public ActionResult PendenciaTratativa()
        {
            return View();
        }

        public ActionResult Relatorios()
        {
            return View();
        }
    }
}