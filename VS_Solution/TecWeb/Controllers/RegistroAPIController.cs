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

        public class PostData
        {
            public long IdPar { get; set; }
            public long IdCur { get; set; }
            public long Fecha { get; set; }
        }

        // GET: api/RegistroAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegistroAPI/5
        public string Get([FromBody]string value)
        {
            return "value";
        }

        // POST: api/RegistroAPI
        public void Post([FromBody]PostData data)
        {
            new ControlAsistencia.ControlAsistenciaClient().RegistrarAsistencia(data.IdPar, data.IdCur, data.Fecha);
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
