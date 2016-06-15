using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TecWeb.Controllers
{
    public class RegistroAPIController : ApiController
    {
        // GET: api/RegistroAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegistroAPI/5
        [Route("api/RegistroAPI/{idPar}/{idCur}/{fecha}")]
        public string Get(long idPar, long idCur, long fecha)
        {
            Console.WriteLine(idPar);
            return "value";
        }

        // POST: api/RegistroAPI
        [Route("api/RegistroAPI/{idPar}/{idCur}/{fecha}")]
        public void Post(long idPar,long idCur,long fecha)
        {
            Console.WriteLine(idPar);
           
            //new ControlAsistencia.ControlAsistenciaClient().RegistrarAsistencia(idPar,idCur,fecha);
        }

        // PUT: api/RegistroAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegistroAPI/5
        public void Delete(int id)
        {
        }
    }
}
