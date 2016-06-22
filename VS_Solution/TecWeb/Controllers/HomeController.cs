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
            List<ControlAsistencia.Participante> Usuarios = new List<ControlAsistencia.Participante>();

            var Cursos = new ControlAsistencia.ControlAsistenciaClient().Cursos();
            foreach (var Cur in Cursos)
                foreach(var Profs in Cur.Profesores)
                    if (!Usuarios.Any(P => P.Nombre.Equals(Profs.Nombre)))
                    {
                        Usuarios.Add(Profs);
                    }
            Usuarios.Sort((p1,p2) => p1.Nombre.CompareTo(p2.Nombre));

            List<ControlAsistencia.Participante> Alumnos = new List<ControlAsistencia.Participante>();
            foreach (var Cur in Cursos)
                foreach (var alum in Cur.Alumnos)
                    if (!Alumnos.Any(P => P.Nombre.Equals(alum.Nombre)))
                    {
                        Alumnos.Add(alum);
                    }
            Alumnos.Sort((p1, p2) => p1.Nombre.CompareTo(p2.Nombre));
            //Util.Sesion.Logout();
            Usuarios.AddRange(Alumnos);
            return View(Usuarios);
        }
    }
}