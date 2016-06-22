using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TecWeb.Controllers
{
    public class UsuarioController : Controller
    {
        
        public ActionResult Login(long id,string nombre)
        {
            Util.Sesion.UserID = id;
            Util.Sesion.UserName = nombre;
            return RedirectToAction("Index", "Usuario");
        }

        public ActionResult Logout()
        {
            Util.Sesion.Logout();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Index()
        {
            if(!Util.Sesion.Authenticated())
            {
                return RedirectToAction("Index", "Home");
            }
            //var Cursos = new ControlAsistencia.ControlAsistenciaClient().CursosPorProfesor(Util.Sesion.UserID);

            var Cursos = new ControlAsistencia.ControlAsistenciaClient().Cursos();
            
            return View(Cursos.Where(C => C.Profesores.Any(p => (p.ID == Util.Sesion.UserID) || C.Alumnos.Any(a => a.ID == Util.Sesion.UserID))));
        }
    }
}