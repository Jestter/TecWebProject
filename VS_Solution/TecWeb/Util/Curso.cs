using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecWeb.Util
{
    public class Curso
    {
        public static long ID { get; set; }
        public static string Nombre { get; set; }
        public static ControlAsistencia.Participante[] alumnos { get; set; }
        


    }
}