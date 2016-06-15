using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TecWeb.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index(ControlAsistencia.Clase clase)
        {
            return View(clase);
        }
    }
}