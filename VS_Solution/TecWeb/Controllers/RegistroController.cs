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
        public ActionResult Index(long idClase,long idCurso)
        {
            var Curso = new ControlAsistencia.ControlAsistenciaClient().Curso(idCurso);
            if(!Curso.Profesores.Any(p => p.ID == Util.Sesion.UserID))
            {
                return RedirectToAction("Index","Home");
            }
            var clase = Curso.Horario[idClase];
            var lista = new Models.ListaDeAsistencia() { IdCurso = idCurso, Clase = clase, NombreCurso = Curso.Nombre, Participantes = Curso.Alumnos };
            return View(lista);
        }
    }
}