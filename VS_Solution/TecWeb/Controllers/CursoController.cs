using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TecWeb.Controllers
{
    public class CursoController : Controller
    {
        public ActionResult Index()
        {
            var serv = new ControlAsistencia.ControlAsistenciaClient();
            var Cursos = serv.Cursos();
            return View(Cursos);
        }

        public ActionResult Detalles(long id)
        {
            var serv = new ControlAsistencia.ControlAsistenciaClient();
            var Curso = serv.Curso(id);
            Util.Curso.alumnos = Curso.Alumnos;
            Util.Curso.ID = id;
            Util.Curso.Nombre = Curso.Nombre;
            return View(Curso);
        }

    }
}