using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiRestIPH.Controllers
{
    public class IPHController : ApiController
    {


        // GET api/values
        public List<IPH> Get()
        {
            List<IPH> personas = new List<IPH>();
            IPH per = new IPH();
            per.idFuente = 3;
            per.nombre = "JUAN";
            per.paterno = "PEREZ";
            per.materno = "MATINEZ";
            per.curp = "MAVA750909MMSZLM01";
            per.fechanac = "09/09/1975";

            personas.Add(per);

            return personas;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }



        public class IPH
        {
            public int idFuente;
            public string nombre;
            public string paterno;
            public string materno;
            public string curp;
            public string fechanac;
        }
    }



}
