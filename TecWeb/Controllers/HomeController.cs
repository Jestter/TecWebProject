using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TecWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<ControlAsistencia.Participante> Profesores = new List<ControlAsistencia.Participante>();

            var Cursos = new ControlAsistencia.ControlAsistenciaClient().Cursos();
            foreach (var Cur in Cursos)
                foreach(var Profs in Cur.Profesores)
                    if (!Profesores.Any(P => P.Nombre.Equals(Profs.Nombre)))
                    {
                        Profesores.Add(Profs);
                    }
            Profesores.Sort((p1,p2) => p1.Nombre.CompareTo(p2.Nombre));
            Util.Sesion.Logout();
            return View(Profesores);
        }
    }
}