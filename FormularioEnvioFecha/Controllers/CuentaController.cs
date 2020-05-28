using FormularioEnvioFecha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioEnvioFecha.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        [HttpGet]
        public ActionResult Index()
        {
            Cuenta cuenta = new Cuenta() {
                FechaNacimiento = DateTime.Now
            };

            return View("Index", cuenta);
        }
        [HttpPost]
        public ActionResult Registrar(Cuenta cc) {
            ViewBag.cuenta = cc;
            return View("Success");
        }
    }
}