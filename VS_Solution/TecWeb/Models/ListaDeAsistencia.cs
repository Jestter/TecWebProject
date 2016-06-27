using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecWeb.Models
{
    //Clase para el modelo del registro de asistencia
    public class ListaDeAsistencia
    {
        public ControlAsistencia.Clase Clase { get; set; }
        public ControlAsistencia.Participante[] Participantes { get; set; }
        public long IdCurso { get; set; }
        public string NombreCurso { get; set; }
    }
}